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

        private static ListResponsible _listResponsible;
        public static ListResponsible ListResponsible
        {
            get
            {
                return _listResponsible ?? new ListResponsible();
            }
        }

        private static SearchTask _searchTask;
        public static SearchTask SearchTask
        {
            get
            {
                return _searchTask ?? new SearchTask();
            }
        }

    }
}
