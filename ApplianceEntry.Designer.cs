namespace HomeApplianceRentalSystem
{
    partial class ApplianceEntry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblApplianceID = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtEstimatedAnnualCosts = new System.Windows.Forms.TextBox();
            this.txtTypicalUsage = new System.Windows.Forms.TextBox();
            this.txtPowerUsage = new System.Windows.Forms.TextBox();
            this.txtApplianceName = new System.Windows.Forms.TextBox();
            this.lblAppID = new System.Windows.Forms.Label();
            this.lblApplianceName = new System.Windows.Forms.Label();
            this.lblPowerUsage = new System.Windows.Forms.Label();
            this.lblTypicalUsage = new System.Windows.Forms.Label();
            this.lblEstimatedAnnualCosts = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDimension = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboApplianceType = new System.Windows.Forms.ComboBox();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.picAppliancePhoto = new System.Windows.Forms.PictureBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtMonthlyFees = new System.Windows.Forms.TextBox();
            this.txtEnergyConsumption = new System.Windows.Forms.TextBox();
            this.lblEnergyConsumption = new System.Windows.Forms.Label();
            this.lblMonthlyFees = new System.Windows.Forms.Label();
            this.lblApplianceType = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblApplianceImage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvAppliance = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppliancePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliance)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lblApplianceID);
            this.groupBox1.Controls.Add(this.txtColour);
            this.groupBox1.Controls.Add(this.txtDimension);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtEstimatedAnnualCosts);
            this.groupBox1.Controls.Add(this.txtTypicalUsage);
            this.groupBox1.Controls.Add(this.txtPowerUsage);
            this.groupBox1.Controls.Add(this.txtApplianceName);
            this.groupBox1.Controls.Add(this.lblAppID);
            this.groupBox1.Controls.Add(this.lblApplianceName);
            this.groupBox1.Controls.Add(this.lblPowerUsage);
            this.groupBox1.Controls.Add(this.lblTypicalUsage);
            this.groupBox1.Controls.Add(this.lblEstimatedAnnualCosts);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.lblDimension);
            this.groupBox1.Controls.Add(this.lblColour);
            this.groupBox1.Location = new System.Drawing.Point(37, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(510, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblApplianceID
            // 
            this.lblApplianceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApplianceID.Enabled = false;
            this.lblApplianceID.Location = new System.Drawing.Point(262, 41);
            this.lblApplianceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplianceID.Name = "lblApplianceID";
            this.lblApplianceID.Size = new System.Drawing.Size(196, 25);
            this.lblApplianceID.TabIndex = 19;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(262, 451);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(196, 27);
            this.txtColour.TabIndex = 17;
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(262, 400);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(196, 27);
            this.txtDimension.TabIndex = 16;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(262, 342);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(196, 27);
            this.txtModel.TabIndex = 15;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // txtEstimatedAnnualCosts
            // 
            this.txtEstimatedAnnualCosts.Location = new System.Drawing.Point(262, 281);
            this.txtEstimatedAnnualCosts.Name = "txtEstimatedAnnualCosts";
            this.txtEstimatedAnnualCosts.Size = new System.Drawing.Size(196, 27);
            this.txtEstimatedAnnualCosts.TabIndex = 14;
            // 
            // txtTypicalUsage
            // 
            this.txtTypicalUsage.Location = new System.Drawing.Point(262, 218);
            this.txtTypicalUsage.Name = "txtTypicalUsage";
            this.txtTypicalUsage.Size = new System.Drawing.Size(196, 27);
            this.txtTypicalUsage.TabIndex = 13;
            // 
            // txtPowerUsage
            // 
            this.txtPowerUsage.Location = new System.Drawing.Point(262, 162);
            this.txtPowerUsage.Name = "txtPowerUsage";
            this.txtPowerUsage.Size = new System.Drawing.Size(196, 27);
            this.txtPowerUsage.TabIndex = 12;
            // 
            // txtApplianceName
            // 
            this.txtApplianceName.Location = new System.Drawing.Point(262, 99);
            this.txtApplianceName.Name = "txtApplianceName";
            this.txtApplianceName.Size = new System.Drawing.Size(196, 27);
            this.txtApplianceName.TabIndex = 11;
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Location = new System.Drawing.Point(26, 39);
            this.lblAppID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(104, 20);
            this.lblAppID.TabIndex = 2;
            this.lblAppID.Text = "Appliance ID";
            // 
            // lblApplianceName
            // 
            this.lblApplianceName.AutoSize = true;
            this.lblApplianceName.Location = new System.Drawing.Point(26, 99);
            this.lblApplianceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplianceName.Name = "lblApplianceName";
            this.lblApplianceName.Size = new System.Drawing.Size(131, 20);
            this.lblApplianceName.TabIndex = 3;
            this.lblApplianceName.Text = "Appliance Name";
            // 
            // lblPowerUsage
            // 
            this.lblPowerUsage.AutoSize = true;
            this.lblPowerUsage.Location = new System.Drawing.Point(26, 162);
            this.lblPowerUsage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPowerUsage.Name = "lblPowerUsage";
            this.lblPowerUsage.Size = new System.Drawing.Size(109, 20);
            this.lblPowerUsage.TabIndex = 4;
            this.lblPowerUsage.Text = "Power Usage";
            // 
            // lblTypicalUsage
            // 
            this.lblTypicalUsage.AutoSize = true;
            this.lblTypicalUsage.Location = new System.Drawing.Point(26, 218);
            this.lblTypicalUsage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypicalUsage.Name = "lblTypicalUsage";
            this.lblTypicalUsage.Size = new System.Drawing.Size(115, 20);
            this.lblTypicalUsage.TabIndex = 5;
            this.lblTypicalUsage.Text = "Typical Usage";
            // 
            // lblEstimatedAnnualCosts
            // 
            this.lblEstimatedAnnualCosts.AutoSize = true;
            this.lblEstimatedAnnualCosts.Location = new System.Drawing.Point(26, 281);
            this.lblEstimatedAnnualCosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstimatedAnnualCosts.Name = "lblEstimatedAnnualCosts";
            this.lblEstimatedAnnualCosts.Size = new System.Drawing.Size(189, 20);
            this.lblEstimatedAnnualCosts.TabIndex = 6;
            this.lblEstimatedAnnualCosts.Text = "Estimated Annual Costs";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(26, 342);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 20);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model";
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Location = new System.Drawing.Point(26, 400);
            this.lblDimension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(89, 20);
            this.lblDimension.TabIndex = 8;
            this.lblDimension.Text = "Dimension";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(26, 451);
            this.lblColour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(58, 20);
            this.lblColour.TabIndex = 9;
            this.lblColour.Text = "Colour";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.cboApplianceType);
            this.groupBox2.Controls.Add(this.lblAdminID);
            this.groupBox2.Controls.Add(this.picAppliancePhoto);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.txtMonthlyFees);
            this.groupBox2.Controls.Add(this.txtEnergyConsumption);
            this.groupBox2.Controls.Add(this.lblEnergyConsumption);
            this.groupBox2.Controls.Add(this.lblMonthlyFees);
            this.groupBox2.Controls.Add(this.lblApplianceType);
            this.groupBox2.Controls.Add(this.lblAdmin);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.lblApplianceImage);
            this.groupBox2.Location = new System.Drawing.Point(586, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(510, 506);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cboApplianceType
            // 
            this.cboApplianceType.FormattingEnabled = true;
            this.cboApplianceType.Location = new System.Drawing.Point(262, 162);
            this.cboApplianceType.Name = "cboApplianceType";
            this.cboApplianceType.Size = new System.Drawing.Size(196, 28);
            this.cboApplianceType.TabIndex = 19;
            this.cboApplianceType.SelectedIndexChanged += new System.EventHandler(this.cboApplianceType_SelectedIndexChanged_1);
            // 
            // lblAdminID
            // 
            this.lblAdminID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdminID.Enabled = false;
            this.lblAdminID.Location = new System.Drawing.Point(262, 220);
            this.lblAdminID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(196, 25);
            this.lblAdminID.TabIndex = 18;
            // 
            // picAppliancePhoto
            // 
            this.picAppliancePhoto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.picAppliancePhoto.Location = new System.Drawing.Point(262, 342);
            this.picAppliancePhoto.Name = "picAppliancePhoto";
            this.picAppliancePhoto.Size = new System.Drawing.Size(196, 153);
            this.picAppliancePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAppliancePhoto.TabIndex = 17;
            this.picAppliancePhoto.TabStop = false;
            this.picAppliancePhoto.Click += new System.EventHandler(this.picAppliancePhoto_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(262, 278);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(196, 27);
            this.txtQuantity.TabIndex = 14;
            // 
            // txtMonthlyFees
            // 
            this.txtMonthlyFees.Location = new System.Drawing.Point(262, 99);
            this.txtMonthlyFees.Name = "txtMonthlyFees";
            this.txtMonthlyFees.Size = new System.Drawing.Size(196, 27);
            this.txtMonthlyFees.TabIndex = 11;
            // 
            // txtEnergyConsumption
            // 
            this.txtEnergyConsumption.Location = new System.Drawing.Point(262, 39);
            this.txtEnergyConsumption.Name = "txtEnergyConsumption";
            this.txtEnergyConsumption.Size = new System.Drawing.Size(196, 27);
            this.txtEnergyConsumption.TabIndex = 10;
            // 
            // lblEnergyConsumption
            // 
            this.lblEnergyConsumption.AutoSize = true;
            this.lblEnergyConsumption.Location = new System.Drawing.Point(26, 39);
            this.lblEnergyConsumption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnergyConsumption.Name = "lblEnergyConsumption";
            this.lblEnergyConsumption.Size = new System.Drawing.Size(164, 20);
            this.lblEnergyConsumption.TabIndex = 2;
            this.lblEnergyConsumption.Text = "Energy Consumption";
            // 
            // lblMonthlyFees
            // 
            this.lblMonthlyFees.AutoSize = true;
            this.lblMonthlyFees.Location = new System.Drawing.Point(26, 99);
            this.lblMonthlyFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyFees.Name = "lblMonthlyFees";
            this.lblMonthlyFees.Size = new System.Drawing.Size(109, 20);
            this.lblMonthlyFees.TabIndex = 3;
            this.lblMonthlyFees.Text = "Monthly Fees";
            // 
            // lblApplianceType
            // 
            this.lblApplianceType.AutoSize = true;
            this.lblApplianceType.Location = new System.Drawing.Point(26, 162);
            this.lblApplianceType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplianceType.Name = "lblApplianceType";
            this.lblApplianceType.Size = new System.Drawing.Size(123, 20);
            this.lblApplianceType.TabIndex = 4;
            this.lblApplianceType.Text = "Appliance Type";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(26, 218);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(78, 20);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "Admin ID";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(26, 281);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 20);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblApplianceImage
            // 
            this.lblApplianceImage.AutoSize = true;
            this.lblApplianceImage.Location = new System.Drawing.Point(26, 342);
            this.lblApplianceImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplianceImage.Name = "lblApplianceImage";
            this.lblApplianceImage.Size = new System.Drawing.Size(132, 20);
            this.lblApplianceImage.TabIndex = 7;
            this.lblApplianceImage.Text = "Appliance Image";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 51);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(363, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 51);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(526, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(679, 526);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 51);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(838, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 51);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvAppliance
            // 
            this.dgvAppliance.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAppliance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppliance.Location = new System.Drawing.Point(37, 583);
            this.dgvAppliance.Name = "dgvAppliance";
            this.dgvAppliance.RowTemplate.Height = 24;
            this.dgvAppliance.Size = new System.Drawing.Size(1059, 175);
            this.dgvAppliance.TabIndex = 8;
            this.dgvAppliance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppliance_CellContentClick);
            this.dgvAppliance.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppliance_CellMouseClick);
            // 
            // ApplianceEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 779);
            this.Controls.Add(this.dgvAppliance);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApplianceEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appliance Entry";
            this.Load += new System.EventHandler(this.ApplianceEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppliancePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtEstimatedAnnualCosts;
        private System.Windows.Forms.TextBox txtTypicalUsage;
        private System.Windows.Forms.TextBox txtPowerUsage;
        private System.Windows.Forms.TextBox txtApplianceName;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label lblApplianceName;
        private System.Windows.Forms.Label lblPowerUsage;
        private System.Windows.Forms.Label lblTypicalUsage;
        private System.Windows.Forms.Label lblEstimatedAnnualCosts;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Label lblColour;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picAppliancePhoto;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtMonthlyFees;
        private System.Windows.Forms.TextBox txtEnergyConsumption;
        private System.Windows.Forms.Label lblEnergyConsumption;
        private System.Windows.Forms.Label lblMonthlyFees;
        private System.Windows.Forms.Label lblApplianceType;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblApplianceImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvAppliance;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Label lblApplianceID;
        private System.Windows.Forms.ComboBox cboApplianceType;
    }
}