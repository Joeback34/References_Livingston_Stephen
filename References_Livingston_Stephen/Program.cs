using System;

namespace References_Livingston_Stephen
{
    class Program
    {   
        static void Main(string[] args)
        {  
            // Delcares new object IAutomobile object and assigns it to Sedan.
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            Sedan myOtherSedan = new Sedan(0);
            
            // Prints the speed and compares the two objects
            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            // Prints the speed and compares the two objects
            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            // Creates object Truck.
            Truck myTruck = new Truck(50, 500, "MyTrUck");
            
            // Calls stringify method and descibes automobiles.
            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();
        }
    }
}
