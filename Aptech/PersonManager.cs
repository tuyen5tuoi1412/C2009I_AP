using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptech
{
    class PersonManager
    {
        private static List<Person> people = new List<Person>();
        public  void Menu()
        {
            Console.WriteLine("1. Input Person ");
            Console.WriteLine("2. Find Person");
            Console.WriteLine("3. Exit");
            while (true)
            {
                Console.WriteLine("Choose: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        SetPerson();
                        break;
                    case 2:
                        FindPerson();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Choose again:");
                        break;
                }
            }
        }
        public static void SetPerson()
        {
            Console.WriteLine("Enter number of people: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i > n; i++)
            {
                Console.WriteLine($"Enter Person {i + 1}");
                Person person = new Person();
                person.Input();
                people.Add(person);
            }
        }
        
        public static void GetPerson()
        {
            Person person = new Person();
            Console.WriteLine(person.ToString());

        }

        public static void FindPerson()
        {
            int index;
            Console.WriteLine("Enter Index: ");
            index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(people.ElementAt(index));
        }

    }
}
