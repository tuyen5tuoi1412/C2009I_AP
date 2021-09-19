using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_Ex1
{
    public abstract class Dictionary : IDictionary
    {

        public void AddWord(String word , String meanning)
        {
            
        }
        public void EditWord(string word, string meanning)
        {
            throw new NotImplementedException();
        }

        public void List()
        {
            throw new NotImplementedException();
        }

        public bool Remove(string word)
        {
            throw new NotImplementedException();
        }

        public void Search(string word)
        {
            throw new NotImplementedException();
        }

        void IDictionary.AddWord(string word, string meanning)
        {
            throw new NotImplementedException();
        }
    }
}


