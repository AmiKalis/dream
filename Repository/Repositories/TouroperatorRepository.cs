using Repository.Entities;
using NHibernate.Linq;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class TouroperatorRepository : Repository<Touroperator>
    {
        public List<Touroperator> ReturnForContact(long touroperator)
        {
            using (var session = Factory.Session)
            {
                return (from e in session.Query<Touroperator>() where e.ID == touroperator select e).ToList();
            }
        }
    }
}
