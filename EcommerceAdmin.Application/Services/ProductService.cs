using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceAdmin.Core.Entities;
using EcommerceAdmin.Application.Interfaces;
using EcommerceAdmin.Core.Interfaces;

namespace EcommerceAdmin.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _productRepository.GetAllAsync();
    }

    public async Task<Product?> GetProductByIdAsync(Guid id)
    {
        return await _productRepository.GetByIdAsync(id);
    }

    public async Task<Product> CreateProductAsync(Product product)
    {
        product.Id = Guid.NewGuid();
        product.CreatedAt = DateTime.UtcNow;
        return await _productRepository.AddAsync(product);
    }

    public async Task<bool> UpdateProductAsync(Guid id, Product product)
    {
        if (id != product.Id)
        {
            return false;
        }

        product.UpdatedAt = DateTime.UtcNow;
        return await _productRepository.UpdateAsync(product);
    }

    public async Task<bool> DeleteProductAsync(Guid id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product == null)
        {
            return false;
        }

        return await _productRepository.DeleteAsync(product);
    }
}
