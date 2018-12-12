namespace Project.PLL
{
    partial class Guest_Panel
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile1.Location = new System.Drawing.Point(55, 114);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(104, 93);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Bookings";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile3.Location = new System.Drawing.Point(212, 114);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(104, 93);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Orders";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTile2.Location = new System.Drawing.Point(371, 114);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(104, 93);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Services";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // Guest_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 382);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile1);
            this.Name = "Guest_Panel";
            this.Text = "Guest Dashboard";
            this.Load += new System.EventHandler(this.Guest_Panel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}