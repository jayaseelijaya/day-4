using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class Class3
    {
        public void Inputx()
        {
            Console.WriteLine("enter the value of x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x =" + x);
        }

        public static void Main()
        {
            Class3 obj = new Class3();
            int exitkey = 1;
            while (exitkey > 0)
            {
                Console.WriteLine("you want to exit--y/n");
                string choice = (Console.ReadLine());
                if (choice.ToLower() == "n")
                {
                    obj.Inputx();
                    choice = Console.ReadLine();
                }
                else
                {
                    break;
                }
                Console.ReadLine();
            }
        }

    }
}
        
    

