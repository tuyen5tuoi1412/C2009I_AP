using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Interface_Flim
{

    public class MyFilm
    {
        Film movies = new Film();
        int choice = 0;
        String film;
        String nation;
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("================================");
                Console.WriteLine("|   WELCOME TO MY MOVIE LIST   |");
                Console.WriteLine("================================");
                Console.WriteLine("| 1. Add a movie               |");
                Console.WriteLine("| 2. Edit a movie              |");
                Console.WriteLine("| 3. Remove movie              |");
                Console.WriteLine("| 4. List all movie            |");
                Console.WriteLine("| 5. Search Movie              |");
                Console.WriteLine("| 6. Clear Screen              |");
                Console.WriteLine("| 7. End Program               |");
                Console.WriteLine("================================");
                Console.WriteLine("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice >7 || choice < 1)
                {
                    Console.WriteLine("Please, Enter number 1-7");
                }
                else
                {
                    Console.WriteLine($"Your choice is: {choice}");
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Name of film: ");
                        film = Console.ReadLine();
                        if (!movies.check(film))
                        {
                            Console.WriteLine("Enter Nation of film: ");
                            nation = Console.ReadLine();
                            movies.AddFilm(film, nation);
                        }
                        else
                        {
                            Console.WriteLine($"Film: \"{film}\" is exists....");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter your film want edit: ");
                        film = Console.ReadLine();
                        if (movies.check(film))
                        {
                            Console.WriteLine("Enter your new nation of movies:  ");
                            nation = Console.ReadLine();
                            movies.EditFilm(film, nation);
                            Console.WriteLine("Edit Complete...Thank you..!");


                        }
                        else
                        {
                            Console.WriteLine($"This film:\"{film}\" is not found! ");

                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter name film you want remove...");
                        film = Console.ReadLine();
                        movies.Remove(film);
                        break;
                    case 4:
                        Console.WriteLine("All List film for you: ");
                        movies.ListFilm();
                        break;
                    case 5:
                        Console.WriteLine("Enter name film you lokking for:  ");
                        film = Console.ReadLine();
                        movies.SearchFilm(film);
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("End Program!...Thank you see a movies! ");
                        return;
                }
            }
        }
    }
}

