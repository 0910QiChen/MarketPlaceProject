using System;

namespace DomainLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepo UserRepo { get; }
        IProductRepo ProductRepo { get; }
        ICategoryRepo CategoryRepo { get; }
        ISubCateRepo SubCateRepo { get; }
        IAttributeRepo AttributeRepo { get; }
        IADRepo ADRepo { get; }
        IKeySpecRepo KeySpecRepo { get; }
        void commit();
    }
}