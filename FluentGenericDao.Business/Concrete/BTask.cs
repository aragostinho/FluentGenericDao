﻿using FluentGenericDao.Business.Interfaces;
using FluentGenericDao.Domain.Entities;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace FluentGenericDao.Business.Concrete
{
    public class BTask : AbstractGenericDao<Task> , IBTask<Task>
    {
        public IEnumerable<Task> ListTaskName(string name)
        {
            ICriteria task = Session.CreateCriteria<Task>();

            if(!String.IsNullOrEmpty(name))
                task.Add(Restrictions.Eq("Description",name));

            return task.List<Task>();
        }


        public IEnumerable<Task> ListTaskResponsible(string responsible)
        {
            ICriteria criteria = Session.CreateCriteria<Task>();
            ICriteria criteriaResponsible = criteria.CreateCriteria("Responsible");
            criteriaResponsible.Add(Restrictions.Eq("Name", responsible));

            return criteria.List<Task>();
        }
    }
}
