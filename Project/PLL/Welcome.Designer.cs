namespace Project.PLL
{
    partial class Welcome
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
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile5
            // 
            this.metroTile5.Location = new System.Drawing.Point(330, 93);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(119, 98);
            this.metroTile5.TabIndex = 0;
            this.metroTile5.Text = "Bookings";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile7
            // 
            this.metroTile7.Location = new System.Drawing.Point(483, 93);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(119, 98);
            this.metroTile7.TabIndex = 2;
            this.metroTile7.Text = "Services";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.Black;
            this.metroTile1.Location = new System.Drawing.Point(23, 93);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(119, 98);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Admin Login";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(176, 93);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(119, 98);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Guest Login";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 379);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile5);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}