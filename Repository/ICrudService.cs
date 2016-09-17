using System.Collections.Generic;

namespace Repository
{
    public interface ICrudService<T>
    {
        FluentySessionFactory Factory { get; }
        void Insert(T entity);
        void Edit(T entity);
        void Delete(T entity);
        T GetByID(int id);
        IList<T> Get();
    }
}
