using System;
using System.IO;
using System.Reflection;

// Must have: copy LibraryForLoadAssembly.dll from LibraryForLoadAssembly.

namespace ConsoleForLoadAssembly
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;

            try
            {
                
                assembly = Assembly.Load("LibraryForLoadAssembly");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            ListAllTypes(assembly);
            ListAllMembers(assembly);
            GetParams(assembly);

            Console.ReadKey();
        }

        private static void ListAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));
            Console.WriteLine($"\nType in: {assembly.FullName} \n");

            Type[] types = assembly.GetTypes();

            foreach (Type t in types)
            {
                Console.WriteLine($"Type: {t}");
            }
                
        }

        private static void ListAllMembers(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));
            Type type = assembly.GetType("LibraryForLoadAssembly.MiniVan");
            Console.WriteLine($"\nMembers of class: {type} \n");

            MemberInfo[] members = type.GetMembers();

            foreach (MemberInfo element in members)
            {
                Console.WriteLine($"{element.MemberType,-15}: {element}");
            }
        }

        private static void GetParams(Assembly assembly)
        {
            Console.WriteLine(new string('_', 80));

            Type type = assembly.GetType("LibraryForLoadAssembly.MiniVan");
            MethodInfo method = type.GetMethod("Driver"); // Equals , Acceleration, Driver

            Console.WriteLine($"\nInformation about the parameters for the method {method?.Name}");
            ParameterInfo[] parameters = method?.GetParameters();
            Console.WriteLine($"The method has {parameters?.Length} parameters");

            foreach (ParameterInfo parameter in parameters)
            {
                Console.WriteLine($"Parameter name: {parameter.Name}");
                Console.WriteLine($"Position in the method: {parameter.Position}");
                Console.WriteLine($"Parameter Type: {parameter.ParameterType}");
            }

        }
    }
}
