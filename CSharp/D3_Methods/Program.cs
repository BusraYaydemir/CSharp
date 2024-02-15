using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(); // Added!

            int result = Add(5, 6); 
            Console.WriteLine(result); // 11

            int result2 = Add(2); 
            Console.WriteLine(result2); // 32

            int number1 = 130; //! We SHOULD define in here
            int number2 = 90;
            Console.WriteLine(RefMethod(ref number1, number2)); // 100
            Console.WriteLine(number1); // 10

            int number3 = 140; //! We CAN define in here, it is NOT NECCESSARY
            int number4 = 70;
            Console.WriteLine(OutMethod(out number3, number4)); // 80
            Console.WriteLine(number3); // 10

            Console.WriteLine(OverloadMethod(1,2)); // 3
            Console.WriteLine(OverloadMethod(1,2,3)); // 6

            Console.WriteLine(ParamsMethod(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            Console.ReadLine();
        }

        //! Non-Parameter Method
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //! Parameter Method
        // We can add default paramater: default parameters should be in the end of the list of the parameter
        static int Add(int number1 = 20, int number2 = 30)
        {
            return number1 + number2;
        }

        //! Ref Keyword
        // We use the "ref" keyword for using value type variable as referance type variable.
        // So; if the variable change in the method, we use that variable also after that this method.
        static int RefMethod(ref int number1, int number2)
        {
            number1 = 10; //! We CAN define in here, it is NOT NECESSARY
            return number1 + number2;
        }

        //! Out Keyword
        // We use the "out" keyword for using value type variable as referance type variable.
        // So; if the variable change in the method, we use that variable also after that this method.
        static int OutMethod(out int number3, int number4)
        {
            number3 = 10; //! We SHOULD define in here
            return number3 + number4;
        }

        //! Method Overloading
        // Names of the methods are same, but the parameter amount is different to each other.
        static int OverloadMethod(int number1, int number2)
        {
            return number1 + number2;
        }

        static int OverloadMethod(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        //! Methods with Params Parameter
        // We can enter the parameter as much as we want
        static int ParamsMethod(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }
    }
}
