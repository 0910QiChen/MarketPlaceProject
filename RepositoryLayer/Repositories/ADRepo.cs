using DomainLayer.DomainModels;
using DomainLayer.Interfaces;
using RepositoryLayer.Contexts;

namespace RepositoryLayer.Repositories
{
    public class ADRepo : GenericRepo<AttributeDetails>, IADRepo
    {
        public ADRepo(MarketContext context) : base(context)
        {
        }
    }
}