﻿namespace Project.PLL
{
    partial class DeleteRoom
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
            this.RoomGrid = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomGrid
            // 
            this.RoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomGrid.Location = new System.Drawing.Point(23, 84);
            this.RoomGrid.Name = "RoomGrid";
            this.RoomGrid.Size = new System.Drawing.Size(446, 235);
            this.RoomGrid.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(199, 343);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Delete";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DeleteRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 389);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.RoomGrid);
            this.Name = "DeleteRoom";
            this.Text = "DeleteRoom";
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomGrid;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}