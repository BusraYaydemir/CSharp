using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D17_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExceptionsIntro();

            ExceptionsIntro2();

            HandleExceptions(() =>
            {
                Find();
            });

            Console.ReadLine();
        }

        // Action means it is a method but there is no any parameter and return value so void example: void Find()
        private static void HandleExceptions(Action action)
        {
            try
            {
                action.Invoke(); // Run
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("There is an error!!!\nIndex Out Of Range Exception");
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("There is an error!!!\nDivide By Zero Exception");
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine("There is an error!!!\nRecord Not Found Exception");
            }
            catch (Exception exception)
            {
                Console.WriteLine("There is an error!!!\nBut it is not Divide By Zero Exception or Index Out Of Range Exception or Record Not Found Exception");
            }
        }

        private static void ExceptionsIntro2()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string>() { "Name1", "Name2", "Name3" };

            if (!students.Contains("Name4"))
            {
                throw new RecordNotFoundException("Record is not Found!!");
            }
            else
            {
                Console.WriteLine("Record is Found");
            }
        }

        private static void ExceptionsIntro()
        {
            try
            {
                string[] students = new string[3] { "Name1", "Name2", "Name3" };
                students[3] = "Name4";

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("There is an error!!!\nIndex Out Of Range Exception");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("There is an error!!!\nDivide By Zero Exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error!!!\nBut it is not Divide By Zero Exception or Index Out Of Range Exception");
            }
        }
    }
}
