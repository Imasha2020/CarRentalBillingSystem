using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBillingSystem
{
    public abstract class RentalDecorator : Rental
    {
        protected Rental rental;

        public RentalDecorator(Rental rental) {
            this.rental = rental;
        }

        public virtual double  GetCost() {
            return rental.GetCost();
        }
    }
}
