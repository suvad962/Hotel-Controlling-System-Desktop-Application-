namespace Project.PLL
{
    partial class Confirm_Booking
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
            this.Confirmgrid = new System.Windows.Forms.DataGridView();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.Confirm_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Confirmgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirmgrid
            // 
            this.Confirmgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Confirmgrid.Location = new System.Drawing.Point(23, 63);
            this.Confirmgrid.Name = "Confirmgrid";
            this.Confirmgrid.Size = new System.Drawing.Size(519, 241);
            this.Confirmgrid.TabIndex = 0;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(273, 319);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "submit";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // Confirm_id
            // 
            this.Confirm_id.Location = new System.Drawing.Point(124, 319);
            this.Confirm_id.Name = "Confirm_id";
            this.Confirm_id.Size = new System.Drawing.Size(129, 23);
            this.Confirm_id.TabIndex = 4;
            this.Confirm_id.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 322);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Room_ID:";
            // 
            // Confirm_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 352);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Confirm_id);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.Confirmgrid);
            this.Name = "Confirm_Booking";
            this.Text = "Confirm_Booking";
            ((System.ComponentModel.ISupportInitialize)(this.Confirmgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Confirmgrid;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox Confirm_id;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}