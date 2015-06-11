using FluentGenericDao.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentGenericDao.TaskConsole.Task
{
    public class SeekResponsibleOfTask : AbstractInterpreter
    {
        public override void Execute(string[] args)
        {
            Console.Write("Enter the responsible.");
            string responsible = Console.ReadLine();

            var list = BusinessFactory.Task.ListTaskResponsible(responsible);

            if (list.Count() < 1)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("It was not found to search results!");
                Console.WriteLine("=========================================");
            }

            foreach (var item in list)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("Task Description: {0}, Responsible name: {1}", item.Description, item.Responsible.Name);
                Console.WriteLine("=========================================");
            }

        }

        public override string Description()
        {
            return "seek responsible of tasks";
        }
    }
}
