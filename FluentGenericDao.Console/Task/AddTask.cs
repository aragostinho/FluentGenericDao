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

            try
            {
                FluentGenericDao.Domain.Entities.Task oTask = new FluentGenericDao.Domain.Entities.Task();
                oTask.Id = 1;
                oTask.Responsible = new Responsible() { Name = "Carlos Augusto" };
                BusinessFactory.Task.Add(oTask);
            
            }
            catch (Exception)
            {
                
                throw;
            }   
            
            
        }
    }
}
