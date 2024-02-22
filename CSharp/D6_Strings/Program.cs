using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string city = "İstanbul";

            //! String is a char array
            foreach (char item in city) { 
                Console.WriteLine(item);
            }

            //! For collect strings, we can use format method. It is not use memory 
            Console.WriteLine(String.Format("{0} {1}", city, "İzmir"));

            string sentence = "Today the weather is very good!";

            // length of the string
            var result = sentence.Length;
            Console.WriteLine(result);

            // create a clone the string, so same content. ıf the real sentence changes, clone sentence WILL NOT be change
            var result2 = sentence.Clone();
            Console.WriteLine(result2);

            // is the string starts or ends with anything
            var result3 = sentence.StartsWith("Today");
            Console.WriteLine(result3);
            var result4 = sentence.EndsWith("M");
            Console.WriteLine(result4);

            // find the index of anything
            var result5 = sentence.IndexOf("wea");
            Console.WriteLine(result5);
            var result6 = sentence.LastIndexOf(" ");
            Console.WriteLine(result6);

            // add to string another string
            var result7 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result7);

            // crop to string
            var result8 = sentence.Substring(3);
            Console.WriteLine(result8);
            var result9 = sentence.Substring(5, 9);
            Console.WriteLine(result9);

            // lower or upper string
            var result10 = sentence.ToLower();
            Console.WriteLine(result10);
            var result11 = sentence.ToUpper();
            Console.WriteLine(result11);

            // replace a character
            var result12 = sentence.Replace(" ", "-");
            Console.WriteLine(result12);

            // delete after from a index
            var result13 = sentence.Remove(3);
            Console.WriteLine(result13);
            var result14 = sentence.Remove(3,6);
            Console.WriteLine(result14);

            Console.ReadLine();
        }
    }
}
