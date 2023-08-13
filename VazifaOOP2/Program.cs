using System.Net.Http.Headers;

namespace VazifaOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(12000,"Matiz","Chevrolet");

            decimal price = car1.CalculatePrice();
           
            car1.DisplayInfo();
            Console.WriteLine("Calculated price : " + price);


            Ferrari ferrari1 = new Ferrari(12_000_000,"new model","ferrari");
            
            price = car1.CalculatePrice();

            Console.WriteLine("Calculated price : " + price);

            ferrari1.DisplayInfo();

            


        }

    }
    class Car
    {
        public decimal Price { get; set; }
        public string  Model { get; set; }
        public string Brand { get; set; }

        public Car(decimal price,string model,string brand)
        {
            Price = price;
            Model = model;
            Brand = brand;
        }
        public decimal CalculatePrice()
        {
            return Price + Price * 13 / 100;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Model : " + Model);
            Console.WriteLine("Brand : " + Brand);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine();
        }
    } 

    class Ferrari : Car
    {
        public Ferrari(decimal price, string model, string brand) 
            :base(price ,model,brand)
        {}
    }
    class Toyota : Car
    {
        public Toyota(decimal price, string model, string brand) 
            : base(price,model,brand)
        {}
    }
    class Lamborgini : Car
    {
        public Lamborgini(decimal price, string model, string brand) 
            : base(price,model,brand)
        {}
    }

}