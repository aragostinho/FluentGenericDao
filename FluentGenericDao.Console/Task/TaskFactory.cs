using FluentGenericDao.TaskConsole.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentGenericDao.TaskConsole.Tasks
{
    public class TaskFactory
    {

        private static AddTask _AddTask;
        public static AddTask AddTask
        {
            get
            {
                return _AddTask ?? (_AddTask = new AddTask());
            }
        }



    }
}
