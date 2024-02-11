using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if you want to show something in console, we use Console.WriteLine(); method
            Console.WriteLine("Hello World!");

            //! Value Types: 

            // integer
            int intNumber = 1000000000;
            Console.WriteLine("int: {0}", intNumber);

            // short
            short shortNumber = 10000;
            Console.WriteLine("short: {0}", shortNumber);

            // long
            long longNumber = 1000000000000000000;
            Console.WriteLine("long: {0}", longNumber);

            // byte
            byte byteNumber = 100;
            Console.WriteLine("byte: {0}", byteNumber);

            // bool
            bool boolType = true;
            Console.WriteLine("bool: {0}", boolType);

            // char
            char charType = 'A';
            Console.WriteLine("char: {0}", charType);

            // decimal
            decimal decimalType = 10.2M;
            Console.WriteLine("decimal: {0}", decimalType);

            // double
            double doubleType = 10.2;
            Console.WriteLine("double: {0}", doubleType);

            
            //enum
            Console.WriteLine("Days.Wednesday: {0} --- (int)Days.Wednesday: {1} --- (int)Days.Saturday: {2}", Days.Wednesday, (int)Days.Wednesday, (int)Days.Saturday);

            // var
            var varType = 10; // var type was int because of 10
            varType = 'A'; // According to ASCII vartype updated as 65, because its type is int now
            // But we cannot say that varType = "A", because we cannot convert String to int
            Console.WriteLine("var: {0}", varType);


            // for taking input from user, we use Console.ReadLine(); method
            Console.ReadLine();
        }

        // enum
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday=10, Friday=20, Saturday, Sunday
        };
    }
}
