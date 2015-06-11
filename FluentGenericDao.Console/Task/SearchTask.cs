using FluentGenericDao.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentGenericDao.TaskConsole.Task
{
    public class SearchTask : AbstractInterpreter
    {
        public override void Execute(string[] args)
        {
            Console.WriteLine("enter the task name or empty to search all. (Criteria)");
            string name = Console.ReadLine();

            var list = BusinessFactory.Task.ListTaskName(name);

            if (list.Count() < 1)
            {
                Console.WriteLine("==========================================================");

                Console.WriteLine("It was not found to search results!");

                Console.WriteLine("==========================================================");
            }

            foreach (var item in list.ToList())
	        {
                Console.WriteLine("==========================================================");

		        Console.WriteLine("Task Id: {0}, Task Name: {1}", item.Id, item.Description);

                Console.WriteLine("==========================================================");
	        }
        }

        public override string Description()
        {
            return "Search Task";
        }
    }
}
