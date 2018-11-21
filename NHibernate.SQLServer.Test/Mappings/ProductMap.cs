using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate.SQLServer.Test.Entities;

namespace NHibernate.SQLServer.Test.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Price);

            HasManyToMany(x => x.StoresStockedIn)
                .Cascade.All()
                .Inverse()
                .Table("StoreProduct");

            Component(x => x.Location);
        }
    }
}
