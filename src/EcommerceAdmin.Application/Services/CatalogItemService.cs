using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceAdmin.Core.Entities;
using EcommerceAdmin.Application.Interfaces;
using EcommerceAdmin.Core.Interfaces;

namespace EcommerceAdmin.Application.Services;

public class CatalogItemService : ICatalogItemService
{
    private readonly ICatalogItemRepository _catalogItemRepository;

    public CatalogItemService(ICatalogItemRepository catalogItemRepository)
    {
        _catalogItemRepository = catalogItemRepository;
    }

    public async Task<IEnumerable<CatalogItem>> GetAllProductsAsync()
    {
        return await _catalogItemRepository.GetAllAsync();
    }

    public async Task<CatalogItem?> GetProductByIdAsync(int id)
    {
        return await _catalogItemRepository.GetByIdAsync(id);
    }

    public async Task<CatalogItem> CreateProductAsync(CatalogItem catalogItem)
    {
        // Removed ID assignment since int identity columns auto-increment.
        return await _catalogItemRepository.AddAsync(catalogItem);
    }

    public async Task<bool> UpdateProductAsync(int id, CatalogItem catalogItem)
    {
        if (id != catalogItem.Id)
        {
            return false;
        }

        return await _catalogItemRepository.UpdateAsync(catalogItem);
    }

    public async Task<bool> DeleteProductAsync(int id)
    {
        var catalogItem = await _catalogItemRepository.GetByIdAsync(id);
        if (catalogItem == null)
        {
            return false;
        }

        return await _catalogItemRepository.DeleteAsync(catalogItem);
    }
}
