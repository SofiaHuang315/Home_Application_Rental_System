namespace HomeApplianceRentalSystem
{
    partial class CustomerHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuViewAppliance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentAppliance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewRentalList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRent = new System.Windows.Forms.Button();
            this.cboNumberOfMonth = new System.Windows.Forms.ComboBox();
            this.txtAllTotalAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtTotalRentQuantity = new System.Windows.Forms.TextBox();
            this.txtRentDate = new System.Windows.Forms.TextBox();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.dgvViewAppliance = new System.Windows.Forms.DataGridView();
            this.dgvRentAppliance = new System.Windows.Forms.DataGridView();
            this.dgvViewRentList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAppliance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentAppliance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRentList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewAppliance,
            this.mnuRentAppliance,
            this.mnuViewRentalList,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1102, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuViewAppliance
            // 
            this.mnuViewAppliance.Name = "mnuViewAppliance";
            this.mnuViewAppliance.Size = new System.Drawing.Size(124, 24);
            this.mnuViewAppliance.Text = "View Appliance";
            this.mnuViewAppliance.Click += new System.EventHandler(this.mnuViewAppliance_Click);
            // 
            // mnuRentAppliance
            // 
            this.mnuRentAppliance.Name = "mnuRentAppliance";
            this.mnuRentAppliance.Size = new System.Drawing.Size(122, 24);
            this.mnuRentAppliance.Text = "Rent Appliance";
            this.mnuRentAppliance.Click += new System.EventHandler(this.mnuRentAppliance_Click);
            // 
            // mnuViewRentalList
            // 
            this.mnuViewRentalList.Name = "mnuViewRentalList";
            this.mnuViewRentalList.Size = new System.Drawing.Size(125, 24);
            this.mnuViewRentalList.Text = "View Rental List";
            this.mnuViewRentalList.Click += new System.EventHandler(this.mnuViewRentalList_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(45, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnRent);
            this.panel1.Controls.Add(this.cboNumberOfMonth);
            this.panel1.Controls.Add(this.txtAllTotalAmount);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.txtTotalRentQuantity);
            this.panel1.Controls.Add(this.txtRentDate);
            this.panel1.Controls.Add(this.txtRentID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(690, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 546);
            this.panel1.TabIndex = 1;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(13, 470);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(357, 41);
            this.btnRent.TabIndex = 16;
            this.btnRent.Text = "&Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // cboNumberOfMonth
            // 
            this.cboNumberOfMonth.FormattingEnabled = true;
            this.cboNumberOfMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboNumberOfMonth.Location = new System.Drawing.Point(190, 327);
            this.cboNumberOfMonth.Name = "cboNumberOfMonth";
            this.cboNumberOfMonth.Size = new System.Drawing.Size(180, 28);
            this.cboNumberOfMonth.TabIndex = 15;
            this.cboNumberOfMonth.SelectedIndexChanged += new System.EventHandler(this.cboNumberOfMonth_SelectedIndexChanged);
            // 
            // txtAllTotalAmount
            // 
            this.txtAllTotalAmount.Enabled = false;
            this.txtAllTotalAmount.Location = new System.Drawing.Point(190, 385);
            this.txtAllTotalAmount.Name = "txtAllTotalAmount";
            this.txtAllTotalAmount.Size = new System.Drawing.Size(180, 27);
            this.txtAllTotalAmount.TabIndex = 14;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(190, 267);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(180, 27);
            this.txtTotalAmount.TabIndex = 13;
            // 
            // txtTotalRentQuantity
            // 
            this.txtTotalRentQuantity.Enabled = false;
            this.txtTotalRentQuantity.Location = new System.Drawing.Point(190, 210);
            this.txtTotalRentQuantity.Name = "txtTotalRentQuantity";
            this.txtTotalRentQuantity.Size = new System.Drawing.Size(180, 27);
            this.txtTotalRentQuantity.TabIndex = 12;
            // 
            // txtRentDate
            // 
            this.txtRentDate.Enabled = false;
            this.txtRentDate.Location = new System.Drawing.Point(190, 155);
            this.txtRentDate.Name = "txtRentDate";
            this.txtRentDate.Size = new System.Drawing.Size(180, 27);
            this.txtRentDate.TabIndex = 11;
            // 
            // txtRentID
            // 
            this.txtRentID.Enabled = false;
            this.txtRentID.Location = new System.Drawing.Point(190, 98);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(180, 27);
            this.txtRentID.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "All Total Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number of Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Rent Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rent Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rent ID";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(9, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(94, 22);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(109, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "label2";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(148, 560);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(357, 41);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "&Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // dgvViewAppliance
            // 
            this.dgvViewAppliance.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvViewAppliance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAppliance.Location = new System.Drawing.Point(12, 55);
            this.dgvViewAppliance.Name = "dgvViewAppliance";
            this.dgvViewAppliance.RowTemplate.Height = 24;
            this.dgvViewAppliance.Size = new System.Drawing.Size(671, 471);
            this.dgvViewAppliance.TabIndex = 2;
            this.dgvViewAppliance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewAppliance_CellClick);
            // 
            // dgvRentAppliance
            // 
            this.dgvRentAppliance.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRentAppliance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentAppliance.Location = new System.Drawing.Point(12, 55);
            this.dgvRentAppliance.Name = "dgvRentAppliance";
            this.dgvRentAppliance.RowTemplate.Height = 24;
            this.dgvRentAppliance.Size = new System.Drawing.Size(671, 471);
            this.dgvRentAppliance.TabIndex = 3;
            // 
            // dgvViewRentList
            // 
            this.dgvViewRentList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvViewRentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewRentList.Location = new System.Drawing.Point(12, 55);
            this.dgvViewRentList.Name = "dgvViewRentList";
            this.dgvViewRentList.RowTemplate.Height = 24;
            this.dgvViewRentList.Size = new System.Drawing.Size(671, 471);
            this.dgvViewRentList.TabIndex = 4;
            this.dgvViewRentList.Visible = false;
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 626);
            this.Controls.Add(this.dgvViewRentList);
            this.Controls.Add(this.dgvRentAppliance);
            this.Controls.Add(this.dgvViewAppliance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnChoose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Home";
            this.Load += new System.EventHandler(this.CustomerHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAppliance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentAppliance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuViewAppliance;
        private System.Windows.Forms.ToolStripMenuItem mnuRentAppliance;
        private System.Windows.Forms.ToolStripMenuItem mnuViewRentalList;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvViewAppliance;
        private System.Windows.Forms.DataGridView dgvRentAppliance;
        private System.Windows.Forms.ComboBox cboNumberOfMonth;
        private System.Windows.Forms.TextBox txtAllTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtTotalRentQuantity;
        private System.Windows.Forms.TextBox txtRentDate;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.DataGridView dgvViewRentList;
    }
}