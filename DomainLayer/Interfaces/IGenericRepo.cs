using System.Collections.Generic;

namespace DomainLayer.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        T getById(int id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
    }
}