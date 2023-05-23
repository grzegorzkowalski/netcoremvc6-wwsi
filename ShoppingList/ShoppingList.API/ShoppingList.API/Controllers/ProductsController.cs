using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingList.API.Data;
using ShoppingList.API.Models;

namespace ShoppingList.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly ShoppingListAPIDbContext dbContext;

        public ProductsController(ShoppingListAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await dbContext.Products.ToListAsync());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetProduct([FromRoute] Guid id)
        {

            var product = await dbContext.Products.FindAsync(id);

            if (product != null)
            {
                return Ok(product);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductRequest addProductRequest)
        {
            var product = new Product
            {
                Id = new Guid(),
                Name = addProductRequest.Name,
                Price = addProductRequest.Price,
                Quantity = addProductRequest.Quantity
            };

            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();

            return Ok(product);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] Guid id, UpdateProductRequest updateProductRequest)
        {
            var product = await dbContext.Products.FindAsync(id);

            if (product != null)
            {
                product.Name = updateProductRequest.Name;
                product.Price = updateProductRequest.Price;
                product.Quantity = updateProductRequest.Quantity;

                await dbContext.SaveChangesAsync();

                return Ok(product);
            }

            return NotFound();
        }


        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
        {

            var product = await dbContext.Products.FindAsync(id);

            if (product != null)
            {
                dbContext.Remove(product);
                await dbContext.SaveChangesAsync();
 
                return Ok(product);
            }

            return NotFound();
        }

    }
}
