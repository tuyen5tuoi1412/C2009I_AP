// See https://aka.ms/new-console-template for more information
namespace BookApp_Csharp3
{
    public class Program
    {
       
        
        public static void Main(string[] args)
        {

            List<SchoolBook> LSBook = new List<SchoolBook>();
            LSBook.Add(new SchoolBook() { Code = "A1", InputDate = new DateTime(2000, 01, 20), Price = 15000, Count= 10, Publisher = "A", BookState = BookState.New });
            LSBook.Add(new SchoolBook() { Code = "A2", InputDate = new DateTime(2000, 01, 20), Price = 30000, Count = 16, Publisher = "IPM", BookState = BookState.Old });
            LSBook.Add(new SchoolBook() { Code = "A3", InputDate = new DateTime(2000, 01, 20), Price = 45000, Count = 21, Publisher = "B", BookState = BookState.New });
            LSBook.Add(new SchoolBook() { Code = "A4", InputDate = new DateTime(2000, 01, 20), Price = 28000, Count = 5, Publisher = "IPM", BookState = BookState.Old });
            LSBook.ForEach(s => s.Display());






        }
        
    }

}

