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
        public DbSet<Categories> Categories { get; set; }
        public DbSet<SubCategories> SubCategories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
        public DbSet<AttributeDetails> AttributeDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}