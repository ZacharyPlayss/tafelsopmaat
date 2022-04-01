using Microsoft.EntityFrameworkCore;

namespace TafelsOpMaatWebAPI.Models
{
    public class TafelsOpMaatContext : DbContext
    {
        public TafelsOpMaatContext(DbContextOptions<TafelsOpMaatContext> options) : base(options)
        {

        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
    }
}
