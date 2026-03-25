using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceAdmin.Core.Entities;

namespace EcommerceAdmin.Application.Interfaces;

public interface ICatalogItemService
{
    Task<IEnumerable<CatalogItem>> GetAllProductsAsync();
    Task<CatalogItem?> GetProductByIdAsync(int id);
    Task<CatalogItem> CreateProductAsync(CatalogItem catalogItem);
    Task<bool> UpdateProductAsync(int id, CatalogItem catalogItem);
    Task<bool> DeleteProductAsync(int id);
}
