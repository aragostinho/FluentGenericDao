using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentGenericDao.Repository;
using System.Configuration;

namespace FluentGenericDao.Business
{
    public abstract class AbstractGenericDao<T> : IGenericDao<T> where T : class
    {

        protected ISession Session
        {
            get
            {
                return FluentNHibernateHelper.SessionFactory(ConfigurationManager.AppSettings["AssemblyMappings"].ToString().GetAssembly()).OpenSession();
            }

        }



        public virtual void Add(T pObject)
        {
            if (Session == null)
                throw new Exception("Não foi possível conectar no banco de dados");

            using (ITransaction tran = Session.BeginTransaction())
            {
                try
                {
                    Session.Save(pObject);
                    tran.Commit();
                }
                catch(Exception)
                {
                    tran.Rollback();
                }

            }

        

        }


        public virtual void Update(T pObject, bool isUsingTransaction = false)
        {
            if (Session == null)
                throw new Exception("Não foi possível conectar no banco de dados");

            try
            {
                if (!isUsingTransaction)
                    Session.BeginTransaction();

                Session.Update(pObject);

                if (!isUsingTransaction)
                    Session.Transaction.Commit();

            }
            catch (Exception oException)
            {

                if (!isUsingTransaction)
                    Session.Transaction.Rollback();

                throw oException;
            }
            finally
            {
                if (!isUsingTransaction)
                    Session.Transaction.Commit();
            }


        }
        public virtual void Delete(T pObject, bool isUsingTransaction = false)
        {

            if (Session == null)
                throw new Exception("Não foi possível conectar no banco de dados");

            try
            {
                if (!isUsingTransaction)
                    Session.BeginTransaction();

                Session.Delete(pObject);

                if (!isUsingTransaction)
                    Session.Transaction.Commit();

            }
            catch (Exception oException)
            {

                if (!isUsingTransaction)
                    Session.Transaction.Rollback();

                throw oException;
            }
            finally
            {
                if (!isUsingTransaction)
                    Session.Transaction.Commit();
            }

        }


        public virtual IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> pLinqExpression)
        {
            if (Session == null)
                throw new Exception("Não foi possível conectar no banco de dados");

            return Session.QueryOver<T>().Where(pLinqExpression).List<T>();
        }
         
    }
}
