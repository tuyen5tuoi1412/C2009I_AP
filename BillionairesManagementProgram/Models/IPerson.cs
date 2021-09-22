using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillionairesManagementProgram.Models
{
    interface IPerson
    {
        public void Input();
        public void SortPersonByAge();
        void Display();

        public void Analyze();

        public void Find();

        public void Save();

        public void Open();
    }
}
