using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekStore.Domain.Model.Mapping
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.ID);
            Map(x => x.Manufacturer);
            Map(x => x.Model);
        }
    }
}
