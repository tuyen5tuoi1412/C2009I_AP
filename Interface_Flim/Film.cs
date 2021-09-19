using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Interface_Flim
{
    public class Film:IFilm
    {
        List<Key> LKey = new List<Key>();

        public void AddFilm(String film, String nation)
        {
          if(LKey.Where(item => item.NewFilm.Equals(film)).ToList().Count == 0)
            {
                Key NewKeyObject = new Key()
                {
                    NewFilm = film,
                    Nation = nation
                };
                LKey.Add(NewKeyObject);
            }
        }

        public void EditFilm(String film, String nation)
        {
            if(LKey.Where(item => item.NewFilm.Equals(film)).Any())
            {
                var index = LKey.FindIndex(item => item.NewFilm.Equals(film));
                LKey[index] = new Key() { NewFilm = film, Nation = nation };
            }
        }

        public void ListFilm()
        {
            foreach (Key k in LKey)
            {
                k.Display();
            }
        }

        public bool Remove(String film)
        {
            Key FoundKey = LKey.Where(item => item.NewFilm.Equals(film)).FirstOrDefault();
            if(FoundKey != null)
            {
                LKey.Remove(FoundKey);
                Console.WriteLine("Remove successful...!");
                return true;
            }
            Console.WriteLine($"The Film: \"{film}\" is not found....!");
            return false;
        }


        public void SearchFilm(String film)
        {
            Key FoundKey = LKey.Where(item => item.NewFilm.Equals(film)).FirstOrDefault();
            if (FoundKey != null)
            {
                FoundKey.Display();
            }
            else
            {
                Console.WriteLine($"The film \"{film}\" is not found....!");
            }
        }

        public bool check(String film)
        {
           return LKey.Exists(item => item.NewFilm == film);
        }
    }
}