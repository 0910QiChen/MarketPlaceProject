using DomainLayer.DomainModels;
using DomainLayer.Interfaces;
using RepositoryLayer.Contexts;

namespace RepositoryLayer.Repositories
{
    public class CategoryRepo : GenericRepo<Categories>, ICategoryRepo
    {
        public CategoryRepo(MarketContext context) : base(context)
        {
        }
    }
}