using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// implements IAutomobile interface into the Truck class and adds private setters to the properties.
/// </summary>
namespace References_Livingston_Stephen
{
    class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LiscensePlate { get; private set; }

        public double weight { get; }

        /// <summary>
        ///  Constructor that takes three parameters and sets each parameter respectivley.
        /// </summary>
        /// <param name="speedParam"></param>
        /// <param name="weightParam"></param>
        /// <param name="liscenseNum"></param>
        public Truck(double speedParam, double weightParam, string liscenseNum)
        {
            Speed = speedParam;
            weight = weightParam;
            LiscensePlate = liscenseNum;

            if(weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        /// <summary>
        /// implements methods that increase and decrease the speed when called.
        /// </summary>
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LiscensePlate}!");
        }
        public void IncreaseSpeed()
        {
            Speed += 5;

        }
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
