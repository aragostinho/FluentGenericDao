using FluentGenericDao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
  

namespace FluentGenericDao.Business.Interfaces
{
    public interface IBTask<T> : IGenericDao<T>
    {
        IEnumerable<Task> ListTaskName(string name);

        IEnumerable<Task> ListTaskResponsible(string responsible);
    }
}
