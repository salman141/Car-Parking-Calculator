using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking_Calculator
{
    public class BikeFee : ParkingFee
    {
        public BikeFee()
        {
            MinimumFee = 2.00D;
            MaximumFee = 10.00D;
            AdditionalFeePerHour = 0.50D;
        }
    }
}
