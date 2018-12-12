namespace Project.PLL
{
    partial class Book_A_Service
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.Price = new MetroFramework.Controls.MetroTextBox();
            this.quantity = new MetroFramework.Controls.MetroTextBox();
            this.ServiceName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(179, 107);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(186, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(179, 165);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(186, 23);
            this.Price.TabIndex = 1;
            this.Price.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(179, 228);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(186, 23);
            this.quantity.TabIndex = 2;
            // 
            // ServiceName
            // 
            this.ServiceName.AutoSize = true;
            this.ServiceName.Location = new System.Drawing.Point(79, 107);
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(93, 19);
            this.ServiceName.TabIndex = 3;
            this.ServiceName.Text = "Service Name:";
            this.ServiceName.Click += new System.EventHandler(this.ServiceName_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(121, 169);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Price:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(101, 228);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Quantity:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(225, 299);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Submit";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Book_A_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 369);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ServiceName);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "Book_A_Service";
            this.Text = "Book_A_Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox Price;
        private MetroFramework.Controls.MetroTextBox quantity;
        private MetroFramework.Controls.MetroLabel ServiceName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}