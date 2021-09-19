using System;
using System.Collections.Generic;

namespace C2009i_New_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> PrList = new List<Product>();
            Console.WriteLine("*----------------------------------------------*");
            Console.WriteLine("|      1.Input data of product list            |");
            Console.WriteLine("|      2.Sort & display data of product list   |");
            Console.WriteLine("|      3.Export data into file product.dat     |");
            Console.WriteLine("|      4.Exit                                  |");
            Console.WriteLine("*----------------------------------------------*");
            int choice = 0;
            int n;
            do
            {

                Console.WriteLine("Please, enter your choose: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a Number Product: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n <= 0)
                        {
                            Console.WriteLine("Please,number product must > 0! Program Reaseted...");
                            
                        }
                        for (int i = 0; i < n; i++)
                        {
                            Product product = new Product();
                            product.Input();
                            PrList.Add(product);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Welcome to the Product Information");
                        for (int i = 0; i < PrList.Count; i++)
                        {
                            Console.WriteLine($"Product{0}", i + 1);
                            PrList[i].Display();
                        }

                        break;
                    case 3:
                        //luu filed CSV
                        break;
                    case 4:
                        Console.WriteLine("End Program");
                        return;
                    default:
                        Console.WriteLine("Please, Enter one to Four");
                        break;
                }
            } while (choice != 4);
            }
        }
    }

