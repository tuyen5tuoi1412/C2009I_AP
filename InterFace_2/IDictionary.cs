using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InterFace_2
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
