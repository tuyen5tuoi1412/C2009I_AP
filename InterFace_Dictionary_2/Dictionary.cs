using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace InterFace_Dictionary_2
{
    public class Dictionary : IDictionary     
    {
        List<Word> WordList = new List<Word>();
        public void AddWord(string word, string meanning)
        {
            if(WordList.Where(item => item.Equals(word)).ToList().Count == 0)
            {
                Word NewWOrdObject = new Word()
                {
                    NewWord = word,
                    Meanning = meanning
                };
                WordList.Add(NewWOrdObject);
            }
            else
            {
                Console.WriteLine($"This word:\"{word}\" is Exists. ");
            }
        }

        public void EditWord(string word, string meanning)
        {
            if(WordList.Where(item => item.NewWord.Equals(word)).Any())
            {
                var index = WordList.FindIndex(item => item.NewWord.Equals(word));
                WordList[index] = new Word() { NewWord = word, Meanning = meanning };
            }
            else
            {
                Console.WriteLine($"This word is not found! ");
            }
        }

        public void List()
        {
            foreach(Word w in WordList)
            {
                w.Display();
            }
        }

        public bool Remove(string word)
        {
            Word WordFound = this.WordList.Where(item => item.NewWord.Equals(word)).FirstOrDefault();
            if (WordFound != null)
            {
                this.WordList.Remove(WordFound);
                Console.WriteLine("Remove Successfull!");
                return true;
            }
            Console.WriteLine($"The word\"{word}\" is not found! ");
            return false;
        }

        public void Search(string word)
        {
            Word WordFound = this.WordList.Where(item => item.NewWord.Equals(word)).FirstOrDefault();
            if(WordFound != null)
            {
                WordFound.Display();
            }
            else
            {
                Console.WriteLine($"This word: \"{word}\" is not found! ");

            }
        }

        public bool check(String word)
        {
            return this.WordList.Exists(item => item.NewWord == word);
        }
    }
}
