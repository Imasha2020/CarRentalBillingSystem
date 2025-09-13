using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBillingSystem
{
    public class GPSDecorator : RentalDecorator
    {
        public GPSDecorator(Rental rental) : base(rental)
        {

        }

        public override double GetCost() {
            return base.GetCost() + 800.00;
        }
    }
}
