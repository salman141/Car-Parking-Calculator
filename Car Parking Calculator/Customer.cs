using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking_Calculator
{
    class Customer
    {
        public string customer1 = "Customer1";
        public string customer2 = "Customer2";
        public string customer3 = "Customer3";

        public string FeeSlip()
        {
            Console.WriteLine("If you park a bike, the charges will be $2.00");
            Console.WriteLine("If you park a car, the charges will be $4.00");
            Console.WriteLine("If you park a bus, the charges will be $6.00");
            return "customer";
        }

    }
}
