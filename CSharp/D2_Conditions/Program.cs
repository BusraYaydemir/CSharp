using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            //! If Condition
            if(number == 10)
            {
                Console.WriteLine("The Number is 10");
            }
            else
            {
                Console.WriteLine("The Number is not 10");
            }


            //! Single Line If
            Console.WriteLine(number == 10 ? "The Number is 10" : "The Number is not 10");


            //! Else If
            if(number == 10)
            {
                Console.WriteLine("The Number is 10");
            } else if (number == 20)
            {
                Console.WriteLine("The Number is 20");
            } else
            {
                Console.WriteLine("The Number is not 10 or 20");
            }


            //! Switch Case
            switch (number)
            {
                case 10:
                    Console.WriteLine("The Number is 10");
                    break;
                case 20:
                    Console.WriteLine("The Number is 20");
                    break;
                default:
                    Console.WriteLine("The Number is not 10 or 20");
                    break; // You should add break in deafult section also
            }
            Console.ReadLine();
        }
    }
}
