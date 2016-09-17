using FluentNHibernate.Mapping;

namespace Repository.Entities
{
    public abstract class ClassMapBase<T> : ClassMap<T> where T : EntityBase
    {
        protected ClassMapBase()
        {
            Id(x => x.ID).Not.Nullable().GeneratedBy.GuidComb();
            LazyLoad();
        }
    }
}