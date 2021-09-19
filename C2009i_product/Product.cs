using System;
namespace C2009i_product
{
    class Product
    {
        public String name;
        public String brand;
        public String madein;
        public DateTime importedDate; // convention
        public DateTime expiredDate;// convention
        // constructor
        public Product(String name, String madein, String brand,DateTime importedDate,DateTime expiredDate)
        {
            this.name = name;
            this.brand = brand;
            this.madein = madein;
            this.importedDate = importedDate;
            this.expiredDate = expiredDate;

        }
        public override string ToString() =>
            $"name = {this.name}," +
            $"brand = {this.brand}," +
            $"madein = {this.madein}," +
            $"importedDate = {this.importedDate}," +
            $"expiredDate = {this.expiredDate},";

    }
    
}


