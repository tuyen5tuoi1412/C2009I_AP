using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptech
{
    public class Employee : Person
    {
        Person person = new Person();
        public double Salary { get; set; }
        public void IncreaseSalary(int x) => Salary += x;
        public void IncreaseSalary(double x) => Salary *= x;
        public override string ToString()
        {
            return base.ToString() + $"\nSalary: {Salary}";
        }



    }
}
