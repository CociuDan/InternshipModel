using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Domain.Model.Mapping
{
    public class FieldMap : ClassMap<Field>
    {
        public FieldMap()
        {
            Id(x => x.Id);
            Map(x => x.IsDeleted);
            DiscriminateSubClassesOnColumn("FieldType");
        }
    }

    public class IntFieldMap : SubclassMap<PrimitiveField<int>>
    {
        public IntFieldMap()
        {
            DiscriminatorValue("Int32");
        }
    }
    public class StringFieldMap : SubclassMap<PrimitiveField<string>>
    {
        public StringFieldMap()
        {
            DiscriminatorValue("String");
        }
    }
}
