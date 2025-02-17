namespace HomeApplianceRentalSystem
{
    partial class RentList
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRentList = new System.Windows.Forms.DataGridView();
            this.dgvDetailRentList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRentList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rent list for Customers";
            // 
            // dgvRentList
            // 
            this.dgvRentList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentList.Location = new System.Drawing.Point(12, 48);
            this.dgvRentList.Name = "dgvRentList";
            this.dgvRentList.RowTemplate.Height = 24;
            this.dgvRentList.Size = new System.Drawing.Size(886, 215);
            this.dgvRentList.TabIndex = 1;
            this.dgvRentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentList_CellClick);
            // 
            // dgvDetailRentList
            // 
            this.dgvDetailRentList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDetailRentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailRentList.Location = new System.Drawing.Point(123, 332);
            this.dgvDetailRentList.Name = "dgvDetailRentList";
            this.dgvDetailRentList.RowTemplate.Height = 24;
            this.dgvDetailRentList.Size = new System.Drawing.Size(659, 215);
            this.dgvDetailRentList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detail Rent List for each customer";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(311, 578);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(288, 49);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 639);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDetailRentList);
            this.Controls.Add(this.dgvRentList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent List";
            this.Load += new System.EventHandler(this.RentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailRentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRentList;
        private System.Windows.Forms.DataGridView dgvDetailRentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}