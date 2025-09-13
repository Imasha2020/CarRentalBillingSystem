using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBillingSystem
{
    public class BabySeatDecorator : RentalDecorator 
    {
        public BabySeatDecorator(Rental rental) : base(rental)
        { 
        }

        public override double GetCost()
        {
            return base.GetCost() + 600.00;
        }
    }
}
