namespace Product_Csharp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LaptopList myList = new LaptopList(3);
            Laptop laptop;
            int id = 0;
            string name = "";
            int price = 0;
            string manufacturer = "";
            int maxprice =0;
            for(int i=0; i < 3; i++)
            {
                Console.WriteLine($"Enter information of laptop[{i + 1}]:");
                do
                {
                    Console.WriteLine("ID: ");
                    id = Convert.ToInt32(Console.ReadLine().Trim());
                } while (id <= 0);
                Console.WriteLine("Name");
                name = Console.ReadLine().Trim();
                if (name.Equals(""))
                {
                    laptop = new Laptop(id);
                }
                else
                {
                    Console.WriteLine("Price: ");
                    price = Convert.ToInt32(Console.ReadLine().Trim());
                    Console.WriteLine("Manufacturer: ");
                    manufacturer = Console.ReadLine().Trim();
                    laptop = new Laptop(id, name, price) { Manufacture = manufacturer };
                }
                myList.AddLaptop(laptop);

            }
            Console.Write("Enter max price: ");
            maxprice = Convert.ToInt32(Console.ReadLine().Trim());
            myList.ShowFilterLaptop(maxprice);

        }
    }
}
