﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Soporte.Infraestructure
{
    public static class CompositionRoot
    {
        private static IContainer _container;

        public static void SetContainer(IContainer container)
        {
            _container = container;
        }

        internal static ILifetimeScope BeginLifetimeScope()
        {
            return _container.BeginLifetimeScope();
        }
    }
}
