using System;
namespace Interface_Dic_3
{
    public class MyDictionary
    {
        Dictionary dictionary = new Dictionary();
        String word;
        String meanning;
        int choice = 0;
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine("|   WELCOME TO MY DICTIONARY   | ");
                Console.WriteLine("================================");
                Console.WriteLine("|         1. Add Word          |");
                Console.WriteLine("|         2. Edit Word         |");
                Console.WriteLine("|         3. Remove Word       |");
                Console.WriteLine("|         4. List all word     |");
                Console.WriteLine("|         5. Search Word       |");
                Console.WriteLine("|         6. Clear Screen      |");
                Console.WriteLine("|         7. End Program       |");
                Console.WriteLine("================================");
                Console.WriteLine("Please,Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice>7 || choice < 1)
                {
                    Console.WriteLine("Please,Enter number 1 - 7");

                }
                else
                {
                    Console.WriteLine($"Your choice is: {choice}");
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a word: ");
                        word = Console.ReadLine();
                        if (!dictionary.check(word)) 
                        {
                            Console.WriteLine("Enter a Meanning: ");
                            meanning = Console.ReadLine();
                            dictionary.AddWord(word, meanning);
                        }else
                        {
                            Console.WriteLine($"This word \"{word}\" is exists....");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter your word you want edit: ");
                        word = Console.ReadLine();
                        if (dictionary.check(word))
                        {
                            Console.WriteLine("Enter New Meanning of word: ");
                            meanning = Console.ReadLine();
                            dictionary.EditWord(word, meanning);
                            Console.WriteLine("Edit is successful....");
                        }
                        else
                        {
                            Console.WriteLine($"This word \"{word}\" is not found");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter your word you want remove: ");
                        word = Console.ReadLine();
                        dictionary.Remove(word);
                        break;
                    case 4:
                        Console.WriteLine("List all word:");
                        dictionary.List();
                        break;
                    case 5:
                        Console.WriteLine("Enter word you want search: ");
                        word = Console.ReadLine();
                        dictionary.Search(word);
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("End Program.....See you again");
                        return;

                }
            }
        }
    }
}


