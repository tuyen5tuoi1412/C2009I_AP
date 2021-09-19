using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_interface_1
{
    public class Dictionary: IDictionary
    {
        List<Word> Lword = new List<Word>();
        public void AddWord(String word, String meanning)
        {
            Lword.Add(new Word() { NewWord = word, Meanning = meanning });
        }
        public void EditWord(String word, String meanning)
        {
            var index = Lword.FindIndex(item => item.NewWord == word);
            Lword[index] = new Word() { NewWord = word, Meanning = meanning };

        }

        public void Remove(String word)
        {
            if (!check(word))
            {
                Console.WriteLine($"Can not find word \"{word}\" to remove ");

            }
            else
            {
                var index = Lword.FindIndex(item => item.NewWord == word);
                Lword.RemoveAt(index);
                Console.WriteLine("Remove successful! ");


            }
        }
        public void List()
        {  
               foreach(Word w in Lword)
            {
                w.Display();
            }
        }

        public void Search(String word)
        {
            if (!check(word))
            {
                Console.WriteLine($"The word \"{word}\" is not found");
            }
            else
            {
                Console.WriteLine("meanning: ");
                Console.WriteLine(Lword.Find(item => item.NewWord == word).Meanning);

            }
        }

        public bool check(String word)
        {
           return Lword.Exists(item => item.NewWord == word);
        }
    }
}

