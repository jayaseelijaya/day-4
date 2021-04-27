using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    public class product
    {
        int No, quantity, n;
        string name;
        double price, total;

        public void Inputvalues()
        {


            Console.WriteLine("enter the number of product:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("enter productno: ");
                int No = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter product quantity; ");
                quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter productname:");
                string name = Console.ReadLine();
                Console.WriteLine("enter productprice:");
                price = Convert.ToDouble(Console.ReadLine());
                total = price * quantity;
                Console.WriteLine("productno:\tproductname\t productquantity\tproductprice\t total");
            }

        }
           static void Main()
            {
            product d = new product();
               
        
            d.Inputvalues();
            Console.ReadLine();

            }


        }
    }
