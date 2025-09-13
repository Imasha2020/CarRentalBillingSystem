using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBillingSystem
{
    public class Customer
    {
        public string Name { get; set; }
        public string VehicleType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public double FinalBill { get; set; }
    }
}
