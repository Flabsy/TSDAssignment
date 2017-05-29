namespace VendorMaintenance
{
    partial class frmInvoice
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
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.btnGetInvoice = new System.Windows.Forms.Button();
            this.txtViewInvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.txtPaymentTotal = new System.Windows.Forms.TextBox();
            this.txtCreditTotal = new System.Windows.Forms.TextBox();
            this.txtPaymentDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lboxInvoiceLineItems = new System.Windows.Forms.ListBox();
            this.btnAddInvoiceItem = new System.Windows.Forms.Button();
            this.btnModifyInvoiceItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnModifyInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by invoice number:";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(159, 12);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(115, 20);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // btnGetInvoice
            // 
            this.btnGetInvoice.Location = new System.Drawing.Point(280, 10);
            this.btnGetInvoice.Name = "btnGetInvoice";
            this.btnGetInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnGetInvoice.TabIndex = 2;
            this.btnGetInvoice.Text = "Get Invoice";
            this.btnGetInvoice.UseVisualStyleBackColor = true;
            this.btnGetInvoice.Click += new System.EventHandler(this.btnGetInvoice_Click);
            // 
            // txtViewInvoiceNo
            // 
            this.txtViewInvoiceNo.Location = new System.Drawing.Point(88, 41);
            this.txtViewInvoiceNo.Name = "txtViewInvoiceNo";
            this.txtViewInvoiceNo.ReadOnly = true;
            this.txtViewInvoiceNo.Size = new System.Drawing.Size(132, 20);
            this.txtViewInvoiceNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Viewing:";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(103, 93);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(252, 20);
            this.txtInvoiceDate.TabIndex = 5;
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(88, 67);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.ReadOnly = true;
            this.txtVendor.Size = new System.Drawing.Size(267, 20);
            this.txtVendor.TabIndex = 6;
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(103, 119);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.ReadOnly = true;
            this.txtInvoiceTotal.Size = new System.Drawing.Size(252, 20);
            this.txtInvoiceTotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vendor:";
            // 
            // txtTerms
            // 
            this.txtTerms.Location = new System.Drawing.Point(103, 145);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.ReadOnly = true;
            this.txtTerms.Size = new System.Drawing.Size(252, 20);
            this.txtTerms.TabIndex = 9;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(103, 171);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(252, 20);
            this.txtDueDate.TabIndex = 10;
            // 
            // txtPaymentTotal
            // 
            this.txtPaymentTotal.Location = new System.Drawing.Point(103, 211);
            this.txtPaymentTotal.Name = "txtPaymentTotal";
            this.txtPaymentTotal.ReadOnly = true;
            this.txtPaymentTotal.Size = new System.Drawing.Size(252, 20);
            this.txtPaymentTotal.TabIndex = 11;
            // 
            // txtCreditTotal
            // 
            this.txtCreditTotal.Location = new System.Drawing.Point(103, 237);
            this.txtCreditTotal.Name = "txtCreditTotal";
            this.txtCreditTotal.ReadOnly = true;
            this.txtCreditTotal.Size = new System.Drawing.Size(252, 20);
            this.txtCreditTotal.TabIndex = 12;
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Location = new System.Drawing.Point(103, 263);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.ReadOnly = true;
            this.txtPaymentDate.Size = new System.Drawing.Size(252, 20);
            this.txtPaymentDate.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date Created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Terms:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date Due:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Payment Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Credit Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Date Paid:";
            // 
            // lboxInvoiceLineItems
            // 
            this.lboxInvoiceLineItems.FormattingEnabled = true;
            this.lboxInvoiceLineItems.Location = new System.Drawing.Point(22, 302);
            this.lboxInvoiceLineItems.Name = "lboxInvoiceLineItems";
            this.lboxInvoiceLineItems.Size = new System.Drawing.Size(224, 121);
            this.lboxInvoiceLineItems.TabIndex = 21;
            // 
            // btnAddInvoiceItem
            // 
            this.btnAddInvoiceItem.Location = new System.Drawing.Point(252, 400);
            this.btnAddInvoiceItem.Name = "btnAddInvoiceItem";
            this.btnAddInvoiceItem.Size = new System.Drawing.Size(103, 23);
            this.btnAddInvoiceItem.TabIndex = 22;
            this.btnAddInvoiceItem.Text = "Add Invoice Item";
            this.btnAddInvoiceItem.UseVisualStyleBackColor = true;
            this.btnAddInvoiceItem.Click += new System.EventHandler(this.btnAddInvoiceItem_Click);
            // 
            // btnModifyInvoiceItem
            // 
            this.btnModifyInvoiceItem.Location = new System.Drawing.Point(252, 302);
            this.btnModifyInvoiceItem.Name = "btnModifyInvoiceItem";
            this.btnModifyInvoiceItem.Size = new System.Drawing.Size(103, 50);
            this.btnModifyInvoiceItem.TabIndex = 23;
            this.btnModifyInvoiceItem.Text = "Modify/Delete Selected Item";
            this.btnModifyInvoiceItem.UseVisualStyleBackColor = true;
            this.btnModifyInvoiceItem.Click += new System.EventHandler(this.btnModifyInvoiceItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 438);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(227, 39);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(128, 23);
            this.btnAddInvoice.TabIndex = 25;
            this.btnAddInvoice.Text = "Create New Invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnModifyInvoice
            // 
            this.btnModifyInvoice.Location = new System.Drawing.Point(12, 438);
            this.btnModifyInvoice.Name = "btnModifyInvoice";
            this.btnModifyInvoice.Size = new System.Drawing.Size(130, 23);
            this.btnModifyInvoice.TabIndex = 26;
            this.btnModifyInvoice.Text = "Modify Selected Invoice";
            this.btnModifyInvoice.UseVisualStyleBackColor = true;
            this.btnModifyInvoice.Click += new System.EventHandler(this.btnModifyInvoice_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Location = new System.Drawing.Point(148, 438);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteInvoice.TabIndex = 27;
            this.btnDeleteInvoice.Text = "Delete Selected Invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 474);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnModifyInvoice);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModifyInvoiceItem);
            this.Controls.Add(this.btnAddInvoiceItem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPaymentDate);
            this.Controls.Add(this.txtCreditTotal);
            this.Controls.Add(this.txtPaymentTotal);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.txtTerms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtViewInvoiceNo);
            this.Controls.Add(this.btnGetInvoice);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxInvoiceLineItems);
            this.Name = "frmInvoice";
            this.Text = "Invoice Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Button btnGetInvoice;
        private System.Windows.Forms.TextBox txtViewInvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTerms;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.TextBox txtPaymentTotal;
        private System.Windows.Forms.TextBox txtCreditTotal;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lboxInvoiceLineItems;
        private System.Windows.Forms.Button btnAddInvoiceItem;
        private System.Windows.Forms.Button btnModifyInvoiceItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnModifyInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
    }
}