using System;

namespace Repository.Entities
{
    public class Order : EntityBase
    {
        public virtual Client Client { get; set; }
        public virtual Touroperator Touroperator { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual DateTime DateDeparture { get; set; }
        public virtual DateTime DateArrival { get; set; }
        public virtual int Cost { get; set; }
    }
}
