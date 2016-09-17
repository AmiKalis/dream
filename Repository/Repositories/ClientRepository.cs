using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using Repository.Entities;

namespace Repository
{
    public class ClientRepository : Repository<Client>
    {
        public List<Client> ReturnForContact(long client)
        {
            using (var session = Factory.Session)
            {
                return (from e in session.Query<Client>() where e.ID == client select e).ToList();
            }
        }

    }
}
