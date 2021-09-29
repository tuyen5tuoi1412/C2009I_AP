using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Csharp2
{
     abstract class DeviceBase
    {
        private int _id;
        private string? _name;
        public int ID { get => _id; }
        public string Name 
        {
            get {  return _name; }
            set
            {
                try
                {
                    if(value.Length < 5)
                    {
                        throw new Exception();
                        Name = _name;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine(":Name must have than 5 character");
                }
            }
        }
        public DeviceBase(int id)
        {
            this._id = id;
            Name = "No Name";
        }
        public DeviceBase(int id,string name)
        {
            this._id = id;
            Name = name;
        }
        abstract public void ShowInfo();
    }
}
