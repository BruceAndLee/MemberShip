﻿using Autofac;

namespace MemberShipManage.Framework.DependencyManage
{
    public class DependencyRegister : IDependencyRegister
    {
        public virtual void Register(ContainerBuilder builder)
        {
            //builder.RegisterType<DatabaseFactory>().As<IDataBaseFactory>().InstancePerLifetimeScope();
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().WithParameter("connectionString", ConfigurationManager.ConnectionStrings["DBConnString"].ConnectionString).InstancePerLifetimeScope();
            #region Repository

            //builder.RegisterType<ArticleRepository>().As<IArticleRepository>().InstancePerLifetimeScope();
           
            #endregion

            #region Service

            //builder.RegisterType<ArticleService>().As<IArticleService>().InstancePerLifetimeScope();
            
            #endregion
        }

        public int Order
        {
            get { return 2; }
        }
    }
}