using Microsoft.EntityFrameworkCore;

namespace Mission6_Hull.Models
{
    public class CollectionFormContext : DbContext
    {
        public CollectionFormContext(DbContextOptions<CollectionFormContext> options) : base (options) //Constructor
        {
        }

        public DbSet<Form> Forms { get; set; }
    }
}