using EcommerceAdmin.Core.Entities;
using EcommerceAdmin.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAdmin.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class CatalogItemController : ControllerBase
{
    private readonly ICatalogItemService _productService;

    public CatalogItemController(ICatalogItemService productService)
    {
        _productService = productService;
    }

    // GET: api/CatalogItem
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CatalogItem>>> GetProducts()
    {
        var catalogItems = await _productService.GetAllProductsAsync();
        return Ok(catalogItems);
    }

    // GET: api/CatalogItem/5
    [HttpGet("{id}")]
    public async Task<ActionResult<CatalogItem>> GetProduct(int id)
    {
        var catalogItem = await _productService.GetProductByIdAsync(id);

        if (catalogItem == null)
        {
            return NotFound();
        }

        return Ok(catalogItem);
    }

    // PUT: api/CatalogItem/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutProduct(int id, CatalogItem catalogItem)
    {
        var updated = await _productService.UpdateProductAsync(id, catalogItem);

        if (!updated)
        {
            return BadRequest();
        }

        return NoContent();
    }

    // POST: api/CatalogItem
    [HttpPost]
    public async Task<ActionResult<CatalogItem>> PostProduct(CatalogItem catalogItem)
    {
        var createdProduct = await _productService.CreateProductAsync(catalogItem);

        return CreatedAtAction(nameof(GetProduct), new { id = createdProduct.Id }, createdProduct);
    }

    // DELETE: api/CatalogItem/5
    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var deleted = await _productService.DeleteProductAsync(id);
        
        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}
