using System;
using System.IO;
using System.Reflection;
using LibraryForLoadAssembly;

namespace ConsoleForlateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            LateBindingObject();
            LateBindingInterface();
            LateBindingDynamic();
            Console.ReadKey();
        }

        static void LateBindingObject()
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("LibraryForLoadAssembly");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Type type = assembly?.GetType("LibraryForLoadAssembly.MiniVan");
            object instance = Activator.CreateInstance(type ?? throw new InvalidOperationException());

            MethodInfo method = type.GetMethod("Acceleration");

            method?.Invoke(instance, null);
            method = type.GetMethod("Driver");

            object[] parameters = { "Shumaher", 36 };
            method?.Invoke(instance, parameters);
        }

        static void LateBindingInterface()
        {
            try
            {
                Assembly assembly = Assembly.Load("LibraryForLoadAssembly");
                Type type = assembly.GetType("LibraryForLoadAssembly.MiniVan");

                if (Activator.CreateInstance(type) is ICar carInstance)
                {
                    carInstance.Acceleration();
                    carInstance.Driver("Shumaher", 26);
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void LateBindingDynamic()
        {
            try
            {
                Assembly assembly = Assembly.Load("LibraryForLoadAssembly");
                Type type = assembly.GetType("LibraryForLoadAssembly.MiniVan");

                dynamic carInstance = Activator.CreateInstance(type);
                carInstance.Acceleration();
                carInstance.Driver("Shumaher", 16);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
