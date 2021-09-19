using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace C2009i_New_Product
{
    public class Product


   
    {
        public String Name { get; set; }
        public String Brand { get; set; }
        public String Madein { get; set; }
        public int Price { get; set; }
        public DateTime ImportedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public object PrList { get; private set; }

        public Product() { }
        public Product(String Name, String Brand, String Madein, int Price, DateTime ImportedDate, DateTime ExpiredDate)
        {
            this.Name = Name;
            this.Brand = Brand;
            this.Madein = Madein;
            this.ImportedDate = ImportedDate;
            this.ExpiredDate = ExpiredDate;
        }
        public void Input()
        {
            Console.WriteLine("Enter Name Product: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Brand Product: ");
            Brand = Console.ReadLine();
            Console.WriteLine("Enter MadeIn Product: ");
            Madein = Console.ReadLine();
            Console.WriteLine("Enter Price Product: ");
            Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ImportedDate Product: ");
            ImportedDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter ExpiredDate Product: ");
            ExpiredDate = Convert.ToDateTime(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("|Name      |Brand       |Made In      |Price       |ImportedDate       |ExpiredDate            |");
            Console.WriteLine($"|{this.Name}|{this.Brand}|{this.Madein}|{this.Price}|{this.ImportedDate}|{this.ExpiredDate}|");
            Console.WriteLine("------------------------------------------------------------------------------------------------=");
        }  
        public void ExportToCSV()
        {
            Console.WriteLine("enter your file Name: ");
            String fileName;
            
        }
        

    }






 }



