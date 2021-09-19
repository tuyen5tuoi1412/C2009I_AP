using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace InterFace_Dictionary_2
{
    public class Word
    {
        public String NewWord { get; set; }
        public String Meanning { get; set; }
        public void Display()
        {
            Console.WriteLine($"{NewWord} is {Meanning}");
        }
    }
}
