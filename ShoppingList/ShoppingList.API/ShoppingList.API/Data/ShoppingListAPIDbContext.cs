using Microsoft.EntityFrameworkCore;
using ShoppingList.API.Models;

namespace ShoppingList.API.Data
{
    public class ShoppingListAPIDbContext : DbContext
    {
        public ShoppingListAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
