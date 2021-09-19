using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Interface_Flim
{
    public class Key:Ikey
    {
        public String NewFilm { get; set; }
        public String Nation { get; set; }
        public void Display()
        {
            Console.WriteLine($"The Film: \"{ NewFilm} \"of \"{Nation}\" Welcome!.....");

        }
    }
}