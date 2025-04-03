using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wep_API.DTOs;
using Wep_API.Models;

namespace Wep_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDBContext _Context;

        public ProductsController(ApplicationDBContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var Products = await _Context.Products.ToListAsync();
            return Ok(Products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAsync(CreateProductDTO product)
        {
            using var dataStream = new MemoryStream();
            await product.Image.CopyToAsync(dataStream);
            Product newProduct = new Product
            {
                Name = product.Name,
                Stock = product.Stock,
                Price = product.Price,
                CategoryId = product.CategoryId,
                Description = product.Description,
                Image = dataStream.ToArray()
            };
            await _Context.Products.AddAsync(newProduct);
            _Context.SaveChanges();

            return Ok(newProduct);
        }
    }
}
