using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalBillingSystem
{
    public partial class AddRental : Form
    {
        public AddRental()
        {
            InitializeComponent();
            //Home = home;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRentalbtn_Click(object sender, EventArgs e)
        {
            // 1. Get user input
            string name = CustomerName.Text.Trim();
            string vehicleType = "";

            if (radioButton1.Checked)
                vehicleType = "Economy";
            else if (radioButton2.Checked)
                vehicleType = "SUV";
            else if (radioButton3.Checked)
                vehicleType = "Luxury";

            DateTime start = StartDate.Value;
            DateTime end = EndDate.Value;

            int rentalDays = (end - start).Days + 1;

            // 2. Base rental
            Rental rental = new BaseRental(vehicleType, rentalDays);
            double baseCharge = rental.GetCost();

            // 3. Apply selected services (decorators)
            if (checkBox1.Checked)
                rental = new GPSDecorator(rental);

            if (checkBox2.Checked)
                rental = new BabySeatDecorator(rental);

            if (checkBox3.Checked)
                rental = new AdditionalDriverDecorator(rental);

            if (checkBox4.Checked)
                rental = new FuelDecorator(rental);

            if (checkBox5.Checked)
                rental = new InsuranceDecorator(rental);

            // 4. Apply VAT (only on base charge)
            rental = new VATDecorator(rental , baseCharge);

            // 5. Calculate final bill
            double finalBill = rental.GetCost();

            // 6. Save customer
            Customer customer = new Customer
            {
                Name = name,
                VehicleType = vehicleType,
                startDate = start,
                endDate = end,
                FinalBill = finalBill
            };

            CustomerList.Customers.Add(customer);

            MessageBox.Show("Rental Added Successfully!");

        }

        private void BackToHomeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
