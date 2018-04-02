using System;

namespace LibraryForLoadAssembly
{
    public abstract class Car
    {
        protected string nameOfDriver;
        protected short currentSpeed;
        protected short maxSpeed;
        protected EngineState state;

        public string NameOfDriver
        {
            get { return nameOfDriver; }
            set { nameOfDriver = value; }
        }

        public short CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        public short MaxSpeed { get; }

        public EngineState EngineState { get; }


        protected Car()
        {
            state = EngineState.EngineAlive;
        }

        protected Car(string nameOfDriver, short maxSpeed, short currentSpeed)
            : this()
        {
            this.nameOfDriver = nameOfDriver;
            this.maxSpeed = maxSpeed;
            this.currentSpeed = currentSpeed;
        }


        public abstract void Acceleration();

        public void Driver(string name, int age)
        {
            Console.WriteLine("Name of driver: {0}. Age: {1}", name, age);
        }

    }
}
