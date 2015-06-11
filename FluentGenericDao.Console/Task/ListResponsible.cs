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
            IEnumerable<Responsible> responsible = BusinessFactory.Responsible.Get(x => x.Id != 0);
            foreach (var item in responsible)
            {
                Console.WriteLine("============================================");
                Console.WriteLine("Responsible Name:{0}", item.Name);

                Console.Write("Task");
                foreach (var task in item.Task)
                {
                    Console.Write("Task Descrition: {0}", task.Description);
                }

                Console.WriteLine("=============================================");
            }
        }

        public override string Description()
        {
            return "List responsible";
        }
    }
}
