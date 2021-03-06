﻿using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg.Db;

namespace FluentGenericDao.Repository
{
    public static class FluentNHibernateHelper
    {

        private static ISessionFactory _ISessionFactory;
        public static ISessionFactory SessionFactory(System.Reflection.Assembly pAssembly)
        {
            if (_ISessionFactory == null)
            {
                _ISessionFactory = InitializeSessionFactory(pAssembly);
            }

            return _ISessionFactory;
        }      

        private static ISessionFactory InitializeSessionFactory(System.Reflection.Assembly pAssembly)
        {

            _ISessionFactory = Fluently.Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString(ConfigurationManager.AppSettings["MySqlConnectionString"]))
                .Mappings(x => x.FluentMappings.AddFromAssembly(pAssembly))
                .BuildSessionFactory();

            return _ISessionFactory;
        }





    }
}
