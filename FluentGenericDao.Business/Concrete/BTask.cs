using FluentGenericDao.Business.Interfaces;
using FluentGenericDao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace FluentGenericDao.Business.Concrete
{
    public class BTask : AbstractGenericDao<Task> , IBTask<Task>
    {
    }
}
