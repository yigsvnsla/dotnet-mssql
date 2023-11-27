using Microsoft.EntityFrameworkCore;
using Server.Models.ProductModel;

namespace Server.Contexts.ProductDbCtx
{
    class ProductDbCtx : DbContext
    {
        public ProductDbCtx(DbContextOptions<ProductDbCtx> options) : base(options)
        {
            // Products = Set<TodoModel>();
        }
        public DbSet<ProductModel> Products { get; set; } = null!;
    }
}