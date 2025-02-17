namespace HomeApplianceRentalSystem
{
    partial class AdminList
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
            this.lblAdministratorList = new System.Windows.Forms.Label();
            this.dgvAdminList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdministratorList
            // 
            this.lblAdministratorList.AutoSize = true;
            this.lblAdministratorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministratorList.Location = new System.Drawing.Point(259, 56);
            this.lblAdministratorList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdministratorList.Name = "lblAdministratorList";
            this.lblAdministratorList.Size = new System.Drawing.Size(287, 38);
            this.lblAdministratorList.TabIndex = 0;
            this.lblAdministratorList.Text = "Administrator List";
            // 
            // dgvAdminList
            // 
            this.dgvAdminList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminList.Location = new System.Drawing.Point(38, 113);
            this.dgvAdminList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAdminList.Name = "dgvAdminList";
            this.dgvAdminList.RowTemplate.Height = 24;
            this.dgvAdminList.Size = new System.Drawing.Size(756, 334);
            this.dgvAdminList.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(266, 481);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(290, 50);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 566);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAdminList);
            this.Controls.Add(this.lblAdministratorList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator List";
            this.Load += new System.EventHandler(this.AdminList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdministratorList;
        private System.Windows.Forms.DataGridView dgvAdminList;
        private System.Windows.Forms.Button btnBack;
    }
}