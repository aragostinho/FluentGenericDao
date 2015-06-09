using FluentGenericDao.Domain.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace FluentGenericDao.Domain.Mappings
{
    public class TaskMap : ClassMap<Task>
    {

        public TaskMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Description).Length(100);
            Map(x => x.IsDone).Default("0");
            References(x => x.Responsible,"ResponsibleId").Nullable();
        }

    }
}
