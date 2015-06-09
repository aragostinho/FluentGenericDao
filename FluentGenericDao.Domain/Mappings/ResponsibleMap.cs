using FluentGenericDao.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentGenericDao.Domain.Mappings
{
    public class ResponsibleMap : ClassMap<Responsible>
    {
        public ResponsibleMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x=> x.Name);
            HasMany(x => x.Task).KeyColumn("ResponsibleId").Inverse().Cascade.All();
        }
    }
}
