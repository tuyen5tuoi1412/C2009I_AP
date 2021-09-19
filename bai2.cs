using System;
namespace _13_09_2021
{
    public struct Product
    {
        public String name;
        public String madein;
        public String brand;
        public DateTime importDate;
        public DateTime expriredDate;

        public Product(String name, String brand, String madein,
            DateTime importDate, DateTime expriredDate)
        {
            this.name = name;
            this.brand = brand;
            this.madein = madein;
            this.importDate = importDate;
            this.expriredDate = expriredDate;

        }
        public override string ToString()
        {
            return $"name = { this.name}
"        }
    }
}