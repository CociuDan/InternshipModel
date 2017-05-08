using FluentNHibernate.Mapping;

namespace GeekStore.Domain.Model.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.ID);
            Map(x => x.Email).Not.Nullable();
            Map(x => x.FullName).Not.Nullable();
            Map(x => x.IsActive).Not.Nullable();
            Map(x => x.IsAdmin).Not.Nullable();
        }
    }
}