namespace Project.PLL
{
    partial class EditService
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Available = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.Description = new MetroFramework.Controls.MetroTextBox();
            this.Price = new MetroFramework.Controls.MetroTextBox();
            this.Sname = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(268, 345);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 42;
            this.metroButton1.Text = "Submit";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel6.Location = new System.Drawing.Point(151, 270);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 41;
            this.metroLabel6.Text = "Available:";
            // 
            // Available
            // 
            this.Available.FormattingEnabled = true;
            this.Available.ItemHeight = 23;
            this.Available.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Available.Location = new System.Drawing.Point(222, 270);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(121, 29);
            this.Available.TabIndex = 40;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(139, 212);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(77, 19);
            this.metroLabel7.TabIndex = 39;
            this.metroLabel7.Text = "Description:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(175, 153);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(41, 19);
            this.metroLabel8.TabIndex = 38;
            this.metroLabel8.Text = "Price:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(123, 85);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(93, 19);
            this.metroLabel9.TabIndex = 37;
            this.metroLabel9.Text = "Service Name:";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(222, 212);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(142, 23);
            this.Description.TabIndex = 36;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(222, 149);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(142, 23);
            this.Price.TabIndex = 35;
            // 
            // Sname
            // 
            this.Sname.Location = new System.Drawing.Point(222, 85);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(142, 23);
            this.Sname.TabIndex = 34;
            // 
            // EditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 391);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.Available);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Sname);
            this.Name = "EditService";
            this.Text = "EditService";
            this.Load += new System.EventHandler(this.EditService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox Available;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox Description;
        private MetroFramework.Controls.MetroTextBox Price;
        private MetroFramework.Controls.MetroTextBox Sname;
    }
}