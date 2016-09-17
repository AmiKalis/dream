using FluentNHibernate.Mapping;
using Repository.Entities;

namespace Repository.Mapping
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Table("\"order\"");
            Id(c => c.ID, "ID").GeneratedBy.Sequence("order_id_order_seq");

            Map(c => c.DateDeparture, "date_departure");
            Map(c => c.DateArrival, "date_arrival");
            Map(c => c.Cost, "cost");

            References(c => c.Client, "id_client").Not.LazyLoad();
            References(c => c.Touroperator, "id_touroperator").Not.LazyLoad();
            References(c => c.Tour, "id_tour").Not.LazyLoad();

        }
    }
}
