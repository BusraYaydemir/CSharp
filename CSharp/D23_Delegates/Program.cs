using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace D23_Delegates
{
    public delegate void Delegate1();
    public delegate void Delegate2(string text);
    public delegate int Delegate3(int number1, int number2);
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomMethods randomMethods = new RandomMethods();

            // Example 1 -  void an without parameters
            Delegate1 delegate1 = randomMethods.ShowHello;

            Console.WriteLine("\nExample 1 - State 1 : ");
            delegate1();

            delegate1 += randomMethods.ShowAlert;

            Console.WriteLine("\nExample 1 - State 2 : ");
            delegate1();

            delegate1 -= randomMethods.ShowHello;

            Console.WriteLine("\nExample 1 - State 3 : ");
            delegate1();

            // Example 2 -  void an with parameters
            Delegate2 delegate2 = randomMethods.HelloText;

            Console.WriteLine("\nExample 2 - State 1 : ");
            delegate2("Text");

            delegate2 += randomMethods.AlertText;

            Console.WriteLine("\nExample 2 - State 2 : ");
            delegate2("Text");

            delegate2 -= randomMethods.HelloText;

            Console.WriteLine("\nExample 2 - State 3 : ");
            delegate2("Text");

            // Example 3 -  void an with parameters
            Delegate3 delegate3 = randomMethods.Add;

            Console.WriteLine("\nExample 3 - State 1 : \n" + delegate3(2, 3));
            
            delegate3 += randomMethods.Multiple;

            Console.WriteLine("\nExample 3 - State 2 : \n" + delegate3(2, 3));
            
            delegate3 -= randomMethods.Multiple;

            Console.WriteLine("\nExample 3 - State 3 : \n" + delegate3(2, 3));

            // Example 4 - action

            Console.WriteLine("\nExample 4 - State 1 : \n");

            HandleException(() =>
            {
                randomMethods.DivideByZero(1);
            });

            // Example 5 - Func

            Func<int, int, int> addFunction = Add; // Parameters int int Return int

            Console.WriteLine("\nExample 4 - State 1 : \n" + addFunction(2, 4));

            Func<int> generateRandomNumber = delegate () // Parameter no Return int
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine("\nExample 4 - State 2 : \n" + generateRandomNumber());

            Thread.Sleep(1000);

            Func<int> generateRandomNumber2 = () => new Random().Next(1,100);
            Console.WriteLine("\nExample 4 - State 3 : \n" + generateRandomNumber2());


            Console.ReadLine();
        }

        private static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();

            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine("Exception Text 1");

            }
            catch (OutOfMemoryException ex2)
            {
                Console.WriteLine("Exception Text 2");

            }
            catch (Exception ex3)
            {
                Console.WriteLine("Exception Text 3");
            }
        }

    }

    public class RandomMethods
    {
        public void ShowHello()
        {
            Console.WriteLine("hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("be careful");
        }

        public void HelloText(string text)
        {
            Console.WriteLine(text);
        }

        public void AlertText(string text)
        {
            Console.WriteLine(text);
        }

        public int Add(int number1 , int number2)
        {
            return number1 + number2;
        }

        public int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        public int DivideByZero(int number1)
        {
            return number1/0;
        }

    }
}
