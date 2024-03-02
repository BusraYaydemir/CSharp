using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10_InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWork[] workers = new IWork[3]
            {
                new Worker(),
                new Robot(),
                new Manager()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eaters = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eater in eaters)
            {
                eater.Eat();
            }

            IGetSalary[] salaryGetters = new IGetSalary[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var salaryGetter in salaryGetters)
            {
                salaryGetter.GetSalary();
            }

            Console.ReadLine();
        }
    }

    interface IWork
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }

    class Worker : IWork, IEat, IGetSalary
    {
        public void Eat()
        {
            
        }

        public void GetSalary()
        {
            
        }

        public void Work()
        {
            
        }
    }

    class Manager : IWork, IEat, IGetSalary
    {
        public void Eat()
        {
            
        }

        public void GetSalary()
        {
            
        }

        public void Work()
        {
            
        }
    }

    class Robot : IWork
    {
        public void Work()
        {
            
        }
    }
}
