using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleForTypeReflection.ClassicSampleForGetType;
using ConsoleForTypeReflection.SampleWithClasses;
using ConsoleForTypeReflection.SampleWithSealed;

namespace ConsoleForTypeReflection
{
    static class Program
    {
        static void Main(string[] args)
        {
            #region first sample

            new SampleGetType().GetTypeSample();

            #endregion

            Console.WriteLine(new string('*', 60));

            #region second sample

            InvestigatedClass investigatedClass = new InvestigatedClass();

            #region show information about class

            InformationClass.ListVariosStats(investigatedClass);
            InformationClass.ListMethods(investigatedClass);
            InformationClass.ListFields(investigatedClass);
            InformationClass.ListProps(investigatedClass);
            InformationClass.ListInterfaces(investigatedClass);
            InformationClass.ListConstructors(investigatedClass);

            #endregion

            Console.WriteLine(new string('-', 60));
            Type type = investigatedClass.GetType();

            MethodInfo methodC = type.GetMethod("MethodC", BindingFlags.Instance | BindingFlags.NonPublic);
            methodC.Invoke(investigatedClass, new object[] { "Hello", " world!" });

            FieldInfo stringType = type.GetField("stringType", BindingFlags.Instance | BindingFlags.NonPublic);
            stringType.SetValue(investigatedClass, "Hello!");

            Console.WriteLine(investigatedClass.MyString);

            #endregion

            Console.WriteLine(new string('*', 60));

            #region fird sample

            var personType = typeof(Person);

            TypeInfo personInfo = personType.GetTypeInfo();

            IEnumerable<PropertyInfo> declaredProperties = personInfo.DeclaredProperties;
            declaredProperties.PrintValues();

            IEnumerable<MethodInfo> declaredMethods = personInfo.DeclaredMethods;
            declaredMethods.PrintValues();

            IEnumerable<EventInfo> declaredEvents = personInfo.DeclaredEvents;
            declaredEvents.PrintValues();

            #endregion

            Console.ReadKey();
        }

        private static void PrintValues(this IEnumerable<MemberInfo> members)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(members.GetType().GetElementType()?.Name);
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
