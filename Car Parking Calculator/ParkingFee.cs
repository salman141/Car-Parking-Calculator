using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking_Calculator
{
    public abstract class ParkingFee
    {
        protected double MinimumFee;
        protected double MaximumFee;
        protected double AdditionalFeePerHour;

       /* public double CalculateTotalFee(int parkingHours)
        {
            if (parkingHours <= 3)
            {
                return MinimumFee;
            }
            else
            {
                double totalFees = MinimumFee + (AdditionalFeePerHour * (parkingHours - 3));

                if (totalFees > MaximumFee)
                {
                    return MaximumFee;
                }
                else
                {
                    return totalFees;
                }
            }
        } */

        public double CheckParkingHours()
        {
            Console.WriteLine("Enter Parking Hours : ");
            int parkingHours = Convert.ToInt32(Console.ReadLine());

            if(parkingHours <= 3)
            {
                return MinimumFee;
            }
            else
            {
                double totalFees = MinimumFee + (AdditionalFeePerHour * (parkingHours - 3));
                if(totalFees > MaximumFee)
                {
                    return MaximumFee;
                }
                else
                {
                    return totalFees;
                }
            }
        }
    }
}
