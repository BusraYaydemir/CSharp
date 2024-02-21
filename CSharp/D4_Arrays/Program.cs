using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //! One Dimension Array:
            Console.WriteLine("One Dimension Array: \n");
            // Type 1:
            string[] students1 = new string[3];
            students1[0] = "Engin";
            students1[1] = "Derin";
            students1[2] = "Salih";

            // Type 2:
            string[] students2 = new string[3] { "Engin", "Derin", "Salih" };

            // Type 3:
            string[] students3 = new string[] { "Engin", "Derin", "Salih" };

            // Type 4:
            string[] students4 = { "Engin", "Derin", "Salih" };

            foreach (var student in students1)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\n----------------------\n");

            for (var i = 0; i <= students2.GetUpperBound(0); i++)
            {
                Console.WriteLine(students2[i]);
            }

            Console.WriteLine("\n----------------------\n\nMulti Dimension Array:\n");
            //! Multi Dimension Array:

            string[,] regions = new string[5, 3]
            {
                {
                    "İstanbul","İzmit","Balıkesir"
                },
                {
                    "Ankara","Konya","Kırıkkale"
                },
                {
                    "Antalya","Adana","Mersin"
                },
                {
                    "Rize","Trabzon","Samsun"
                },
                {
                    "İzmir","Muğla","Manisa"
                }
            };

            foreach (var region in regions)
            {
                Console.WriteLine(region);
            }

            Console.WriteLine("\n----------------------\n");

            for (var i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (var k = 0; k <= regions.GetUpperBound(1); k++)
                {
                    Console.WriteLine(regions[i,k]);
                }
            }


            Console.ReadLine();
        }
    }
}
