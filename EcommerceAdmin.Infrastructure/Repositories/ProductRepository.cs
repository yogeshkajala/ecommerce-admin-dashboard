using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceAdmin.Core.Entities;
using EcommerceAdmin.Core.Interfaces;
using EcommerceAdmin.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAdmin.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly CatalogDbContext _context;

    public ProductRepository(CatalogDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(Guid id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<Product> AddAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<bool> UpdateAsync(Product product)
    {
        _context.Entry(product).State = EntityState.Modified;
        
        try
        {
            await _context.SaveChangesAsync();
            return true;
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await ExistsAsync(product.Id))
            {
                return false;
            }
            throw;
        }
    }

    public async Task<bool> DeleteAsync(Product product)
    {
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> ExistsAsync(Guid id)
    {
        return await _context.Products.AnyAsync(e => e.Id == id);
    }
}
