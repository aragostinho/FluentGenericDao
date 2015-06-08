using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentGenericDao.Domain.Entities
{
    public class TaskList
    {

        public virtual int Id { get; set; }
        public virtual Project Project { get; set; }
        public virtual IList<Task> Tasks { get; set; }


    }
}
