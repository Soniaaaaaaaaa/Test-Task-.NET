using Microsoft.EntityFrameworkCore;

namespace Test_Task.Models
{
    public class CatalogContext :DbContext
    {
        public DbSet<Catalog> Catalogs { get; set; }
        public CatalogContext(DbContextOptions options) : base(options) { }
    }
}
