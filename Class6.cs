using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    class MyException : ApplicationException
    {
        public void MyException()
        {
            Console.WriteLine("an exception occured");
        }
        public void MyDivideException()
        {
            Console.WriteLine("exceptional occred diviser should not be zero");
        }
    }
    class Class6
    {
        public static void Main()
        {
            int x = 5, y = 0, z;
            try
            {
                if (y == 0)
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
    } }
