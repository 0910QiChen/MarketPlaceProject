using DomainLayer.DomainModels;
using DomainLayer.Interfaces;
using RepositoryLayer.Contexts;

namespace RepositoryLayer.Repositories
{
    public class ProductRepo : GenericRepo<Products>, IProductRepo
    {
        public ProductRepo(MarketContext context) : base(context)
        {
        }
    }
}