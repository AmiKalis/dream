using NHibernate.Linq;
using Repository.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class HotelRepository : Repository<Hotel>
    {
        public List<Hotel> ReturnForContact(long hotel)
        {
            using (var session = Factory.Session)
            {
                return (from e in session.Query<Hotel>() where e.ID == hotel select e).ToList();
            }
        }
    }
}
