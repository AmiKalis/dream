using FluentNHibernate.Mapping;
using Repository.Entities;

namespace Repository.Mapping
{
    public class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            Table("client");
            Id(c => c.ID, "id_client").GeneratedBy.Sequence("client_id_client_seq");
            
            Map(c => c.Fio, "fio");
            Map(c => c.Address, "address");
            Map(c => c.Phone, "phone");
            Map(c => c.Email, "email");
            Map(c => c.DateOfBirth, "date_of_birth");
            Map(c => c.Children, "children");
            Map(c => c.Animal, "animal");
        }
    }
}
