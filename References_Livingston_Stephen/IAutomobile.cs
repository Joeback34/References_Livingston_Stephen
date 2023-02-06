using System;
using System.Collections.Generic;
using System.Text;

namespace References_Livingston_Stephen
{
    interface IAutomobile
    {

        public double Speed { get; }

        int Wheels { get; }

        string LiscensePlate { get; }

        public void Stringify();

    }
}
