using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBillingSystem
{
    public class FuelDecorator : RentalDecorator
    {
        public FuelDecorator(Rental rental) : base(rental) 
        { 
        }

        public override double GetCost()
        {
            return base.GetCost() + 2000;
        }
    }
}
