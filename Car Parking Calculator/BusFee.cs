using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking_Calculator
{
    public class BusFee : ParkingFee
    {
        public BusFee()
        {
            MinimumFee = 6.00D;
            MaximumFee = 30.00D;
            AdditionalFeePerHour = 1.50D;
        }
    }
}
