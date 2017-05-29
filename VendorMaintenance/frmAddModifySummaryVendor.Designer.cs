namespace VendorMaintenance
{
    partial class frmAddModifySummaryVendor
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.cboTerms = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtSumOfInvoices = new System.Windows.Forms.TextBox();
            this.lblSumOfInvoices = new System.Windows.Forms.Label();
            this.lblLastInvoiceDate = new System.Windows.Forms.Label();
            this.txtLastInvoiceDate = new System.Windows.Forms.TextBox();
            this.lblSumOfPayments = new System.Windows.Forms.Label();
            this.txtSumOfPayments = new System.Windows.Forms.TextBox();
            this.lblLastPaymentDate = new System.Windows.Forms.Label();
            this.txtLastPaymentDate = new System.Windows.Forms.TextBox();
            this.lblSumOfCredits = new System.Windows.Forms.Label();
            this.txtSumOfCredits = new System.Windows.Forms.TextBox();
            this.lblBalanceDue = new System.Windows.Forms.Label();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(270, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(15, 383);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 28;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cboAccounts);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.cboTerms);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Location = new System.Drawing.Point(15, 154);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(331, 81);
            this.GroupBox2.TabIndex = 26;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Defaults";
            // 
            // cboAccounts
            // 
            this.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Location = new System.Drawing.Point(62, 46);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(159, 21);
            this.cboAccounts.TabIndex = 3;
            this.cboAccounts.Tag = "Account";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(6, 49);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(50, 13);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "Account:";
            // 
            // cboTerms
            // 
            this.cboTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerms.FormattingEnabled = true;
            this.cboTerms.Location = new System.Drawing.Point(62, 19);
            this.cboTerms.Name = "cboTerms";
            this.cboTerms.Size = new System.Drawing.Size(159, 21);
            this.cboTerms.TabIndex = 1;
            this.cboTerms.Tag = "Terms";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Terms:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtLastName);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.txtFirstName);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.txtPhone);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(15, 250);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(331, 108);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Contact information:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(70, 72);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(8, 75);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(59, 13);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "Last name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(70, 46);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(6, 49);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(58, 13);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "First name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(70, 20);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(120, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Tag = "Phone";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(41, 13);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Phone:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(266, 116);
            this.txtZipCode.MaxLength = 20;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(80, 20);
            this.txtZipCode.TabIndex = 25;
            this.txtZipCode.Tag = "Zip code";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(208, 119);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 13);
            this.Label7.TabIndex = 24;
            this.Label7.Text = "Zip code:";
            // 
            // cboStates
            // 
            this.cboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(66, 116);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(130, 21);
            this.cboStates.TabIndex = 23;
            this.cboStates.Tag = "State";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 120);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(35, 13);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(66, 90);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(280, 20);
            this.txtCity.TabIndex = 21;
            this.txtCity.Tag = "City";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 93);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(27, 13);
            this.Label5.TabIndex = 20;
            this.Label5.Text = "City:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(66, 64);
            this.txtAddress2.MaxLength = 50;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(280, 20);
            this.txtAddress2.TabIndex = 19;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(66, 38);
            this.txtAddress1.MaxLength = 50;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(280, 20);
            this.txtAddress1.TabIndex = 18;
            this.txtAddress1.Tag = "Address1";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 41);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 13);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Address:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 12);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 16;
            this.txtName.Tag = "Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Name:";
            // 
            // txtSumOfInvoices
            // 
            this.txtSumOfInvoices.Location = new System.Drawing.Point(474, 12);
            this.txtSumOfInvoices.MaxLength = 50;
            this.txtSumOfInvoices.Name = "txtSumOfInvoices";
            this.txtSumOfInvoices.Size = new System.Drawing.Size(280, 20);
            this.txtSumOfInvoices.TabIndex = 30;
            this.txtSumOfInvoices.Tag = "City";
            // 
            // lblSumOfInvoices
            // 
            this.lblSumOfInvoices.AutoSize = true;
            this.lblSumOfInvoices.Location = new System.Drawing.Point(383, 15);
            this.lblSumOfInvoices.Name = "lblSumOfInvoices";
            this.lblSumOfInvoices.Size = new System.Drawing.Size(85, 13);
            this.lblSumOfInvoices.TabIndex = 31;
            this.lblSumOfInvoices.Text = "Sum Of Invoices";
            // 
            // lblLastInvoiceDate
            // 
            this.lblLastInvoiceDate.AutoSize = true;
            this.lblLastInvoiceDate.Location = new System.Drawing.Point(377, 41);
            this.lblLastInvoiceDate.Name = "lblLastInvoiceDate";
            this.lblLastInvoiceDate.Size = new System.Drawing.Size(91, 13);
            this.lblLastInvoiceDate.TabIndex = 33;
            this.lblLastInvoiceDate.Text = "Last Invoice Date";
            // 
            // txtLastInvoiceDate
            // 
            this.txtLastInvoiceDate.Location = new System.Drawing.Point(474, 38);
            this.txtLastInvoiceDate.MaxLength = 50;
            this.txtLastInvoiceDate.Name = "txtLastInvoiceDate";
            this.txtLastInvoiceDate.Size = new System.Drawing.Size(280, 20);
            this.txtLastInvoiceDate.TabIndex = 32;
            this.txtLastInvoiceDate.Tag = "City";
            // 
            // lblSumOfPayments
            // 
            this.lblSumOfPayments.AutoSize = true;
            this.lblSumOfPayments.Location = new System.Drawing.Point(377, 67);
            this.lblSumOfPayments.Name = "lblSumOfPayments";
            this.lblSumOfPayments.Size = new System.Drawing.Size(91, 13);
            this.lblSumOfPayments.TabIndex = 35;
            this.lblSumOfPayments.Text = "Sum Of Payments";
            // 
            // txtSumOfPayments
            // 
            this.txtSumOfPayments.Location = new System.Drawing.Point(474, 64);
            this.txtSumOfPayments.MaxLength = 50;
            this.txtSumOfPayments.Name = "txtSumOfPayments";
            this.txtSumOfPayments.Size = new System.Drawing.Size(280, 20);
            this.txtSumOfPayments.TabIndex = 34;
            this.txtSumOfPayments.Tag = "City";
            // 
            // lblLastPaymentDate
            // 
            this.lblLastPaymentDate.AutoSize = true;
            this.lblLastPaymentDate.Location = new System.Drawing.Point(371, 93);
            this.lblLastPaymentDate.Name = "lblLastPaymentDate";
            this.lblLastPaymentDate.Size = new System.Drawing.Size(97, 13);
            this.lblLastPaymentDate.TabIndex = 37;
            this.lblLastPaymentDate.Text = "Last Payment Date";
            // 
            // txtLastPaymentDate
            // 
            this.txtLastPaymentDate.Location = new System.Drawing.Point(474, 90);
            this.txtLastPaymentDate.MaxLength = 50;
            this.txtLastPaymentDate.Name = "txtLastPaymentDate";
            this.txtLastPaymentDate.Size = new System.Drawing.Size(280, 20);
            this.txtLastPaymentDate.TabIndex = 36;
            this.txtLastPaymentDate.Tag = "City";
            // 
            // lblSumOfCredits
            // 
            this.lblSumOfCredits.AutoSize = true;
            this.lblSumOfCredits.Location = new System.Drawing.Point(391, 119);
            this.lblSumOfCredits.Name = "lblSumOfCredits";
            this.lblSumOfCredits.Size = new System.Drawing.Size(77, 13);
            this.lblSumOfCredits.TabIndex = 39;
            this.lblSumOfCredits.Text = "Sum Of Credits";
            // 
            // txtSumOfCredits
            // 
            this.txtSumOfCredits.Location = new System.Drawing.Point(474, 116);
            this.txtSumOfCredits.MaxLength = 50;
            this.txtSumOfCredits.Name = "txtSumOfCredits";
            this.txtSumOfCredits.Size = new System.Drawing.Size(280, 20);
            this.txtSumOfCredits.TabIndex = 38;
            this.txtSumOfCredits.Tag = "City";
            // 
            // lblBalanceDue
            // 
            this.lblBalanceDue.AutoSize = true;
            this.lblBalanceDue.Location = new System.Drawing.Point(399, 145);
            this.lblBalanceDue.Name = "lblBalanceDue";
            this.lblBalanceDue.Size = new System.Drawing.Size(69, 13);
            this.lblBalanceDue.TabIndex = 41;
            this.lblBalanceDue.Text = "Balance Due";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.Location = new System.Drawing.Point(474, 142);
            this.txtBalanceDue.MaxLength = 50;
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.Size = new System.Drawing.Size(280, 20);
            this.txtBalanceDue.TabIndex = 40;
            this.txtBalanceDue.Tag = "City";
            // 
            // frmAddModifySummaryVendor
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(766, 438);
            this.ControlBox = false;
            this.Controls.Add(this.lblBalanceDue);
            this.Controls.Add(this.txtBalanceDue);
            this.Controls.Add(this.lblSumOfCredits);
            this.Controls.Add(this.txtSumOfCredits);
            this.Controls.Add(this.lblLastPaymentDate);
            this.Controls.Add(this.txtLastPaymentDate);
            this.Controls.Add(this.lblSumOfPayments);
            this.Controls.Add(this.txtSumOfPayments);
            this.Controls.Add(this.lblLastInvoiceDate);
            this.Controls.Add(this.txtLastInvoiceDate);
            this.Controls.Add(this.lblSumOfInvoices);
            this.Controls.Add(this.txtSumOfInvoices);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddModifySummaryVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Modify Vendor";
            this.Load += new System.EventHandler(this.frmAddModifyVendor_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnAccept;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox cboAccounts;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.ComboBox cboTerms;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtZipCode;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cboStates;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtAddress2;
        internal System.Windows.Forms.TextBox txtAddress1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtSumOfInvoices;
        internal System.Windows.Forms.Label lblSumOfInvoices;
        internal System.Windows.Forms.Label lblLastInvoiceDate;
        internal System.Windows.Forms.TextBox txtLastInvoiceDate;
        internal System.Windows.Forms.Label lblSumOfPayments;
        internal System.Windows.Forms.TextBox txtSumOfPayments;
        internal System.Windows.Forms.Label lblLastPaymentDate;
        internal System.Windows.Forms.TextBox txtLastPaymentDate;
        internal System.Windows.Forms.Label lblSumOfCredits;
        internal System.Windows.Forms.TextBox txtSumOfCredits;
        internal System.Windows.Forms.Label lblBalanceDue;
        internal System.Windows.Forms.TextBox txtBalanceDue;
    }
}
