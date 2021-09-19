using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace InterFace_Dictionary_2
{
    public class MyDictionary
    {
        String word;
        String meanning;
        Dictionary dictionary = new Dictionary();
        int choice = 0;
        
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("    WELCOME TO MY DICTIONARY     ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Add this word in Dictionary   ");
                Console.WriteLine("2. Edit this word in Dictionary  ");
                Console.WriteLine("3. Remove this word in Dictionary");
                Console.WriteLine("4.      All word In List         ");
                Console.WriteLine("5. Search this word in Dictionary");
                Console.WriteLine("6.       Clear the screen        ");
                Console.WriteLine("7.            End Prodgram       ");
                Console.WriteLine("==================================");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice >7 || choice <1)
                {
                    Console.WriteLine("Please Enter number 1 -7! ");

                }
                else
                {
                    Console.WriteLine($"Your choice is: {choice}");
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your Word you want add: ");
                        word = Console.ReadLine();
                        if (dictionary.check(word)) {
                            Console.WriteLine($"The word \"{word}\" is Exists..");
                        }
                        else
                        {
                            Console.WriteLine("Enter Meanning of Word you add: ");
                            meanning = Console.ReadLine();
                            dictionary.AddWord(word, meanning);
                           
                        }
                        
                        
                        break;
                    case 2:
                        Console.WriteLine("Enter this word you want edit: ");
                        word = Console.ReadLine();
                        if (dictionary.check(word))
                        {
                            Console.WriteLine("Enter this new meanning: ");
                            meanning = Console.ReadLine();
                            dictionary.EditWord(word, meanning);
                            Console.WriteLine("Edit is successful");
                        }
                        else
                        {
                            Console.WriteLine($"the word:\"{word}\" is not found");
                            
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("Enter a word you want remove: ");
                        word = Console.ReadLine();
                        dictionary.Remove(word);
                        
                        break;
                    case 4:
                        Console.WriteLine("List all the word:");
                        dictionary.List();
                        break;
                    case 5:
                        Console.WriteLine("Enter your word you want search: ");
                        word = Console.ReadLine();
                        dictionary.Search(word);
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("End Program! ");
                        return;
                    
                       
                    
                       
                }
            }
        }

    }
}

