using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Csharp2
{
    internal class LaptopList
    {
        private List<Laptop> LTList = new List<Laptop>();
        public LaptopList(int capacity) => LTList.Capacity = capacity;
        public Laptop this[int index]
        {
            get
            {
               
                try
                {
                    return LTList[index];
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Index {index} is out of range");
                    return null;
                }

            }
            set { LTList[index] = value; }
           
        }
        public int Count => LTList.Count;
        public void AddLaptop(Laptop lap)
        {
            if(LTList.Capacity == LTList.Count)
            {
                throw new Exception();
                LTList.Add(lap);
            }
        }
        public int ShowFilterLaptop(float maxPrice)
        {
            int numberOfLaptop = 0;
            foreach(Laptop lt in LTList)
            {
                if(lt.NetPrice <= maxPrice)
                {
                    lt.ShowInfo();
                    numberOfLaptop += 1;
                }
            }
            return numberOfLaptop;

        }
    }
}
