using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingFee bike = new BikeFee();
            ParkingFee car = new CarFee();
            ParkingFee bus = new BusFee();
            Customer customers = new Customer();
            Vehicle vehic1 = new Vehicle();


           
            Console.WriteLine("");


            Console.WriteLine("Enter vehicle of customer 1 :");
            string vehic = Console.ReadLine();

            
            if (vehic1.Bike == vehic)
            {
                Console.WriteLine("Additional Charges for parking a bike after 3 hours is: $" + bike.CheckParkingHours());
            }
                
            if(vehic1.Car == vehic)
            {
                Console.WriteLine("Additional Charges for parking a car after 3 hours is: $" + car.CheckParkingHours());
            }

            if (vehic1.Bus == vehic)
            {
                Console.WriteLine("Additional Charges for parking a bus after 3 hours is: $" + bus.CheckParkingHours());
            }

            Console.WriteLine("");

            Console.WriteLine("Enter vehicle of customer 2 :");
            string vehic2 = Console.ReadLine();


            if (vehic1.Bike == vehic2)
            {
                Console.WriteLine("Additional Charges for parking a bike after 3 hours is: $" + bike.CheckParkingHours());
            }

            if (vehic1.Car == vehic2)
            {
                Console.WriteLine("Additional Charges for parking a car after 3 hours is: $" + car.CheckParkingHours());
            }

            if (vehic1.Bus == vehic2)
            {
                Console.WriteLine("Additional Charges for parking a bus after 3 hours is: $" + bus.CheckParkingHours());
            }

            Console.WriteLine("");

            Console.WriteLine("Enter vehicle of customer 3 :");
            string vehic3 = Console.ReadLine();


            if (vehic1.Bike == vehic3)
            {
                Console.WriteLine("Additional Charges for parking a bike after 3 hours is: $" + bike.CheckParkingHours());
            }

            if (vehic1.Car == vehic3)
            {
                Console.WriteLine("Additional Charges for parking a car after 3 hours is: $" + car.CheckParkingHours());
            }

            if (vehic1.Bus == vehic3)
            {
                Console.WriteLine("Additional Charges for parking a bus after 3 hours is: $" + bus.CheckParkingHours());
            }













           /* Console.WriteLine("Enter Vehicle: ");
            string vehicles = Console.ReadLine();

            if(vehicles == "Bike" || vehicles == "bike")
            {
                Console.WriteLine("A person parked a Bike: $" + bike.MinimumFee);
                Console.WriteLine("Additional Charges for parking a bike after 3 hours is: $" + bike.CheckParkingHours());
            }

            if (vehicles == "Car" || vehicles == "car")
            {
                Console.WriteLine("A person parked Car: $" + car.MinimumFee);
                Console.WriteLine("Additional Charges for parking a car after 3 shours is: $" + car.CheckParkingHours());
            }

            if (vehicles == "Bus" || vehicles == "bus")
            {
                Console.WriteLine("A person parked Bus: $" + bus.MinimumFee);
                Console.WriteLine("Additional Charges for parking a bus after 3 hours is: $" + bus.CheckParkingHours());
            }
            
            
            
            Console.WriteLine(""); */
                     

        }

        
    }
}
