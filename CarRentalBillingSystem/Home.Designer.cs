namespace CarRentalBillingSystem
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddRental = new System.Windows.Forms.Button();
            this.btnViewRentals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRental
            // 
            this.btnAddRental.Location = new System.Drawing.Point(209, 26);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(128, 41);
            this.btnAddRental.TabIndex = 0;
            this.btnAddRental.Text = "ADD RENTAL";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // btnViewRentals
            // 
            this.btnViewRentals.Location = new System.Drawing.Point(427, 26);
            this.btnViewRentals.Name = "btnViewRentals";
            this.btnViewRentals.Size = new System.Drawing.Size(128, 41);
            this.btnViewRentals.TabIndex = 1;
            this.btnViewRentals.Text = "VIEW RENTALS";
            this.btnViewRentals.UseVisualStyleBackColor = true;
            this.btnViewRentals.Click += new System.EventHandler(this.btnViewRentals_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentalBillingSystem.Properties.Resources.free_car_rental_background_0bkxd;
            this.ClientSize = new System.Drawing.Size(881, 494);
            this.Controls.Add(this.btnViewRentals);
            this.Controls.Add(this.btnAddRental);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Button btnViewRentals;
    }
}