using DomainLayer.DomainModels;
using DomainLayer.Interfaces;
using RepositoryLayer.Contexts;

namespace RepositoryLayer.Repositories
{
    public class SubCateRepo : GenericRepo<SubCategories>, ISubCateRepo
    {
        public SubCateRepo(MarketContext context) : base(context)
        {
        }
    }
}