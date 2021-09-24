using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptech
{
    class Manager : Employee, Tax
    {
        public double Bonus { get; set; }
        public double Tax { get; set; }

        public double CaculatedTax()
        {
            Bonus = Salary * 0.2;
            Tax = Salary * 0.1;
            return Salary += Bonus - Tax;
            
        }
        public override string ToString()
        {
            return base.ToString() + $"\n Bonus: {Bonus}";
        }

    }
}
