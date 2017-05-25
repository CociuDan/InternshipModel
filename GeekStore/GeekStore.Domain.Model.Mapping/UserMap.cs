using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.UserName).Unique().Not.Nullable();
            Map(x => x.FullName).Not.Nullable();
            Map(x => x.IsAdmin).Not.Nullable();
            Map(x => x.Password).Not.Nullable();
        }
    }
}