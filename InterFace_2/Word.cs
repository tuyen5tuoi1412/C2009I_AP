using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InterFace_2
{
    public class Word:IWord
    {
        public String NewWord { get; set; }
        public String Meanning { get; set; }
        public void Display()
        {
            Console.WriteLine($"{NewWord},{Meanning}");
        }

        
    }
}
