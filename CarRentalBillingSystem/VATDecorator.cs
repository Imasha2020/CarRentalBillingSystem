using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBillingSystem
{
    public class VATDecorator : RentalDecorator
    {
        private double _baseCost;
        public VATDecorator(Rental rental , double baseCost) : base(rental) {
            _baseCost = baseCost;
        }

        public override double GetCost()
        {
            return base.GetCost() + (_baseCost * 0.12);
        }
    }
}
