using System;

namespace LibraryForLoadAssembly
{
    public class SportsCar: Car
    {
        public SportsCar()
        {
        }

        public SportsCar(string name, short maxSpeed, short currentSpeed)
            : base(name, maxSpeed, currentSpeed)
        {
        }

        public override void Acceleration()
        {
            Console.WriteLine("SportsCar: Engine died!");
        }
    }
}
