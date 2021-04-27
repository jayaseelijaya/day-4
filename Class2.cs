using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    public class Product
    {
        public string Customer { get; set; }
        public string ProductCode { get; set; }

        public int ProductQuantity { get; set; }

        public int TotalQuantity { get; set; }
        public void GetProductDetails()
        {
            Console.WriteLine("Enter Customer mode :");
            Customer = Console.ReadLine();
            Console.WriteLine("Enter Product Code :");
            ProductCode = Console.ReadLine();
        }
    }
    class Invoice : Product
    {

        public void PrintInvoice()
        {

            TotalQuantity = 100;
            if (Customer == "Buyer")
            {
                Console.WriteLine("Enter Product Quantity  :");
                ProductQuantity = Convert.ToInt32(Console.ReadLine());
                TotalQuantity = TotalQuantity - ProductQuantity;
                Console.WriteLine("Enter New Total Quantity  :" + TotalQuantity);
                Console.ReadLine();
            }
            else if (Customer == "Wholeseller")
            {
                Console.WriteLine("Enter Product Quantity  :");
                ProductQuantity = Convert.ToInt32(Console.ReadLine());
                TotalQuantity = TotalQuantity + ProductQuantity;
                Console.WriteLine("Enter New Total Quantity  :" + TotalQuantity);
                Console.ReadLine();
            }
        }
    }
    public class User
    {
        public static void Main()
        {

            Invoice invoice = new Invoice();
            invoice.PrintInvoice();
            invoice.GetProductDetails();
            

            Console.ReadLine();
        }
    }
}
