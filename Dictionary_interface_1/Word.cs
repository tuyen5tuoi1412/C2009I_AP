using System;
namespace Dictionary_interface_1
{
	public class Word : IWord
	{
        public string NewWord { get; internal set; }
        public string Meanning { get; internal set; }

        public void Display()
        {
            
             Console.WriteLine($"{NewWord}: {Meanning}");
        }

        
	}
}


