namespace HomeApplianceRentalSystem
{
    partial class RentalSearch
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
            this.grpSearchCriteria = new System.Windows.Forms.GroupBox();
            this.cboSearchbyID = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboSearchbyType = new System.Windows.Forms.ComboBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoSearchbyApplianceType = new System.Windows.Forms.RadioButton();
            this.rdoSearchbyID = new System.Windows.Forms.RadioButton();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.grpSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearchCriteria
            // 
            this.grpSearchCriteria.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpSearchCriteria.Controls.Add(this.cboSearchbyID);
            this.grpSearchCriteria.Controls.Add(this.btnBack);
            this.grpSearchCriteria.Controls.Add(this.cboSearchbyType);
            this.grpSearchCriteria.Controls.Add(this.btnShowAll);
            this.grpSearchCriteria.Controls.Add(this.btnSearch);
            this.grpSearchCriteria.Controls.Add(this.rdoSearchbyApplianceType);
            this.grpSearchCriteria.Controls.Add(this.rdoSearchbyID);
            this.grpSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchCriteria.Location = new System.Drawing.Point(12, 12);
            this.grpSearchCriteria.Name = "grpSearchCriteria";
            this.grpSearchCriteria.Size = new System.Drawing.Size(970, 173);
            this.grpSearchCriteria.TabIndex = 0;
            this.grpSearchCriteria.TabStop = false;
            this.grpSearchCriteria.Text = "Search Criteria:";
            // 
            // cboSearchbyID
            // 
            this.cboSearchbyID.FormattingEnabled = true;
            this.cboSearchbyID.Location = new System.Drawing.Point(18, 91);
            this.cboSearchbyID.Name = "cboSearchbyID";
            this.cboSearchbyID.Size = new System.Drawing.Size(224, 28);
            this.cboSearchbyID.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(815, 91);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 36);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboSearchbyType
            // 
            this.cboSearchbyType.FormattingEnabled = true;
            this.cboSearchbyType.Location = new System.Drawing.Point(257, 91);
            this.cboSearchbyType.Name = "cboSearchbyType";
            this.cboSearchbyType.Size = new System.Drawing.Size(224, 28);
            this.cboSearchbyType.TabIndex = 9;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(690, 91);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(99, 36);
            this.btnShowAll.TabIndex = 6;
            this.btnShowAll.Text = "Show &All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(556, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoSearchbyApplianceType
            // 
            this.rdoSearchbyApplianceType.AutoSize = true;
            this.rdoSearchbyApplianceType.Location = new System.Drawing.Point(257, 50);
            this.rdoSearchbyApplianceType.Name = "rdoSearchbyApplianceType";
            this.rdoSearchbyApplianceType.Size = new System.Drawing.Size(224, 24);
            this.rdoSearchbyApplianceType.TabIndex = 3;
            this.rdoSearchbyApplianceType.TabStop = true;
            this.rdoSearchbyApplianceType.Text = "Search by Appliance Type";
            this.rdoSearchbyApplianceType.UseVisualStyleBackColor = true;
            // 
            // rdoSearchbyID
            // 
            this.rdoSearchbyID.AutoSize = true;
            this.rdoSearchbyID.Location = new System.Drawing.Point(18, 50);
            this.rdoSearchbyID.Name = "rdoSearchbyID";
            this.rdoSearchbyID.Size = new System.Drawing.Size(127, 24);
            this.rdoSearchbyID.TabIndex = 0;
            this.rdoSearchbyID.TabStop = true;
            this.rdoSearchbyID.Text = "Search by ID";
            this.rdoSearchbyID.UseVisualStyleBackColor = true;
            this.rdoSearchbyID.CheckedChanged += new System.EventHandler(this.rdoSearchbyID_CheckedChanged);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(12, 204);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.Size = new System.Drawing.Size(970, 313);
            this.dgvDisplay.TabIndex = 1;
            // 
            // RentalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 538);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.grpSearchCriteria);
            this.Name = "RentalSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Search";
            this.grpSearchCriteria.ResumeLayout(false);
            this.grpSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchCriteria;
        private System.Windows.Forms.ComboBox cboSearchbyType;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoSearchbyApplianceType;
        private System.Windows.Forms.RadioButton rdoSearchbyID;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboSearchbyID;
    }
}