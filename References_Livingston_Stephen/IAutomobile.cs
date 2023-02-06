using System;
using System.Collections.Generic;
using System.Text;

namespace References_Livingston_Stephen
{   /// <summary>
/// Adds Properties and defines a void method called Stringify into an interface. 
/// </summary>
    interface IAutomobile
    {

        public double Speed { get; }

        int Wheels { get; }

        string LiscensePlate { get; }

        public void Stringify();

    }
}
