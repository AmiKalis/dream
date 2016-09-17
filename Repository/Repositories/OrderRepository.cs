//using NHibernate.Criterion;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using Repository.Entities;

namespace Repository
{
    public class OrderRepository : Repository<Order>
    {
        public List<Order> ReturnForContact(long order)
        {
            using (var session = Factory.Session)
            {
                return (from e in session.Query<Order>() where e.ID == order select e).ToList();
            }
        }
    }
}
