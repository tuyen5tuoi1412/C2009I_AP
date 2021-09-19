using System;
namespace Dictionary_interface_1
{
    public interface IDictionary
    {
        void AddWord(String word, String meanning);
        void EditWord(String word, String meanning);
        void Remove(String word);
        void List();
        void Search(String word);
    }
}

