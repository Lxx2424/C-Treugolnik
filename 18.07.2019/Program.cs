using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._07._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle rambo = new Bicycle("Rambo");
            Bicycle rambo2 = new Bicycle("Rambo2");
            Car carl = new Car("Bmw");
            Console.WriteLine(rambo.name+" "+carl.name+" "+rambo2.name);
            carl.StartingEngine();
        }
    }
    class Transport
    {
        public string name;
        public Transport(string name)
        {
            this.name = name;
        }
        public void StartingEngine()
        {
            Console.WriteLine("Engine Started");
        }
    }
    class Bicycle:Transport
    {
        public Bicycle(string name) : base(name)
        {

        }
    }
    class Car : Transport
    {
        public Car(string name): base(name)
        {
        }
    }
}

