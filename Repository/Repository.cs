using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate.Linq;

namespace Repository
{
    public class Repository<T> : ICrudService<T> where T : class
    {
        public FluentySessionFactory Factory => new FluentySessionFactory();

        public void Insert(T entity)
        {
            using (var session = Factory.Session)
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entity);
                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw new Exception("Ошибка вставки сущности: " + ex.Message);
                    }
                }
            }
        }

        public void Edit(T entity)
        {
            using (var session = Factory.Session)
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entity);
                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw new Exception("Ошибка при обновлении сущности: " + ex.Message);
                    }
                }
            }
        }

        public void Delete(T entity)
        {
            using (var session = Factory.Session)
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entity);
                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw new Exception("Ошибка при удалении сущности: " + ex.Message);
                    }
                }
            }
        }

        public T GetByID(int id)
        {
            using (var session = Factory.Session)
            {
                return session.Get<T>(id);
            }
        }

        public IList<T> Get()
        {
            using (var session = Factory.Session)
            {
                return (from e in session.Query<T>() select e).ToList();
            }
        }

        public IList<T> Get(Expression<Func<T, bool>> where)
        {
            using (var session = Factory.Session)
            {
                return session.Query<T>().Where(where).ToList();
            }
        }
    }
}
