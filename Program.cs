using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Car Ford = new Car();
            Car Opel = new Car();
            Ford.model = "Mustang";
            Opel.model = "Astra";
            Ford.color = "red";
            Opel.color = "white";
            Ford.year = 1969;
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }
}
