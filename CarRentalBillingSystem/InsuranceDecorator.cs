using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBillingSystem
{
    public class InsuranceDecorator : RentalDecorator
    {
        public InsuranceDecorator(Rental rental) : base(rental)
        { 
        }

        public override double GetCost()
        {
            return base.GetCost() + 3000.00;
        }
    }
}
