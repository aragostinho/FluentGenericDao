using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentGenericDao.Domain.Entities;

namespace FluentGenericDao.Business.Interfaces
{
    public interface IBResponsible<T> : IGenericDao<T>
    {
    }
}
