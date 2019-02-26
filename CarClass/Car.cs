using System;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{
    class Car
    {
        public float fuelLevel { get; set; }
        const float maxFuelLevel = 13;

        public Car()
        {
            //Random random = new Random();

            fuelLevel = new Random().Next(1, 14);

            //fuelLevel = random.Next(1, 14);
        }

        public bool AddFuel(float additionalFuel)
        {
            if (additionalFuel > (maxFuelLevel - fuelLevel))
            {
                return false;
            }
            else
            {
                fuelLevel += additionalFuel;
                return true;
            }
        }

        public float FullFuel()
        
{
            float fillerUp = maxFuelLevel - fuelLevel;
            fuelLevel = maxFuelLevel;
            return fillerUp;
        }
    }
}
