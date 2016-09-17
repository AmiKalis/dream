using FluentNHibernate.Mapping;
using Repository.Entities;

namespace Repository.Mapping
{
    public class HotelMap : ClassMap<Hotel>
    {
        public HotelMap()
        {
            Table("hotel");
            Id(c => c.ID, "id_hotel").GeneratedBy.Sequence("hotel_id_hotel_seq");

            Map(c => c.City, "city");
            Map(c => c.Star, "star");
            Map(c => c.Country, "country");
            Map(c => c.Name, "name_hotel");
        }
    }
}
