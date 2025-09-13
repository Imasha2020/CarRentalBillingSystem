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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            AddRental addForm = new AddRental();
            addForm.Show();
            this.Hide();
        }

        private void btnViewRentals_Click(object sender, EventArgs e)
        {
            ViewRental viewForm = new ViewRental();
            viewForm.Show();
        }

       

    }
}
