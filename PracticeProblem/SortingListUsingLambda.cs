using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    public class Product
    {
       public string Name { get; set;}
       public decimal Price { get; set; }
    }

    internal class SortingListUsingLambda
    {
        //Sort a list of products based on their prices using a
        //lambda expression for custom sorting criteria.
        public static void SortList()
        {
            List<Product> product = new List<Product>
            {
                new Product{Name="Laptop", Price=45000},
                new Product { Name = "Smartphone", Price = 30000 },
                new Product { Name = "Tablet", Price = 20000 },
                new Product { Name = "Smartwatch", Price = 10000 }
            };

            product.Sort ((product1, product2) => product1.Price.CompareTo(product2.Price));
            Console.WriteLine("List of product based on their price:");
            foreach(var i in product)
            {
                Console.WriteLine($"Name {i.Name}, Price: {i.Price}");
            }
        }

    }
}
