using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Inventory Console");
        }
        public class Product
        {
            public string productName { get; set; }
            public double productPrice { get; set; }
            public int productQuantity { get; set; }

            public Product(string productName, double productPrice, int productQuantity)
            {
                this.productName = productName;
                this.productPrice = productPrice;
                this.productQuantity = productQuantity;
            }

            public override string ToString()
            {
                return $"Product name : {productName} --- Product price : {productPrice} --- Product quantity : {productQuantity}";
            }
        }

    }
}
