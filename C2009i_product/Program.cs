using System;

namespace C2009i_product
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello World!");
            //struct and class in C?

            //example
            Product productA = new Product(
                "iphone12",
                "apple",
                "VietNam",
                new DateTime(2021, 06, 05),
                new DateTime(2021, 06, 01)
            );
            Product productB = new Product(
                "samsung note12",
                "samsung",
                "US",
                new DateTime(2020, 12, 06),
                new DateTime(2019, 12, 06)
            );
            Product productC = productA;//clone object!
            //struct is "assignment", class is "reference"
            //ProductC and ProductA: 2 separated object? Yes.
            productA.name = "iphone X";
            Console.WriteLine($"productA: {productA}");
            Console.WriteLine($"productB: {productB}");
            Console.WriteLine($"productC: {productC}");
            // example of class
            Student studentA = new Student("Nguyen Van A", 18);
            Student studentB = new Student("Nguyen Van B", 19);
            Student studentC = studentA; // reference
            studentA.name = "xxxx";
            Console.WriteLine($"studentA:{studentA}");
            Console.WriteLine($"studentB: {studentB}");
            Console.WriteLine($"studentC: {studentC}");*/
            //testUserClass
            User userA = new User()
            {
                PhoneNumber = "111111111111",
                Email = "user193@gamil.com",
                FullName = "User A",
            };
            User userB = new User()
            {
                PhoneNumber = "22222222222",
                Email = "user219313@gamil.com",
                FullName = "User B",
            };
            userA.Email = "useraaaaaaaaaaa@yahooo.com";
            Console.WriteLine($"email of userA: {userA.Email}");

            Console.WriteLine($"UserA: {userA}");
            Console.WriteLine($"UserB: {userB}");

            userB.DateOfBirth = new DateTime(2002, 12, 06);
            Console.WriteLine($"age of mrB: {userB.Age}");
            Console.WriteLine("*----------------------------------------------*");
            Console.WriteLine("|      1.Input data of product list            |");
            Console.WriteLine("|      2.Sort & display data of product list   |");
            Console.WriteLine("|      3.Export data into file product.dat     |");
            Console.WriteLine("|      4.Exit                                  |");
            Console.WriteLine("*----------------------------------------------*");
            int choice = 0;
            while(true)
            {
                Console.WriteLine("Enter Your Choose: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Chosse is 1");
                        break; 
                    case 2:
                        Console.WriteLine("Chosse is 2");
                        break;
                    case 3:
                        Console.WriteLine("Chosse is 3");
                        break;
                    case 4:
                        Console.WriteLine("End Program");
                        return;
                    default:
                        Console.WriteLine("Please, Enter one to Four");
                        break;
                }
                
            }

        }
         
    }
}

