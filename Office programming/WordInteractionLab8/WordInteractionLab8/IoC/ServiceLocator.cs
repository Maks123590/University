namespace WordInteractionLab8.IoC
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public static class ServiceLocator
    {
        private static Dictionary<Type, object> ServicesDictionary = new Dictionary<Type, object>();

        public static T GetService<T>()
        {
            return (T)ServiceLocator.ServicesDictionary[typeof(T)];
        }

        public static void Register<T>(T service)
        {
            ServiceLocator.ServicesDictionary[typeof(T)] = service;
        }

        public static void Reset()
        {
            ServiceLocator.ServicesDictionary.Clear();
        }
    }
}