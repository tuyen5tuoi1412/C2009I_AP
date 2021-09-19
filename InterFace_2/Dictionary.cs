using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InterFace_2
{
    public class Dictionary : IDictionary
    {
        List<Word> WList = new List<Word>();
        public void AddWord(string word, string meanning)
        {
            if(WList.Where(item => item.NewWord.Equals(word)).ToList().Count == 0)
            {
                Word newWordObject = new Word()
                {
                    NewWord = word,
                    Meanning = meanning
                };
                WList.Add(newWordObject);

            }

        }

        public void EditWord(string word, string meanning)
        {
            Word foundWord = this.WList.Where(item => item.NewWord.Equals(word)).FirstOrDefault();
            if(foundWord != null)
            {
                foundWord.NewWord = word;
                foundWord.Meanning = meanning;
            }

        }

        public void List()
        {
            foreach(Word w in this.WList)
            {
                w.Display();
            }

        }

        public bool Remove(String word)
        {
            Word foundWord = this.WList.Where(item => item.NewWord.Equals(word)).FirstOrDefault();
            if(foundWord != null)
            {
                this.WList.Remove(foundWord);
                return true;

            }
            Console.WriteLine($"Word \"{word}\" is not found");
            return false;
        }
        public void Search(string word)
        {
            Word foundWord = this.WList.Where(item => item.NewWord.Equals(word)).FirstOrDefault();
            if(foundWord != null)
            {
                foundWord.Display();
            }
        }

       
    }
}
