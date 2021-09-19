using System;
namespace Interface_Dictionary
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
                Console.WriteLine("======================================");
                Console.WriteLine("      WELCOME TO MY DICTIONARY        ");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Add a word in my list");
                Console.WriteLine("2. Edit a word in my list");
                Console.WriteLine("3. Remove a word in my list");
                Console.WriteLine("4. Screen all word in List");
                Console.WriteLine("5. Search word in my List");
                Console.WriteLine("6. Clear their screen ");
                Console.WriteLine("7. End Program");
                Console.WriteLine("=======================================");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice>7 || choice < 1)
                {
                    Console.WriteLine("Please Enter number 1 - 7");
                }
                else
                {
                    Console.WriteLine($"your choice is: {choice} ");

                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a word you want Add: ");
                        word = Console.ReadLine();
                        Console.WriteLine("Enter a meanning of word you add: ");
                        meanning = Console.ReadLine();
                        dictionary.AddWord(word, meanning);
                        break;
                    case 2:
                        
                        Console.WriteLine("Enter a word you want edit: ");
                        word = Console.ReadLine();
                        Console.WriteLine("Enter meanning of word you want edit: ");
                        meanning = Console.ReadLine();
                        Console.WriteLine($"\"{word}\" is not found! ");
                        

                        dictionary.EditWord(word, meanning);

                        break;
                    case 3:
                        Console.WriteLine("Enter a word you want remove: ");
                        word = Console.ReadLine();
                        dictionary.Remove(word);
                        break;
                    case 4:
                        Console.WriteLine("All word in List: ");
                        dictionary.List();
                        break;
                    case 5:
                        Console.WriteLine("Enter a word you want lookfor: ");
                        word = Console.ReadLine();
                        dictionary.Search(word);
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("End Program! See you again! ");
                        return;
                }
            }
            
            

        }
    }
}
