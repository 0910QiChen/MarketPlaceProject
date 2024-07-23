using DomainLayer.DomainModels;
using DomainLayer.Interfaces;
using RepositoryLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class KeySpecRepo : GenericRepo<KeySpec>, IKeySpecRepo
    {
        public KeySpecRepo(MarketContext context) : base(context)
        {
        }

    }
}
