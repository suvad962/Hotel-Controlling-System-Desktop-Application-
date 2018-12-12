namespace Project.PLL
{
    partial class DeleteEmp
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
            this.dempview = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dempview)).BeginInit();
            this.SuspendLayout();
            // 
            // dempview
            // 
            this.dempview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dempview.Location = new System.Drawing.Point(23, 73);
            this.dempview.Name = "dempview";
            this.dempview.Size = new System.Drawing.Size(410, 217);
            this.dempview.TabIndex = 0;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(187, 330);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Delete";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DeleteEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 376);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dempview);
            this.Name = "DeleteEmp";
            this.Text = "DeleteEmp";
            ((System.ComponentModel.ISupportInitialize)(this.dempview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dempview;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}