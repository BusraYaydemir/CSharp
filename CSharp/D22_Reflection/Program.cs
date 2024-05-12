using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace D22_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*todo 
             
             * Reflection: 
             
             * Reflection in software allows programs to inspect and modify their own structure and behavior at runtime, enabling dynamic and flexible programming techniques.
             
             * Sometimes the type of method we will create becomes clear at program run time, so we use reflection when we need to run the required method at program run time.
             */


            //todo Without Reflection 

            Console.WriteLine("------- Without Reflection -------");
            
            Math mathWithoutParameter1 = new Math();
            Math mathWithParameters1 = new Math(5,8);

            Console.WriteLine(mathWithoutParameter1.Add(2, 5));
            Console.WriteLine(mathWithParameters1.AddCtor());

            //todo With Reflection - Example 1

            Console.WriteLine("\n\n------- With Reflection - Example 1 -------");

            var type = typeof(Math);
            Math mathWithoutParameter2 = (Math)Activator.CreateInstance(type);
            Console.WriteLine(mathWithoutParameter2.Add(2, 5));

            Math mathWithParameters2 = (Math) Activator.CreateInstance(type, 5, 8);
            Console.WriteLine(mathWithParameters2.AddCtor());

            //todo With Reflection - Example 2

            Console.WriteLine("\n\n------- With Reflection - Example 2 -------");

            var instance = Activator.CreateInstance(type, 16,7);
            MethodInfo methodInfo = instance.GetType().GetMethod("AddCtor");
            var resultOfInvoke = methodInfo.Invoke(instance, null);
            Console.WriteLine(resultOfInvoke.ToString());

            //todo With Reflection - Example 3

            Console.WriteLine("\n\n------- With Reflection - Example 3 -------");

            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                var parameters = method.GetParameters();
                Console.WriteLine(method.Name);
                foreach (var parameter in parameters)
                {
                    var parameterName = parameter.Name;
                    Console.WriteLine(" - " + parameterName);

                }

                foreach (var attribute in method.GetCustomAttributes())
                {
                    var attributeName = attribute.GetType().Name;
                    Console.WriteLine(" # " + attributeName);
                }

                Console.WriteLine("\n");
            }


            Console.ReadLine();
        }
    }

    class Math
    {
        private int _number1;
        private int _number2;

        public Math(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        public Math()
        {
            
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        public int AddCtor()
        {
            return _number1 + _number2;
        }

        [ChangeMethodName("Multiple")]
        public int MultipleCtor()
        {
            return _number1 * _number2;
        }
    }

    class ChangeMethodNameAttribute : Attribute
    {
        public ChangeMethodNameAttribute(string name)
        {
            
        }
    }
}
