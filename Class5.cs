using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class Class5
    {
        public static void Main()
        {
            int x = 1;
            int y;
            
         
                try
                {
                y = x / 0;
                Console.WriteLine(y);
                }
                catch ( DivideByZeroException ex)
                {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("some error");
                    
                }

            Console.ReadLine();
        }

       
        }
    }

