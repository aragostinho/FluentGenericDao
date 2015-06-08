﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentGenericDao.Business
{
    public interface IGenericDao<T>
    {

        void Add(T pObject, bool isUsingTransaction=false);
        void Update(T pObject, bool isUsingTransaction=false);
        void Delete(T pObject, bool isUsingTransaction=false);
        T Get(System.Linq.Expressions.Expression pLinqExpression);
 
    }
}
