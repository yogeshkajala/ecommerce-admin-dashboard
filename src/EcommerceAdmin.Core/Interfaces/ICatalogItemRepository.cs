using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceAdmin.Core.Entities;

namespace EcommerceAdmin.Core.Interfaces;

public interface ICatalogItemRepository
{
    Task<IEnumerable<CatalogItem>> GetAllAsync();
    Task<CatalogItem?> GetByIdAsync(int id);
    Task<CatalogItem> AddAsync(CatalogItem catalogItem);
    Task<bool> UpdateAsync(CatalogItem catalogItem);
    Task<bool> DeleteAsync(CatalogItem catalogItem);
    Task<bool> ExistsAsync(int id);
}
