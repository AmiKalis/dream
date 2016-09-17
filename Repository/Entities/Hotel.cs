using System;

namespace Repository.Entities
{
    public class Hotel: EntityBase
    {
        public virtual string Country { get; set; }
        public virtual string City { get; set; }
        public virtual string Name { get; set; }
        public virtual int Star { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
