using FluentGenericDao.Business.Concrete;
using FluentGenericDao.Business.Interfaces;
using FluentGenericDao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace FluentGenericDao.Business
{
    public static class BusinessFactory
    {
        private static IBTask<Task> _IBTask;
        public static IBTask<Task> Task { get {

            if (_IBTask == null)
                _IBTask = new BTask();

            return _IBTask;
        } }


    }
}
