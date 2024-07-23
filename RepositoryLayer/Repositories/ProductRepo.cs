using DomainLayer.DomainModels;
using DomainLayer.Interfaces;
using RepositoryLayer.Contexts;
using System.Runtime.Remoting.Contexts;

namespace RepositoryLayer.Repositories
{
    public class ProductRepo : GenericRepo<Products>, IProductRepo
    {
        public ProductRepo(MarketContext context) : base(context)
        {
        }

    }
}