namespace Repository.Entities
{
    public class Touroperator: EntityBase
    {
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual int Phone { get; set; }
        public virtual string Email { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
