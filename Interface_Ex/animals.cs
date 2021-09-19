using System;
namespace Interface_Ex
{
    public abstract class Animal : IAction
    {
        public string Name { get; set; }
        public string FoodType { get; set; }
        public int Age { get; set; }

        public Animal()
        {
        }

        public void Running()
        {
            Console.WriteLine("Animal is running");
        }

        public void Sleeping()
        {
            Console.WriteLine("Animal is sleeping");
        }

        public abstract void ShowSound();
    }
}

