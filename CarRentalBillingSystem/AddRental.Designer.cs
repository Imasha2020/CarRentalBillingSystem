namespace CarRentalBillingSystem
{
    partial class AddRental
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GPS = new System.Windows.Forms.TextBox();
            this.BabySeat = new System.Windows.Forms.TextBox();
            this.Fuel = new System.Windows.Forms.TextBox();
            this.AdditionalDriver = new System.Windows.Forms.TextBox();
            this.Insurance = new System.Windows.Forms.TextBox();
            this.AddRentalbtn = new System.Windows.Forms.Button();
            this.BackToHomeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(234, 47);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(361, 22);
            this.CustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle Type";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(254, 110);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Economy";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(375, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SUV";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(463, 110);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 20);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Luxury";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(234, 173);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 22);
            this.StartDate.TabIndex = 7;
            this.StartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "End date";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(234, 216);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(200, 22);
            this.EndDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "GPS Navigation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Baby Seat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Additional Driver";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fuel Payment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Insurance";
            // 
            // GPS
            // 
            this.GPS.Location = new System.Drawing.Point(239, 267);
            this.GPS.Name = "GPS";
            this.GPS.Size = new System.Drawing.Size(356, 22);
            this.GPS.TabIndex = 15;
            this.GPS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BabySeat
            // 
            this.BabySeat.Location = new System.Drawing.Point(239, 311);
            this.BabySeat.Name = "BabySeat";
            this.BabySeat.Size = new System.Drawing.Size(356, 22);
            this.BabySeat.TabIndex = 16;
            // 
            // Fuel
            // 
            this.Fuel.Location = new System.Drawing.Point(239, 350);
            this.Fuel.Name = "Fuel";
            this.Fuel.Size = new System.Drawing.Size(356, 22);
            this.Fuel.TabIndex = 17;
            // 
            // AdditionalDriver
            // 
            this.AdditionalDriver.Location = new System.Drawing.Point(239, 393);
            this.AdditionalDriver.Name = "AdditionalDriver";
            this.AdditionalDriver.Size = new System.Drawing.Size(356, 22);
            this.AdditionalDriver.TabIndex = 18;
            // 
            // Insurance
            // 
            this.Insurance.Location = new System.Drawing.Point(239, 432);
            this.Insurance.Name = "Insurance";
            this.Insurance.Size = new System.Drawing.Size(356, 22);
            this.Insurance.TabIndex = 19;
            // 
            // AddRentalbtn
            // 
            this.AddRentalbtn.Location = new System.Drawing.Point(127, 489);
            this.AddRentalbtn.Name = "AddRentalbtn";
            this.AddRentalbtn.Size = new System.Drawing.Size(180, 23);
            this.AddRentalbtn.TabIndex = 20;
            this.AddRentalbtn.Text = "ADD RENTAL";
            this.AddRentalbtn.UseVisualStyleBackColor = true;
            // 
            // BackToHomeBtn
            // 
            this.BackToHomeBtn.Location = new System.Drawing.Point(405, 489);
            this.BackToHomeBtn.Name = "BackToHomeBtn";
            this.BackToHomeBtn.Size = new System.Drawing.Size(180, 23);
            this.BackToHomeBtn.TabIndex = 21;
            this.BackToHomeBtn.Text = "BACK TO HOME";
            this.BackToHomeBtn.UseVisualStyleBackColor = true;
            // 
            // AddRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.BackToHomeBtn);
            this.Controls.Add(this.AddRentalbtn);
            this.Controls.Add(this.Insurance);
            this.Controls.Add(this.AdditionalDriver);
            this.Controls.Add(this.Fuel);
            this.Controls.Add(this.BabySeat);
            this.Controls.Add(this.GPS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label1);
            this.Name = "AddRental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GPS;
        private System.Windows.Forms.TextBox BabySeat;
        private System.Windows.Forms.TextBox Fuel;
        private System.Windows.Forms.TextBox AdditionalDriver;
        private System.Windows.Forms.TextBox Insurance;
        private System.Windows.Forms.Button AddRentalbtn;
        private System.Windows.Forms.Button BackToHomeBtn;
    }
}