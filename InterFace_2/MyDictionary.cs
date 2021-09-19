using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InterFace_2
{
    public class MyDictionary
    {
        public void Showmenu()
        {
			Dictionary dictionary = new Dictionary();
			String word;
			String meanning;
			int choice = 0;
			while (true)
            {
				Console.WriteLine("=================================");
				Console.WriteLine("    WELCOME TO MY DICTIONARY     ");
				Console.WriteLine("=================================");
				Console.WriteLine("Please choice a task: ");
				Console.WriteLine("1. Add a word ");
				Console.WriteLine("2. Edit a word");
				Console.WriteLine("3. Remove a word");
				Console.WriteLine("4. List all a word");
				Console.WriteLine("5. Search ");
				Console.WriteLine("6. ClearScreen ");
				Console.WriteLine("7. Exit");
				Console.WriteLine("==================================");
				choice = Convert.ToInt32(Console.ReadLine());
				if (choice > 7 || choice < 1)
				{
					Console.WriteLine("Please, enter number 1 - 7");
				}
				else
				{
					Console.WriteLine($"Your Choice is:{choice} ");
				}
                switch (choice)
                {
					case 1:
						Console.WriteLine("Enter your word: ");
						word = Console.ReadLine();
						Console.WriteLine("Enter meaning of word: ");
						meanning = Console.ReadLine();
						dictionary.AddWord(word,meanning);
						break;

					case 2:
						Console.WriteLine("Enter word you want edit: ");
						word = Console.ReadLine();
						Console.WriteLine("Enter new meanning of word: ");
						meanning = Console.ReadLine();
						dictionary.EditWord(word,meanning);
						break;
					case 3:
						Console.WriteLine("enter word you would like to remove: ");
						word = Console.ReadLine();
						dictionary.Remove(word);
						break;
					case 4:
						Console.WriteLine("List all word is: ");
						dictionary.List();
						break;
					case 5:
						Console.WriteLine("Enter word you would like to find: ");
						word = Console.ReadLine();
						dictionary.Search(word);
						break;
					case 6:
						Console.Clear();
						break;
					case 7:
						Console.WriteLine("End Program");
						return;

				}
			}
        }

		static void Main(string[] args)
		{
			MyDictionary MD = new MyDictionary();
			MD.Showmenu();
		}
	}
}
