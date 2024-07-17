﻿using DomainLayer.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositoryLayer.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        protected readonly DbContext _context;

        public GenericRepo(DbContext context) 
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}