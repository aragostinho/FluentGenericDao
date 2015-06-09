using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

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
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
      
            _ISessionFactory = Fluently.Configure()
                .Database(MySQLConfiguration.Standard.ConnectionString(connectionString))
                .Mappings(x => x.FluentMappings.AddFromAssembly(pAssembly))
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true))
                .BuildSessionFactory();

            return _ISessionFactory;
        }

    }
}
