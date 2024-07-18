using DomainLayer.DomainModels;
using DomainLayer.Interfaces;
using RepositoryLayer.Contexts;

namespace RepositoryLayer.Repositories
{
    public class AttributeRepo : GenericRepo<Attributes>, IAttributeRepo
    {
        public AttributeRepo(MarketContext context) : base(context)
        {
        }
    }
}