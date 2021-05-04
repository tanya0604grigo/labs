using Microsoft.EntityFrameworkCore;

namespace Web_Service.Models
{
    public class PriorityproductsdbMainContext : DbContext
    {
        public PriorityproductsdbMainContext()
        {
        }

        public DbSet<PriorityproductInfo> Priorityproducts { get; set; }

        public PriorityproductsdbMainContext(DbContextOptions<PriorityproductsdbMainContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();           
        }
    }
}