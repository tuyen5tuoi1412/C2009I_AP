using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Interface_Dic_3
{
    public class Dictionary:IDictionary
    {
        List<Word> LWord = new List<Word>();

        public void AddWord(string word, string meanning)
        {
            if(LWord.Where(item => item.Equals(word)).ToList().Count == 0)
            {
                Word NewWordObject = new Word()
                {
                    NewWord = word,
                    Meanning = meanning
                };
                LWord.Add(NewWordObject);


            }
            
        }

        public void EditWord(string word, string meanning)
        {
            if (LWord.Where(item => item.NewWord.Equals(word)).Any())
            {
                var index = LWord.FindIndex(item => item.NewWord.Equals(word));
                LWord[index] = new Word() { NewWord = word, Meanning = meanning };
            }
            /*else
            {
                Console.WriteLine($"This word: \"{word}\" is not found! ");
            }*/
        }

        public void List()
        {
            foreach(Word w in LWord)
            {
                w.Display();
            }
        }

        public bool Remove(string word)
        {
            Word FoundWord = this.LWord.Where(item => item.NewWord.Equals(word)).FirstOrDefault();
            if(FoundWord != null)
            {
                this.LWord.Remove(FoundWord);
                Console.WriteLine("Remove is success full...");
                return true;
            }
            Console.WriteLine($"This word:\"{word}\" is not found!  ");
            return false;
        }

        public void Search(string word)
        {
            Word FoundWord = this.LWord.Where(item => item.NewWord.Equals(word)).FirstOrDefault();
            if(FoundWord != null)
            {
                FoundWord.Display();
            }
            else
            {
                Console.WriteLine($"This word:\"{word}\" is not found!  ");
            }
        }

        public bool check(String word)
        {
            return this.LWord.Exists(item => item.NewWord == word);
        }
    }
}
