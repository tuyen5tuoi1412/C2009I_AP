using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Csharp2
{
     interface IDevice
    {
        public String Manufacture { get; set; }
        public int Price { get; set; }
        public float VAT { get; }
        public float NetPrice {  get;}
    }
}
