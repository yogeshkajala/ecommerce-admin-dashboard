using System;
using System.Linq;
using EcommerceAdmin.Core.Entities;
using EcommerceAdmin.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace EcommerceAdmin.Tests.Database;

public class DatabaseConnectionTests
{
    [Fact]
    public void CatalogDbContext_CanInsertAndRetrieveCatalogItem()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<CatalogDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        var catalogItem = new CatalogItem
        {
            Id = 1,
            Name = "Test CatalogItem",
            Description = "A catalogItem for unit testing.",
            Price = 99.99m,
            AvailableStock = 10,
            CatalogBrandId = 1,
            CatalogTypeId = 1
        };

        // Act
        using (var context = new CatalogDbContext(options))
        {
            context.CatalogItems.Add(catalogItem);
            context.SaveChanges();
        }

        // Assert
        using (var context = new CatalogDbContext(options))
        {
            var savedItem = context.CatalogItems.FirstOrDefault(p => p.Name == "Test CatalogItem");
            Assert.NotNull(savedItem);
            Assert.Equal("Test CatalogItem", savedItem.Name);
            Assert.Equal(99.99m, savedItem.Price);
        }
    }
}
