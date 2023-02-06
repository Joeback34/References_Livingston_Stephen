using System;
using System.Collections.Generic;
using System.Text;

namespace References_Livingston_Stephen
{   /// <summary>
/// implements the IAutomobile interface and adds get and set properties
/// </summary>
    class Sedan : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LiscensePlate { get; private set; }
        
        // Constructor that takes doube parameter.
        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LiscensePlate = "GCTC-06";
        }

        // creates method that prins to the console.
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is travleing at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LiscensePlate}.");   
        }
        
        // implements methods that increase and decrease the speed when called.
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
