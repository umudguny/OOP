﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager(),
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }
        interface IWorker
        {
            void Work();
           
        }
        //SOLID, Interface Segregation
        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void GetSalary();
        }



        class Manager : IWorker, IEat, ISalary// bir class birden fazla interface implement edebilir
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        class Worker : IWorker, ISalary, IEat
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
