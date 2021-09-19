using System;
using System.Collections.Generic;

namespace Interface_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ShowSound();

            Animal animal = new Dog();//tinh chat da hinh
            //Khi khai kieu du lieu tu class parent => khoi tao doi tuong tu class parent hoac class child
            animal.ShowSound();

            //Tao 1 mang => quan ly danh sach dong vat
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Cat());
            animals.Add(new Cat());
            animals.Add(new Dog());

            foreach (Animal a in animals)
            {
                a.ShowSound();
            }

            //Interface
            List<IAction> actions = new List<IAction>();
            actions.Add(new Dog());
            actions.Add(new Cat());
            actions.Add(new Dog());
            actions.Add(new People());
            actions.Add(new Car());

            foreach (Animal o in animals)
            {
                o.ShowSound();
            }
        }

        static void testRunning()
        {
            Car c = new Car();
            c.Running();
        }
    }
}
