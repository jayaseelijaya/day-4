using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class Class4
    {
        public void add()
        {
            Console.WriteLine("enter value x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( x + y);
        }
        public static void Main()
        {
            Class4 obj = new Class4();
            int exitkey = 5;
            while (exitkey > 0)
            {
                Console.WriteLine("you want to exit--y/n");
                string choice = (Console.ReadLine());
                if (choice.ToLower() == "n")
                {
                    obj.add();
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