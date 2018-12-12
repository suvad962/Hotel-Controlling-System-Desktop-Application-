namespace Project.PLL
{
    partial class Add_Rooms
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Room_Type = new MetroFramework.Controls.MetroComboBox();
            this.Room_Price = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Nob = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.level = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Extra_bedY = new MetroFramework.Controls.MetroRadioButton();
            this.E_bedN = new MetroFramework.Controls.MetroRadioButton();
            this.Submit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Type:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // Room_Type
            // 
            this.Room_Type.FormattingEnabled = true;
            this.Room_Type.ItemHeight = 23;
            this.Room_Type.Items.AddRange(new object[] {
            "V.I.P",
            "Delux",
            "Suite"});
            this.Room_Type.Location = new System.Drawing.Point(109, 105);
            this.Room_Type.Name = "Room_Type";
            this.Room_Type.Size = new System.Drawing.Size(121, 29);
            this.Room_Type.TabIndex = 2;
            // 
            // Room_Price
            // 
            this.Room_Price.Location = new System.Drawing.Point(109, 160);
            this.Room_Price.Name = "Room_Price";
            this.Room_Price.Size = new System.Drawing.Size(121, 23);
            this.Room_Price.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(63, 160);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Price:";
            // 
            // Nob
            // 
            this.Nob.FormattingEnabled = true;
            this.Nob.ItemHeight = 23;
            this.Nob.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Nob.Location = new System.Drawing.Point(109, 208);
            this.Nob.Name = "Nob";
            this.Nob.Size = new System.Drawing.Size(121, 29);
            this.Nob.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "No of beds:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(62, 258);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Level:";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // level
            // 
            this.level.FormattingEnabled = true;
            this.level.ItemHeight = 23;
            this.level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.level.Location = new System.Drawing.Point(111, 258);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(121, 29);
            this.level.TabIndex = 8;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(40, 304);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Extrabed:";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // Extra_bedY
            // 
            this.Extra_bedY.AutoSize = true;
            this.Extra_bedY.Location = new System.Drawing.Point(111, 308);
            this.Extra_bedY.Name = "Extra_bedY";
            this.Extra_bedY.Size = new System.Drawing.Size(41, 15);
            this.Extra_bedY.TabIndex = 10;
            this.Extra_bedY.TabStop = true;
            this.Extra_bedY.Text = "Yes";
            this.Extra_bedY.UseVisualStyleBackColor = true;
            // 
            // E_bedN
            // 
            this.E_bedN.AutoSize = true;
            this.E_bedN.Location = new System.Drawing.Point(172, 308);
            this.E_bedN.Name = "E_bedN";
            this.E_bedN.Size = new System.Drawing.Size(39, 15);
            this.E_bedN.TabIndex = 11;
            this.E_bedN.TabStop = true;
            this.E_bedN.Text = "No";
            this.E_bedN.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(206, 329);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Submit";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Add_Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 373);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.E_bedN);
            this.Controls.Add(this.Extra_bedY);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.level);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Nob);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Room_Price);
            this.Controls.Add(this.Room_Type);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Add_Rooms";
            this.Text = "Add_Rooms";
            this.Load += new System.EventHandler(this.Add_Rooms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox Room_Type;
        private MetroFramework.Controls.MetroTextBox Room_Price;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox Nob;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox level;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroRadioButton Extra_bedY;
        private MetroFramework.Controls.MetroRadioButton E_bedN;
        private MetroFramework.Controls.MetroButton Submit;
    }
}