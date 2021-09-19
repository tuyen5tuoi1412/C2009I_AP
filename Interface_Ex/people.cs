using System;
namespace Interface_Ex
{
    public class People : IAction
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string PhoneNumber { get; set; }

        public People()
        {
        }

        public void Running()
        {
            Console.WriteLine("People is running");
        }
    }
}

