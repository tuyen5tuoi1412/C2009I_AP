using System;
namespace Interface_Ex
{
    public class Car : IAction
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Car()
        {
        }

        public void Running()
        {
            Console.WriteLine("Car is running");
        }
    }
}


