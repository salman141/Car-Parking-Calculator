using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking_Calculator
{
    public class CarFee : ParkingFee
    {
        public CarFee()
        {
            MinimumFee = 4.0D;
            MaximumFee = 20.00D;
            AdditionalFeePerHour = 1.00D;
        }
    }
}
