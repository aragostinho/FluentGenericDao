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
    public abstract class AbstractGenericDao<T> : IGenericDao<T>
    {

        protected ISession Session
        {
            get
            {
                return FluentNHibernateHelper.SessionFactory(ConfigurationManager.AppSettings["AssemblyMappings"].ToString().GetAssembly()).OpenSession();
            }

        }



        public virtual void Add(T pObject, bool isUsingTransaction = false)
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
                catch(Exception ex)
                {
                    tran.Rollback();
                }

            }

            //try
            //{
            //    if (!isUsingTransaction)
            //        Session.BeginTransaction();

            //    Session.Save(pObject);

            //    if (!isUsingTransaction)
            //        Session.Transaction.Commit();

            //}
            //catch (Exception oException)
            //{

            //    if (!isUsingTransaction)
            //        Session.Transaction.Rollback();

            //    throw oException;
            //}
            //finally
            //{
            //    if (!isUsingTransaction)
            //        Session.Transaction.Commit();
            //}

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


        public virtual T Get(System.Linq.Expressions.Expression pLinqExpression)
        {
            if (Session == null)
                throw new Exception("Não foi possível conectar no banco de dados");

            return Session.Get<T>(pLinqExpression);


        }
         
    }
}
