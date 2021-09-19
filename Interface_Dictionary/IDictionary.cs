﻿using System;
namespace Interface_Dictionary
{
    interface IDictionary
    {
        void AddWord(String word, String meanning);
        void EditWord(String word, String meanning);
        bool Remove(String word);
        void List();
        void Search(String word);
    }
}