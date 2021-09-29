using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp_Csharp3
{
    internal class ReferenceBook : Book
    {
        public double Tax { get;set;  }

        public double TotalPrice
        {
            get => Count * Price + Tax;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Tax: {Tax}");
            Console.WriteLine($"TotalPrice: {TotalPrice}");
        }
    }
}
