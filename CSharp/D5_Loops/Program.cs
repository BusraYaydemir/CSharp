using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //! For Loop:

            Console.WriteLine("\n-----------------\nFor Loop: ");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("End of For Loop!\n----------------\n");

            //! While Loop:

            Console.WriteLine("\n-----------------\nWhile Loop: ");
            int k = 100;
            while (k >= 0)
            {
                Console.WriteLine(k);
                k--;
            }
            Console.WriteLine("End of While Loop!\n----------------\n");

            //! Do-While Loop:

            Console.WriteLine("\n-----------------\nDo-While Loop: ");
            int l = 100;
            do
            {
                Console.WriteLine(l);
                l--;
            } while (l >= 0);

            Console.WriteLine("End of Do-While Loop!\n----------------\n");

            //! Foreach Loop:

            Console.WriteLine("\n-----------------\nForeach Loop: ");
            string[] students = { "Engin", "Derin", "Salih" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("End of Foreach Loop!\n----------------\n");

            //! Write a program for understand a number is prime or not

            Console.WriteLine("\n----------------\nPRIME NUMBER FOUNDER\n\n");

            Console.Write("Give a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool result = true;

            if (number < 2)
            {
                result = false;
            } else if (number != 2 && number != 3)
            {
                for (int control = 2; control <= number / 2; control++)
                {
                    if(number%control == 0) {
                        result = false;
                        break;
                    }
                }
            }

            Console.WriteLine("{0} is {1} number", number, result?"a prime":"is not a prime");


            Console.ReadLine();

        }
    }
}
