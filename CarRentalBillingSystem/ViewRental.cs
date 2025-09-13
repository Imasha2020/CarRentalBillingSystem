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
    public partial class ViewRental : Form
    {
        public ViewRental()
        {
            InitializeComponent();
        }

        private void ViewRentals_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Customer count: " + CustomerList.Customers.Count); // 🧪 Debug

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CustomerList.Customers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
            
        }
    }
}
