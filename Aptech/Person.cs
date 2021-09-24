using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptech
{
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}" + $"\nAge: {Age}";
        }

        public void Input()
        {
            
            do
            {
                Console.WriteLine("Enter Name: ");
                Name = Console.ReadLine();
            } while (Name.Length == 0);

            do
            {
                Console.WriteLine("Enter Age: ");
                Age = Convert.ToInt32(Console.ReadLine());
            } while (Age <= 0);
        }

       
    }
    
}
