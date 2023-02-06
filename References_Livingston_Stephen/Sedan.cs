using System;
using System.Collections.Generic;
using System.Text;

namespace References_Livingston_Stephen
{
    class Sedan : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LiscensePlate { get; private set; }

        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LiscensePlate = "GCTC-06";
        }

        public void Stringify()
        {
            Console.WriteLine($"The Sedan is travleing at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LiscensePlate}.");   
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
