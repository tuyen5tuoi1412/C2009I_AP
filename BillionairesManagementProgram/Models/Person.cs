using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillionairesManagementProgram.Models
{
     class Person :IPerson
    {
       
        String fileName;
        List<Person> people = new List<Person>();
        List<object> LO = new List<object>();
        public string Name { get; set; }
        public string Nationality { get; set; }
        public int BirthYear { get; set; }
        public double NetWorth { get; set; }
        string name;
        string nation;
        int birthyear;
        float networth;

        public void Display()
        {         
           
            Console.WriteLine($"|    {Name}        | {Nationality}            | {BirthYear}       | {NetWorth}                   |");
            Console.WriteLine("+ -------------------------------------------------------------------+");
           
        }

        public void Input()
        {
            
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine()?.Trim() ?? "";
            Console.WriteLine("Enter Nationality: ");
            nation = Console.ReadLine().Trim() ?? "";
            do
            {


                Console.WriteLine("Enter BirthYear: ");
                birthyear = Convert.ToInt32(Console.ReadLine());
                if (DateTime.Now.Year - birthyear <= 30)
                {

                    Console.WriteLine("Person age must be greater than 30 in the current year");

                }
            } while (DateTime.Now.Year - birthyear <= 30);



            do
            {
                Console.WriteLine("Enter NetWorth: ");
                networth = (float)Convert.ToDouble(Console.ReadLine());
                if (networth < 1 || networth > 100)
                {
                    Console.WriteLine("Networth must be between 1(billion $) and 100(billion $).");
                }
            } while (networth < 1 || networth > 100);
            Person person = new Person()
            {
                Name = name,
                Nationality = nation,
                BirthYear = birthyear,
                NetWorth = networth
            };
            people.Add(person);
        }

        

        public void SortPersonByAge()
        {
            var PersonListSort = people.OrderBy(P => P.BirthYear);
            foreach(Person P in PersonListSort)
            {
                P.Display();
            }
        }

        public void Analyze()
        {
            var result = from p in people // Những người có trong people

                         group p by p.Nationality into gr // nhóm thành gr theo quốc tịch

                         let count = gr.Count() // Số phần tử trong nhóm
                         select new                  // trả về quốc tịch và số người có quốc tịch đó

                         {
                             nation = gr.Key, 
                             number = count
                         };
            Console.WriteLine("Statistics Result: ");
            foreach (var item in result)
            {
                Console.WriteLine($"+ There are {item.number} person(s) form \'{item.nation}\'.");
            }
            
            
        }

        public void Find()
        {
            string nation = "";
            float networth = 0;
            do
            {
                Console.WriteLine("Nationality: ");
                nation = Console.ReadLine().Trim();

            } while (nation.Length == 0);
            do
            {
                Console.WriteLine("Networth: ");
                networth = (float)Convert.ToDouble(Console.ReadLine());
                if (networth < 1 || networth > 100)
                {
                    Console.WriteLine("Networth must be between 1(billion $) and 100(billion $).");
                }
            } while (networth < 1 || networth > 100);
            var result = from p in people
                         where nation == p.Nationality
                         where p.NetWorth > networth
                         orderby p.NetWorth descending
                         select p;
            Console.WriteLine();
            Console.WriteLine("Search Result: ");
            Menu menu = new Menu();
            menu.HeaderResult();
            foreach(var item in result)
            {
                Console.WriteLine(item.ToString());
                
            }
            Console.WriteLine($"{result.Count()} persons found.");
        }
        public void Save()
        {
            StreamWriter writer = null;
            Console.WriteLine("Save the list into file:");
            do
            {
                Console.Write("File name: ");
                fileName = Console.ReadLine().Trim();
            } while (fileName.Length == 0);
            try
            {
                writer = new StreamWriter(fileName.Contains(".csv") ? fileName : $"{fileName}.csv");
                foreach (Models.Person p in people)
                {
                    writer.WriteLine($"{p.Name},{p.Nationality},{p.BirthYear},{p.NetWorth}");
                }
                Console.WriteLine("Data successfully saved into file!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Can not write to file {fileName}: {e.Message}");
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public void Open()
        {
            StreamReader reader = null;
            Console.WriteLine("Open file and display the list:");
            do
            {
                Console.Write("File name: ");
                fileName = Console.ReadLine().Trim();
            } while (fileName.Length == 0);
            try
            {
                reader = new StreamReader(fileName.Contains(".csv") ? fileName : $"{fileName}.csv");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(",");
                    people.Add(new Person() { Name = arr[0], Nationality = arr[1], BirthYear = Convert.ToInt32(arr[2]), NetWorth = (float)Convert.ToDouble(arr[3]) });
                }
                Menu menu = new Menu();
                menu.HeaderResult();
                foreach (Person p in people)
                {
                    Console.WriteLine(p.ToString());
                    Console.WriteLine("+------------------------------------------------------------------+");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Can not read file {fileName}: {e.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        
    }
}
