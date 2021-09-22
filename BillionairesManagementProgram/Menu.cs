using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillionairesManagementProgram
{
    public class Menu : IMenu
    {
        Models.Person NewPerson = new Models.Person();
       

        public void Analyze()
        {
            NewPerson.Analyze();
        }

        public void Find()
        {
            NewPerson.Find();
        }

        public void Input()
        {

           
            NewPerson.Input();
        }

        public void Open()
        {
            NewPerson.Open();
        }

        public void Save()
        {
            NewPerson.Save();   
        }

        public void Sort()
        {
            NewPerson.SortPersonByAge();
           

        }
        public void ShowMenu()
        {
            Menu MN = new Menu();
            string choice = "";
            while (choice != "7")
            {
                Console.WriteLine("+-------------------------------------------------------------------+");
                Console.WriteLine("|            BILLIONAIRES PROFILE MANAGEMENT PROGRAM                |");
                Console.WriteLine("+ ------------------------------------------------------------------+");
                Console.WriteLine("| 1.Input | 2.Sort | 3.Analyze | 4.Find | 5.Save | 6.Open | 7.Exit  |");
                Console.WriteLine("+ ------------------------------------------------------------------+");
                Console.WriteLine("Enter your choice : ");
                choice = (Console.ReadLine() ?? "").Trim();
                Console.WriteLine($"Your choice: {choice}");
                if (choice.Equals("1"))
                {
                    MN.Input();

                }
                else if(choice.Equals("2"))
                {
                    HeaderResult();
                    MN.Sort();
                   

                }
                else if(choice.Equals("3"))
                {
                    MN.Analyze();

                }
                else if(choice.Equals("4"))
                {
                    HeaderResult();
                    MN.Find();

                }
                else if(choice.Equals("5"))
                {
                    MN.Save();

                }
                else if(choice.Equals("6"))
                {

                    MN.Open();
                }
                else if(choice.Equals("7"))
                {
                    
                    return;
                }

                Console.WriteLine("Do you want to continue ?");
                Console.WriteLine("- Yes, I do. (press ‘y’, ‘Y’)");
                Console.WriteLine("- No, I don’t. (press ‘n’, ‘N’)");
                Console.WriteLine("- Please clear the screen!(press ‘c’, ‘C’)");
                Console.WriteLine("Your choice:");
                choice = (Console.ReadLine() ?? "").Trim();
                /*
                if (choice.ToLower().Equals("n"))
                {
                    choice = "7"; 
                }
                */
                choice = choice.ToLower().Equals("n") ? "7" : choice;
                if (choice.ToLower().Equals("c"))
                {

                     Console.Clear();
                     
                }
                       

             }
        }
        public void HeaderResult()
        {
            Console.WriteLine("+--------------------------------------------------------------------+ ");
            Console.WriteLine("| Person Name    | Nationality   | Birth Year | Net Worth(billion $) |");
            Console.WriteLine("+--------------------------------------------------------------------+");
        }
     }
 }

