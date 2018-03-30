using System;

namespace ConsoleForTypeReflection.ClassicSampleForGetType
{
    public class SampleGetType
    {
        public void GetTypeSample()
        {
            var my = new ClassForGetType();
            Type type;

            // 1.
            type = my.GetType();
            Console.WriteLine("The first way: " + type);

            // 2.
            type = Type.GetType("ConsoleForTypeReflection.ClassicSampleForGetType.ClassForGetType"); 
            Console.WriteLine("The second way: " + type);

            // 3.
            type = typeof(ClassForGetType);
            Console.WriteLine("The fird way: " + type);
        }
    }
}
