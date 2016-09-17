namespace Repository.Entities
{
    public class Tour : EntityBase
    {
        public virtual Hotel Hotel { get; set; }
        public virtual string Direction { get; set; }
        public virtual short Excursion { get; set; }
        public virtual bool Transfer { get; set; }
        public virtual bool Food { get; set; }

        public override string ToString()
        {
            return Direction.ToString();
        }
    }
}
