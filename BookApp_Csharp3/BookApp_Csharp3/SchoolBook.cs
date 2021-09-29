using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp_Csharp3
{
    internal class SchoolBook :Book
    {
        public BookState BookState {  get; set; }

        public double TotalPrice
        {
            get => (BookState == BookState.New) ? Count * Price : Count * Price * 0.5;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"State:{BookState} ");
            Console.WriteLine($"TotaPrice: {TotalPrice}");
        }
    }
}
