using System;
using System.Reflection;

namespace ConsoleForTypeReflection.SampleWithClasses
{
    public class InformationClass
    {
        public static void ListVariosStats(InvestigatedClass investigatedClass)
        {
            Console.WriteLine(new string('_', 30) + "Information about" + "\n");
            Type t = investigatedClass.GetType();

            Console.WriteLine("Full Name: {0}", t.FullName);
            Console.WriteLine("Base class: {0}", t.BaseType);
            Console.WriteLine("Abstract: {0}", t.IsAbstract);
            Console.WriteLine("then COM object: {0}", t.IsCOMObject);
            Console.WriteLine("Inherited inheritance: {0}", t.IsSealed);
            Console.WriteLine("that class: {0}", t.IsClass);
        }

        public static void ListMethods(InvestigatedClass investigatedClass)
        {
            Console.WriteLine(new string('_', 30) + " Class Methods" + "\n");

            Type t = investigatedClass.GetType();
            MethodInfo[] mi = t.GetMethods(BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

            foreach (MethodInfo m in mi)
                Console.WriteLine("Method: {0}", m.Name);
        }


        public static void ListFields(InvestigatedClass investigatedClass)
        {
            Console.WriteLine(new string('_', 30) + " Fields" + "\n");

            Type t = investigatedClass.GetType();
            FieldInfo[] fi =
                t.GetFields(BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic);

            foreach (FieldInfo f in fi)
                Console.WriteLine("Field: {0}", f.Name);
        }

        public static void ListProps(InvestigatedClass investigatedClass)
        {
            Console.WriteLine(new string('_', 30) + "Properties" + "\n");

            Type t = investigatedClass.GetType();
            PropertyInfo[] pi = t.GetProperties();

            foreach (PropertyInfo p in pi)
                Console.WriteLine("Property: {0}", p.Name);
        }

        public static void ListInterfaces(InvestigatedClass investigatedClass)
        {
            Console.WriteLine(new string('_', 30) + " Inteference" + "\n");

            Type t = investigatedClass.GetType();

            Type[] it = t.GetInterfaces();

            foreach (Type i in it)
                Console.WriteLine("Inteference: {0}", i.Name);
        }

        public static void ListConstructors(InvestigatedClass investigatedClass)
        {
            Console.WriteLine(new string('_', 30) + "Constructors" + "\n");

            Type t = investigatedClass.GetType();
            ConstructorInfo[] ci = t.GetConstructors();

            foreach (ConstructorInfo m in ci)
                Console.WriteLine("Constructor: {0}", m.Name);
        }
    }
}
