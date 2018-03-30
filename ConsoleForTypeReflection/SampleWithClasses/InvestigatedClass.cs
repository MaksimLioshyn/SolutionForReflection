using System;

namespace ConsoleForTypeReflection.SampleWithClasses
{
    public class InvestigatedClass : IInterfaceA, IInterfaceB
    {
        public string MyString => stringType;

        public int IntType;
        private string stringType = "Hello";

        public InvestigatedClass() { }
        public InvestigatedClass(int i)
        {
            IntType = i;
        }

        public int propType
        {
            get => IntType;
            set => IntType = value;
        }

        public void MethodA() { }
        public void MethodB() { }

        private void MethodC(string str, string str2)
        {
            Console.WriteLine(str + str2);
        }
        public void CustomMethod(int p1, string p2) { }
    }
}
