using System.Collections.Generic;
using System.Data.Entity;
using DomainLayer.DomainModels;

namespace RepositoryLayer.Contexts
{
    public class MarketInitializer : DropCreateDatabaseIfModelChanges<MarketContext>
    {
        protected override void Seed(MarketContext _context)
        {
            var products = new List<Products>
            {
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2000 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2000 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2001 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2001 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2002 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2002 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2003 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2003 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2004 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2004 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2005 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2005 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2006 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2006 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2007 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2007 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2008 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2008 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2009 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2009 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2010 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2010 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2011 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2011 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2012 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2012 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2013 },
                new Products{ ProductName = "", SubCategory = "", Category = "", ModelName = "", ModelYear = 2013 },
            };
            products.ForEach(p => _context.Products.Add(p));
            _context.SaveChanges();
        }
    }
}