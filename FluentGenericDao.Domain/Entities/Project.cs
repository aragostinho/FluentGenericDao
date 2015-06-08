using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentGenericDao.Domain.Entities
{
    public class Project
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public Responsible Responsible { get; set; }
        public IList<TaskList> TaskLists { get; set; }
    }
}
