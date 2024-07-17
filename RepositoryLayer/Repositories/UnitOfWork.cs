using DomainLayer.Interfaces;
using RepositoryLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MarketContext _context;
        public IProductRepo ProductRepo { get; }

        public IUserRepo UserRepo { get; }

        public UnitOfWork(MarketContext context)
        {
            _context = context;
            ProductRepo = new ProductRepo(_context);
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