namespace Project.PLL
{
    partial class AddService
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
            this.Sname = new MetroFramework.Controls.MetroTextBox();
            this.Price = new MetroFramework.Controls.MetroTextBox();
            this.Description = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Available = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Sname
            // 
            this.Sname.Location = new System.Drawing.Point(142, 99);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(142, 23);
            this.Sname.TabIndex = 0;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(142, 163);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(142, 23);
            this.Price.TabIndex = 1;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(142, 226);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(142, 23);
            this.Description.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Service Name:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(95, 167);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Price:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(59, 226);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Description:";
            // 
            // Available
            // 
            this.Available.FormattingEnabled = true;
            this.Available.ItemHeight = 23;
            this.Available.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Available.Location = new System.Drawing.Point(142, 284);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(121, 29);
            this.Available.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel4.Location = new System.Drawing.Point(71, 284);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Available:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(209, 333);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Submit";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 379);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.Available);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Sname);
            this.Name = "AddService";
            this.Text = "Add a New Service";
            this.Load += new System.EventHandler(this.AddService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox Sname;
        private MetroFramework.Controls.MetroTextBox Price;
        private MetroFramework.Controls.MetroTextBox Description;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox Available;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}