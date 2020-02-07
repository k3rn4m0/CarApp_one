using System;

namespace ConsoleApp1
{
    class Car
    {
        public string color;
        public string model;
        public int maxSpeed;
        public int year;

        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Car myObj1 = new Car();

            myObj.color = "red";
            myObj.maxSpeed = 200;

            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj.maxSpeed);
            myObj.fullThrottle();
        }        
    }
}
