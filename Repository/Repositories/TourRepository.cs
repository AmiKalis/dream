using Repository.Entities;
using NHibernate.Linq;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Repository
{
    public class TourRepository : Repository<Tour>
    {
        public List<Tour> ReturnForContact(long tour)
        {
            using (var session = Factory.Session)
            {
                return (from e in session.Query<Tour>() where e.ID == tour select e).ToList();
            }
        }
    }
}
