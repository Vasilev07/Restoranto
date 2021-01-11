﻿using Autofac;
using Autofac.Integration.Mvc;
using System;
using Resturanto.Services;
using System.Web.Mvc;

namespace Resturanto.App_Start
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlRestaurantData>()
                .As<IRestaurantData>()
                .InstancePerRequest();
            builder.RegisterType<TableData>()
                .As<ITables>()
                .InstancePerRequest();

            builder.RegisterType<Restoranto>().InstancePerRequest();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}