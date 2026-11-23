using System;
using System.Linq;

namespace funcional
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Instanciando una lista de tipo Product
            var products = new List<Product>()
            {
                new Product(){Brand="Pepsi",Price=6.50m,Stock=4,State=true},
                new Product(){Brand="Coca Cola",Price=8m,Stock=16,State=true},
                new Product(){Brand="Doritos",Price=4m,Stock=0,State=false},
                new Product(){Brand="Lais",Price=5.25m,Stock=24,State=true},
            };

            // Iteracion de productos con State en True
            foreach(var product in products)
            {
                if(product.State == true)
                    Console.WriteLine($"Name: {product.Brand}");
            }

            var products2 = products
            .Where(p => p.State == true)
            .Select(p => new {Brand = p.Brand.ToUpper()});

            foreach(var item2 in products2)
            {
                Console.WriteLine(item2.Brand);
            }
        }
    }

    public class Product
    {
        public string Brand {get;set;}
        public decimal Price {get;set;}
        public int Stock {get;set;}
        public bool State {get;set;}
    }
}