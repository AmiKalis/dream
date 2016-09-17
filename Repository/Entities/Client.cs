using System;

namespace Repository.Entities
{
    public class Client : EntityBase
    {
        public virtual string Fio { get; set; }
        public virtual string Address { get; set; }
        public virtual long Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual bool Children { get; set; }
        public virtual bool Animal { get; set; }

        public override string ToString()
        {
            return Fio.ToString();
        }
    }

}
