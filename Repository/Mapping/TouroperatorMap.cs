using FluentNHibernate.Mapping;
using Repository.Entities;

namespace Repository.Mapping
{
    public class TouroperatorMap : ClassMap<Touroperator>
    {
        public TouroperatorMap()
        {
            Table("touroperator");
            Id(c => c.ID, "id_touroperator").GeneratedBy.Sequence("touroperator_id_touroperator_seq");

            Map(c => c.Name, "name_touroperator");
            Map(c => c.Address, "address_touroperator");
            Map(c => c.Phone, "phone_touroperator");
            Map(c => c.Email, "email_touroperator");
        }
    }
}
