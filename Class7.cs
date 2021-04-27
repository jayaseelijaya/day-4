using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class MyException : ApplicationException
    {

        public void MyDivideException()
        {
            Console.WriteLine("exceptional occured null");
        }
    }
    class Class7
    {
        public static void Main()
        {
           int y;
            try
            {
                if (y == null)
                {
                    throw new MyException();
                }
            }
            catch (MyException ex)
            {
                ex.MyDivideException();
            }
            Console.ReadLine();

        }
    }
}
