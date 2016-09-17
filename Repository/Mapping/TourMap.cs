using FluentNHibernate.Mapping;
using Repository.Entities;

namespace Repository.Mapping
{
    public class TourMap : ClassMap<Tour>
    {
        public TourMap()
        {
            Table("tour");
            Id(c => c.ID, "id_tour").GeneratedBy.Sequence("tour_id_tour_seq");

            Map(c => c.Direction, "direction");
            Map(c => c.Excursion, "excursion");
            Map(c => c.Transfer, "transfer");
            Map(c => c.Food, "food");

            References(c => c.Hotel, "id_hotel").Not.LazyLoad();
        }
    }
}
