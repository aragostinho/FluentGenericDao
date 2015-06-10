using FluentGenericDao.Business;
using FluentGenericDao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentGenericDao.TaskConsole.Task
{
    public class AddTask: AbstractInterpreter
    {
        public override string Description()
        {
            return "Add a new task";
        }
        public override void Execute(string[] args)
        {
            Console.WriteLine("Enter responsible name.");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the task description.");
            string description = Console.ReadLine();


            try
            {
                FluentGenericDao.Domain.Entities.Responsible Responsible = new Domain.Entities.Responsible() { Name = name };
                BusinessFactory.Responsible.Add(Responsible);

                FluentGenericDao.Domain.Entities.Task oTask = new FluentGenericDao.Domain.Entities.Task();
                oTask.Description = description;
                oTask.Responsible = Responsible;
                BusinessFactory.Task.Add(oTask);
            
            }
            catch (Exception)
            {             
                throw;
            }   
            
            
        }
    }
}
