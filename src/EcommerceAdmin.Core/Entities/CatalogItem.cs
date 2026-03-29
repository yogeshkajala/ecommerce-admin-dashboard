using System;

namespace EcommerceAdmin.Core.Entities;

public class CatalogItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? PictureFileName { get; set; }
    public int CatalogTypeId { get; set; }
    public int CatalogBrandId { get; set; }
    public int AvailableStock { get; set; }
    public int RestockThreshold { get; set; }
    public int MaxStockThreshold { get; set; }
    public bool OnReorder { get; set; }
    
    // Add these back if needed for audit, but removing them to purely match eShop is better.
    // eShop doesn't explicitly have CreatedAt/UpdatedAt on the model in the same way.
}
