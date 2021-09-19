using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Interface_Dictionary
{
    public class Dictionary : IDictionary
    {
        List<Word> WList = new List<Word>();
        public void AddWord(string word, string meanning)
        {
           if(WList.Where(item => item.NewWord.Equals(word)).ToList().Count == 0)
            {
                Word NewWordObject = new Word()
                {
                    NewWord = word,
                    Meanning = meanning
                };
                WList.Add(NewWordObject);

            }
            else
            {
                Console.WriteLine($"This word \"{word}\" is Exists");
            }
        }

        public void EditWord(string word, string meanning)
        {
            if (WList.Where(item => item.NewWord.Equals(word)).Any())
            {
                var index = WList.FindIndex(item => item.NewWord.Equals(word));
                WList[index] = new Word() { NewWord = word, Meanning = meanning };
            }
            else
            {
                Console.WriteLine($"The word \"{word}\" could not be found");
            }

        }

        public void List()
        {
            foreach(Word w in WList)
            {
                w.Display();
            }
        }

        public bool Remove(string word)
        {
            Word foundWord = this.WList.Where(item => item.NewWord.Equals(word)).FirstOrDefault();
            if(foundWord != null)
            {
                this.WList.Remove(foundWord);
                return true;
            }
            Console.WriteLine($"\"{word}\" is not found ");
            return false;

        }

        public void Search(string word)
        {
            Word foundWord = this.WList.Where(item => item.NewWord.Equals(word)).FirstOrDefault();
            if(foundWord != null)
            {
                foundWord.Display();

            }
            else
            {
                Console.WriteLine($"\"{word}\" is not found! ");
            }
        }
        
    }
}
