namespace Project.PLL
{
    partial class UpdateEmp
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.No = new MetroFramework.Controls.MetroRadioButton();
            this.Yes = new MetroFramework.Controls.MetroRadioButton();
            this.Address = new MetroFramework.Controls.MetroTextBox();
            this.Salary = new MetroFramework.Controls.MetroTextBox();
            this.Department = new MetroFramework.Controls.MetroTextBox();
            this.Ename = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroButton1.Location = new System.Drawing.Point(244, 330);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 24;
            this.metroButton1.Text = "Submit";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(113, 293);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Available:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(113, 136);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Department:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(147, 184);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Salary:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(138, 229);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Address";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(147, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Name:";
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(262, 297);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(39, 15);
            this.No.TabIndex = 18;
            this.No.TabStop = true;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Location = new System.Drawing.Point(202, 297);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(41, 15);
            this.Yes.TabIndex = 17;
            this.Yes.TabStop = true;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(202, 229);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(180, 23);
            this.Address.TabIndex = 16;
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(202, 184);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(180, 23);
            this.Salary.TabIndex = 15;
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(202, 136);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(180, 23);
            this.Department.TabIndex = 14;
            // 
            // Ename
            // 
            this.Ename.Location = new System.Drawing.Point(202, 81);
            this.Ename.Name = "Ename";
            this.Ename.Size = new System.Drawing.Size(180, 23);
            this.Ename.TabIndex = 13;
            // 
            // UpdateEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 385);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Ename);
            this.Name = "UpdateEmp";
            this.Text = "UpdateEmp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton No;
        private MetroFramework.Controls.MetroRadioButton Yes;
        private MetroFramework.Controls.MetroTextBox Address;
        private MetroFramework.Controls.MetroTextBox Salary;
        private MetroFramework.Controls.MetroTextBox Department;
        private MetroFramework.Controls.MetroTextBox Ename;
    }
}