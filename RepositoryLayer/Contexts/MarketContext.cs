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
        public DbSet<KeySpec> KeySpec { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Entity<SubCategories>()
                .HasRequired(sc => sc.Category)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(sc => sc.CategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasRequired(p => p.SubCategory)
                .WithMany(sc => sc.Products)
                .HasForeignKey(p => p.SubCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Attributes>()
                .HasRequired(a => a.SubCategory)
                .WithMany(sc => sc.Attributes)
                .HasForeignKey(a => a.SubCategoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AttributeDetails>()
                .HasRequired(ad => ad.Attribute)
                .WithMany(a => a.AttributeDetails)
                .HasForeignKey(ad => ad.AttributeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AttributeDetails>()
                .HasRequired(ad => ad.Product)
                .WithMany(p => p.AttributeDetails)
                .HasForeignKey(ad => ad.ProductID)
                .WillCascadeOnDelete(false);

           modelBuilder.Entity<Products>()
                .HasMany(p => p.KeySpecs)
                .WithRequired(ks => ks.Product)
                .HasForeignKey(ks => ks.ProductID)
                .WillCascadeOnDelete(false);
        }
    }
}