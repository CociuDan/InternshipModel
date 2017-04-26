using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.ID);
            HasMany(x => x.Orders)
                .KeyColumn("ID")
                .Cascade.AllDeleteOrphan()
                .LazyLoad();
            Map(x => x.DateCreated).Not.Nullable();
            Map(x => x.DateDeactivated).Nullable();
            Map(x => x.IsActive).Not.Nullable();
            Map(x => x.IsAdmin).Not.Nullable();
            Map(x => x.LastLoginDate).Nullable();
            Map(x => x.Login).Not.Nullable();
        }
    }
}