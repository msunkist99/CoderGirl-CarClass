using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine($"Current fuel level is {car.fuelLevel} gallons");

            Console.ReadLine();

            Console.WriteLine("Add some gas to the car");
            float additionalFuel = float.Parse( Console.ReadLine());

            Console.WriteLine($"You added gas to the car ---- {car.AddFuel(additionalFuel)}");

            Console.WriteLine($"You have {car.fuelLevel} gallons of gas");

            Console.WriteLine($"We added {car.FullFuel()} to fill the gas tank");

            Console.ReadLine();
        }
    }
}
