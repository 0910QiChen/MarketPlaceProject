using System.Collections.Generic;
using System.Data.Entity;
using DomainLayer.DomainModels;

namespace RepositoryLayer.Contexts
{
    public class MarketInitializer : DropCreateDatabaseIfModelChanges<MarketContext>
    {
        protected override void Seed(MarketContext _context)
        {
            var categories = new List<Categories>
            {
                new Categories { },
                new Categories { },
                new Categories { },
                new Categories { },
            };
            categories.ForEach(c => _context.Categories.Add(c));
            _context.SaveChanges();

            var subCategories = new List<SubCategories>
            {
                new SubCategories { },
                new SubCategories { },
                new SubCategories { },
                new SubCategories { },
                new SubCategories { },
                new SubCategories { },
                new SubCategories { },
                new SubCategories { },
                new SubCategories { },
                new SubCategories { },
                new SubCategories { },
            };
            subCategories.ForEach(sc => _context.SubCategories.Add(sc));
            _context.SaveChanges();

            var products = new List<Products>
            {
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
                new Products{ },
            };
            products.ForEach(p => _context.Products.Add(p));
            _context.SaveChanges();

            var attributes = new List<Attributes>
            {
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
                new Attributes{ },
            };
            attributes.ForEach(a => _context.Attributes.Add(a));
            _context.SaveChanges();

            var details = new List<AttributeDetails>
            {
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
                new AttributeDetails{ },
            };
            details.ForEach(d => _context.AttributeDetails.Add(d));
            _context.SaveChanges();
        }
    }
}