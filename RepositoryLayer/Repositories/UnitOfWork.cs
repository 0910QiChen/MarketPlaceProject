using DomainLayer.Interfaces;
using RepositoryLayer.Contexts;
using System;

namespace RepositoryLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MarketContext _context;
        public IUserRepo UserRepo { get; }
        public IProductRepo ProductRepo { get; }
        public ICategoryRepo CategoryRepo {  get; }
        public ISubCateRepo SubCateRepo { get; }
        public IAttributeRepo AttributeRepo { get; }
        public IADRepo ADRepo { get; }
        public IKeySpecRepo KeySpecRepo { get; }

        public UnitOfWork(MarketContext context)
        {
            _context = context;
            UserRepo = new UserRepo(_context);
            ProductRepo = new ProductRepo(_context);
            CategoryRepo = new CategoryRepo(_context);
            SubCateRepo = new SubCateRepo(_context);
            AttributeRepo = new AttributeRepo(_context);
            ADRepo = new ADRepo(_context);
            KeySpecRepo = new KeySpecRepo(_context);
        }

        public void commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}