using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceAdmin.Core.Entities;
using EcommerceAdmin.Core.Interfaces;
using EcommerceAdmin.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAdmin.Infrastructure.Repositories;

public class CatalogItemRepository : ICatalogItemRepository
{
    private readonly CatalogDbContext _context;

    public CatalogItemRepository(CatalogDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<CatalogItem>> GetAllAsync()
    {
        return await _context.CatalogItems.ToListAsync();
    }

    public async Task<CatalogItem?> GetByIdAsync(int id)
    {
        return await _context.CatalogItems.FindAsync(id);
    }

    public async Task<CatalogItem> AddAsync(CatalogItem catalogItem)
    {
        _context.CatalogItems.Add(catalogItem);
        await _context.SaveChangesAsync();
        return catalogItem;
    }

    public async Task<bool> UpdateAsync(CatalogItem catalogItem)
    {
        _context.Entry(catalogItem).State = EntityState.Modified;
        
        try
        {
            await _context.SaveChangesAsync();
            return true;
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await ExistsAsync(catalogItem.Id))
            {
                return false;
            }
            throw;
        }
    }

    public async Task<bool> DeleteAsync(CatalogItem catalogItem)
    {
        _context.CatalogItems.Remove(catalogItem);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _context.CatalogItems.AnyAsync(e => e.Id == id);
    }
}
