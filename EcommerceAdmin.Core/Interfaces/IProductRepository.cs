using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceAdmin.Core.Entities;

namespace EcommerceAdmin.Core.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(Guid id);
    Task<Product> AddAsync(Product product);
    Task<bool> UpdateAsync(Product product);
    Task<bool> DeleteAsync(Product product);
    Task<bool> ExistsAsync(Guid id);
}
