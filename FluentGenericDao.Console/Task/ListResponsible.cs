using FluentGenericDao.Business;
using FluentGenericDao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentGenericDao.TaskConsole.Task
{
    public class ListResponsible : AbstractInterpreter
    {
        public override void Execute(string[] args)
        {
            IEnumerable<Responsible> responsible = BusinessFactory.Responsible.Get(x => x.Id < 10);
            foreach (var item in responsible)
            {
                Console.WriteLine("Responsible Name:{0}", item.Name);
            }
        }

        public override string Description()
        {
            return "List responsible with criteria";
        }
    }
}
