using System.Net.Http.Headers;

namespace VazifaOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.DisplayInfo();

            Product product2 = new Product(5000,"Orbit");
            product2.DisplayInfo();

            Product product3 = new Product(12000,"Pepsi");
            product3.DisplayInfo();

            Product product4 = new Product(40000,"Hobbit",17,"Kitoblar");
            product4.DisplayInfo();

            decimal totalSum = CalculateTotal(product1, product2, product3, product4);

            Console.WriteLine("Umumiy to'lov summasi : " + totalSum);

            Console.ReadKey();
        }
        public static decimal CalculateTotal(params Product[] allProducts)
        {
            decimal totalSum = 0;

            foreach(var product in allProducts)
            {
                totalSum += product.Price;
            }

            return totalSum;
        }

    }

    class Product
    {
        public decimal Price { get; set;}
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
    
        public Product()
        {
            Price = 2800;
            Name = "Non";
            Code = 01;
            Category = "Un mahsulotlari";
        }
        public Product(decimal price,string name)
        {
            Price = price;
            Name = name;
            Code = 01;
            Category = "Un mahsulotlari";
        }
        public Product(decimal price, string name, int code, string category)
        {
            Price=price;
            Name=name;
            Code=code;
            Category=category;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Mahsulot : " + Name);
            Console.WriteLine("Narxi : " + Price);
            Console.WriteLine("Kategoriyasi : " + Category);
            Console.WriteLine("Mahsulot kodi : " + Code);
            Console.WriteLine();
        }
    }
}