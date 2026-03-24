using System;
using EcommerceAdmin.Core.Entities;
using EcommerceAdmin.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace EcommerceAdmin.Tests.Database;

public class DatabaseConnectionTests
{
    [Fact]
    public void CatalogDbContext_CanInsertAndRetrieveProduct()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<CatalogDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        var product = new Product
        {
            Id = Guid.NewGuid(),
            Name = "Test Product",
            Description = "A product for unit testing.",
            Price = 99.99m,
            StockQuantity = 10,
            SKU = "TEST-001",
            CreatedAt = DateTime.UtcNow
        };

        // Act
        using (var context = new CatalogDbContext(options))
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        // Assert
        using (var context = new CatalogDbContext(options))
        {
            var savedProduct = context.Products.FirstOrDefault(p => p.SKU == "TEST-001");
            Assert.NotNull(savedProduct);
            Assert.Equal("Test Product", savedProduct.Name);
            Assert.Equal(99.99m, savedProduct.Price);
        }
    }
}
