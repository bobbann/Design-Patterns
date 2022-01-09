using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Assignment.Observer;

namespace Design_Patterns_Assignment
{
    class Observer2
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");

            IBM ibm = new IBM("IBM", 120.00);
            ibm.AddObserver(new Investor("Eric"));
            ibm.AddObserver(new Investor("Jakob"));

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            Console.ReadKey();
        }
    }
}
