using DomainLayer.DomainModels;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RepositoryLayer.Contexts
{
    public class MarketContext : DbContext
    {
        public MarketContext() : base("MarketContext")
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}