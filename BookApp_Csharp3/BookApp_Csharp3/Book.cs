using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp_Csharp3
{
    internal class Book
    {
        public string? Code { get;set;  }
        public DateTime InputDate {  get;set; }
        public int Count {  get;set; }
        public double Price {  get;set; }
        public string? Publisher {  get;set; }  
        public virtual void Display()
        {
            Console.WriteLine($"Code: {Code}");
            Console.WriteLine($"InputDate: {InputDate}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Count: {Count}");
            Console.WriteLine($"Publisher: {Publisher}");
        }
        
    }
}
