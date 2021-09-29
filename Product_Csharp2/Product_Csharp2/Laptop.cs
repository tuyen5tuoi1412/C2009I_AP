using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Csharp2
{
     class Laptop : DeviceBase,IDevice
     {
        private int _price;
        private float _vat;
        private string? _manufacturer;
        public Laptop(int id) : base(id)
        {
            this._price = 0;
            this._vat = 0.1f;
        }
        public Laptop(int id,string name,int price) : base(id, name)
        {
            Price = price;
            this._vat = 0.1f;
        }

        public string Manufacture { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Price 
        {
            get { return this._price; }
            set
            {
                try
                {
                    if(value <= 0) 
                    {
                        throw new Exception();
                        _price = value;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Price must not less than equals 0");
                }
            }
        }
        public float VAT => _vat;
        public float NetPrice => Price * (1 + VAT);
        public override void ShowInfo()
        {
            Console.WriteLine($"ProductID:{ID,-2} | Name: {Name} | Price: {Price} | Net Price: {NetPrice} | Manufacturer: {Manufacture} |");

        }
    }
}
