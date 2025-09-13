using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalBillingSystem
{
    public  class BaseRental : Rental
    {
        private double baseRate;
        private int rentalDays;

        public BaseRental(string vehicleType, int days)
        {
            rentalDays = days;

            if (vehicleType.ToLower() == "economy")
            {
                baseRate = 50000.00;
            }
            else if (vehicleType.ToLower() == "suv")
            {
                baseRate = 8000.00;
            }
            else if (vehicleType.ToLower() == "luxury")
            {
                baseRate = 15000.00;
            }
            else
            {
                baseRate = 0.00;
            }
        }

            public  double GetCost() {
            return baseRate * rentalDays;
        }
        }
    }

