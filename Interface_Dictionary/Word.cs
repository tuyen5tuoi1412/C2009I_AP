using System;
namespace Interface_Dictionary
{
    public class Word:IWord
    {
        public String NewWord { get; set; }
        public String Meanning { get; set; }
        public void Display()
        {
            Console.WriteLine($"{NewWord} is {Meanning}");
        }

        
    }
}
