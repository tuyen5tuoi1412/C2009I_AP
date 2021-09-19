using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Interface_Flim
{
    interface IFilm
    {
        void AddFilm(String film, String nation);
        void EditFilm(String film, String nation);
        bool Remove(String film);
        void ListFilm();
        void SearchFilm(String film);
    }
}
