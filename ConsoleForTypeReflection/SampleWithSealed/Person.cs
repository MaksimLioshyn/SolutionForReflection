using System;

namespace ConsoleForTypeReflection.SampleWithSealed
{
    public sealed class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public event EventHandler Modified;

        private void OnModified()
        {
            var handler = Modified;
            handler?.Invoke(this, EventArgs.Empty);
        }

        public void Save()
        {
        }
    }
}
