using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Inventory Managment Console");
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
            /*
               in default when you write Console.Writeline(); it calls the ToString(); method, so we override the tostring method
               to customize the displaying data of the prduct objects.
             */
            public override string ToString()
            {
                return $"Product name : {productName} --- Product price : {productPrice} --- Product quantity : {productQuantity}";
            }
        }
        public class Inventory
        {
            private List<Product> products = new List<Product>();

            public void AddProduct(Product p) 
            {
                products.Add(p);
                Console.WriteLine("#PRODUCT ADDED SUCCESSFULLY#");
            }
            public void ViewAllProducts()
            {
                if(products.Count == 0)
                {
                    Console.WriteLine("#INVENTORY IS EMPTY#");
                    return;   // هاي عشان يطلع من الميثود وما يكمل 
                }
                Console.WriteLine("# you have in the Inventory " +  products.Count + "Products");
                Console.WriteLine("All products : ");
                foreach(Product p in products)
                {
                    Console.WriteLine(p.ToString()); // here, the ToString(); method that we ovrrrided it will be called.
                }
            }
            public void EditProduct(string name)
            {
                //هون بدنا نبحث اذا الاسم اللي دخله اليوزر موجود ولا لا مع مراعاة عدم الحساسية بالاحرف كبيرة ولا صغيرة :
                Product p = products.Find(pr => pr.productName.Equals(name, StringComparison.OrdinalIgnoreCase));
                if(p == null)
                {
                    Console.WriteLine("# Product not Existed #");
                    return;
                }
                // Read new valuse form the user and store them in local variables , note to convert the types becasue the readline recieves a string from the user
                Console.WriteLine("Update/Change the product : ");
                Console.Write("Enter the new Name : ");
                string newName = Console.ReadLine();
                Console.Write("Enter the new Price : ");
                double newPrice = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the new Qauntity : ");
                int newQuantity = Convert.ToInt32(Console.ReadLine());
                
                // setteing the new vlaues that we got , and update the old valuse:
                p.productName = newName;
                p.productPrice = newPrice;
                p.productQuantity = newQuantity;
                Console.WriteLine("The product updated successfully !");
            }
            public void DeleteProduct(string name)
            {
                //هون بدنا نبحث اذا الاسم اللي دخله اليوزر موجود ولا لا مع مراعاة عدم الحساسية بالاحرف كبيرة ولا صغيرة :
                Product p = products.Find(pr => pr.productName.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (p == null)
                {
                    Console.WriteLine("# Product not Existed #");
                    return;
                }
                products.Remove(p);
                Console.WriteLine("Product Removed successfully");
            }
            public void SearchProduct(string name)
            {
                //هون بدنا نبحث اذا الاسم اللي دخله اليوزر موجود ولا لا مع مراعاة عدم الحساسية بالاحرف كبيرة ولا صغيرة :
                Product p = products.Find(pr => pr.productName.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (p == null)
                {
                    Console.WriteLine("# Product not Existed #");
                    return;
                }
                Console.WriteLine(p);
            }
        }

    }
}
