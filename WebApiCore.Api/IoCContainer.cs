using System;
using System.Collections.Generic;

namespace Services 
{
    public static class IoCContainer
    {
        static readonly Dictionary<Type, Type> registeredObjects = new();

        public static dynamic Resolve<TKey>()
        {
            return Activator.CreateInstance(registeredObjects[typeof(TKey)]);
        }

        public static void Register<Tkey, TConcrete>() where TConcrete : Tkey
        {
            registeredObjects[typeof(Tkey)] = typeof(TConcrete);
        }
    }
}
