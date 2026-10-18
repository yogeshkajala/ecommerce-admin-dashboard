# ─────────────────────────────────────────────────────────────────────────────
#  Stage 1: Build
#  Uses the full .NET SDK to restore, build, and publish the application.
#  No secrets are present at build time — all config is injected at runtime.
# ─────────────────────────────────────────────────────────────────────────────
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution file first for restore caching
COPY EcommerceAdmin.sln ./

# Copy all project files (preserving relative paths for solution restore)
COPY src/EcommerceAdmin.API/EcommerceAdmin.API.csproj               src/EcommerceAdmin.API/
COPY src/EcommerceAdmin.Application/EcommerceAdmin.Application.csproj src/EcommerceAdmin.Application/
COPY src/EcommerceAdmin.Core/EcommerceAdmin.Core.csproj             src/EcommerceAdmin.Core/
COPY src/EcommerceAdmin.Infrastructure/EcommerceAdmin.Infrastructure.csproj src/EcommerceAdmin.Infrastructure/

# Restore dependencies (cached as long as .csproj files don't change)
RUN dotnet restore EcommerceAdmin.sln

# Copy remaining source code (src only — .dockerignore excludes tests/, client/ etc.)
COPY src/ src/

# Build and publish in Release mode to /app/publish
RUN dotnet publish src/EcommerceAdmin.API/EcommerceAdmin.API.csproj \
      --configuration Release \
      --no-restore \
      --output /app/publish \
      /p:UseAppHost=false

# ─────────────────────────────────────────────────────────────────────────────
#  Stage 2: Runtime
#  Minimal Alpine-based ASP.NET Core runtime image.
#  Only the published output is copied — no SDK, no source code.
# ─────────────────────────────────────────────────────────────────────────────
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS runtime
WORKDIR /app

# Create a non-root user for security
RUN addgroup --system --gid 1001 appgroup && \
    adduser  --system --uid 1001 --ingroup appgroup --no-create-home appuser

# Copy published output from build stage
COPY --from=build --chown=appuser:appgroup /app/publish .

# Switch to non-root user
USER appuser

# Expose the internal HTTP port (Traefik handles TLS termination externally)
EXPOSE 8080

# ASP.NET Core environment variables
# All other config (connection strings, secrets) is injected via docker-compose env_file
ENV ASPNETCORE_URLS=http://+:8080 \
    ASPNETCORE_ENVIRONMENT=Production \
    DOTNET_RUNNING_IN_CONTAINER=true

ENTRYPOINT ["dotnet", "EcommerceAdmin.API.dll"]
