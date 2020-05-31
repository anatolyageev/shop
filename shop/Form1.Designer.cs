namespace shop
{
    partial class Form1
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
            this.showAllBuers = new System.Windows.Forms.Button();
            this.showAllSellers = new System.Windows.Forms.Button();
            this.showAllSales = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showAllBuers
            // 
            this.showAllBuers.Location = new System.Drawing.Point(12, 12);
            this.showAllBuers.Name = "showAllBuers";
            this.showAllBuers.Size = new System.Drawing.Size(191, 59);
            this.showAllBuers.TabIndex = 1;
            this.showAllBuers.Text = "showAllByers";
            this.showAllBuers.UseVisualStyleBackColor = true;
            this.showAllBuers.Click += new System.EventHandler(this.showAllByers_Click);
            // 
            // showAllSellers
            // 
            this.showAllSellers.Location = new System.Drawing.Point(241, 12);
            this.showAllSellers.Name = "showAllSellers";
            this.showAllSellers.Size = new System.Drawing.Size(183, 59);
            this.showAllSellers.TabIndex = 2;
            this.showAllSellers.Text = "showAllSellers\r\n";
            this.showAllSellers.UseVisualStyleBackColor = true;
            this.showAllSellers.Click += new System.EventHandler(this.showAllSellers_Click);
            // 
            // showAllSales
            // 
            this.showAllSales.Location = new System.Drawing.Point(481, 12);
            this.showAllSales.Name = "showAllSales";
            this.showAllSales.Size = new System.Drawing.Size(185, 59);
            this.showAllSales.TabIndex = 3;
            this.showAllSales.Text = "showAllSales";
            this.showAllSales.UseVisualStyleBackColor = true;
            this.showAllSales.Click += new System.EventHandler(this.showAllSales_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 690);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1790, 1016);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showAllSales);
            this.Controls.Add(this.showAllSellers);
            this.Controls.Add(this.showAllBuers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.showAllByers_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showAllBuers;
        private System.Windows.Forms.Button showAllSellers;
        private System.Windows.Forms.Button showAllSales;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

