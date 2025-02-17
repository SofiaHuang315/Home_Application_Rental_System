namespace HomeApplianceRentalSystem
{
    partial class ApplianceList
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvApplianceList = new System.Windows.Forms.DataGridView();
            this.lblApplianceList = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cboApplianceType = new System.Windows.Forms.ComboBox();
            this.lblChooseApplianceType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplianceList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(492, 476);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(290, 50);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvApplianceList
            // 
            this.dgvApplianceList.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvApplianceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplianceList.Location = new System.Drawing.Point(46, 202);
            this.dgvApplianceList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApplianceList.Name = "dgvApplianceList";
            this.dgvApplianceList.RowTemplate.Height = 24;
            this.dgvApplianceList.Size = new System.Drawing.Size(1162, 235);
            this.dgvApplianceList.TabIndex = 7;
            // 
            // lblApplianceList
            // 
            this.lblApplianceList.AutoSize = true;
            this.lblApplianceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplianceList.Location = new System.Drawing.Point(485, 31);
            this.lblApplianceList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplianceList.Name = "lblApplianceList";
            this.lblApplianceList.Size = new System.Drawing.Size(234, 38);
            this.lblApplianceList.TabIndex = 6;
            this.lblApplianceList.Text = "Appliance List";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(854, 125);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 43);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(1023, 125);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(147, 43);
            this.btnShowAll.TabIndex = 10;
            this.btnShowAll.Text = "Show &All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cboApplianceType
            // 
            this.cboApplianceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboApplianceType.FormattingEnabled = true;
            this.cboApplianceType.Location = new System.Drawing.Point(408, 136);
            this.cboApplianceType.Name = "cboApplianceType";
            this.cboApplianceType.Size = new System.Drawing.Size(248, 28);
            this.cboApplianceType.TabIndex = 11;
            // 
            // lblChooseApplianceType
            // 
            this.lblChooseApplianceType.AutoSize = true;
            this.lblChooseApplianceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseApplianceType.Location = new System.Drawing.Point(192, 136);
            this.lblChooseApplianceType.Name = "lblChooseApplianceType";
            this.lblChooseApplianceType.Size = new System.Drawing.Size(190, 20);
            this.lblChooseApplianceType.TabIndex = 12;
            this.lblChooseApplianceType.Text = "Choose Appliance Type:";
            // 
            // ApplianceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1254, 557);
            this.Controls.Add(this.lblChooseApplianceType);
            this.Controls.Add(this.cboApplianceType);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvApplianceList);
            this.Controls.Add(this.lblApplianceList);
            this.Name = "ApplianceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appliance List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplianceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvApplianceList;
        private System.Windows.Forms.Label lblApplianceList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cboApplianceType;
        private System.Windows.Forms.Label lblChooseApplianceType;
    }
}