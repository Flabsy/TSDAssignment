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
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTermsID = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number:";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(103, 13);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // btnGetInvoice
            // 
            this.btnGetInvoice.Location = new System.Drawing.Point(209, 11);
            this.btnGetInvoice.Name = "btnGetInvoice";
            this.btnGetInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnGetInvoice.TabIndex = 2;
            this.btnGetInvoice.Text = "Get Invoice";
            this.btnGetInvoice.UseVisualStyleBackColor = true;
            // 
            // txtViewInvoiceNo
            // 
            this.txtViewInvoiceNo.Location = new System.Drawing.Point(88, 48);
            this.txtViewInvoiceNo.Name = "txtViewInvoiceNo";
            this.txtViewInvoiceNo.ReadOnly = true;
            this.txtViewInvoiceNo.Size = new System.Drawing.Size(100, 20);
            this.txtViewInvoiceNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Viewing:";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(103, 84);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceDate.TabIndex = 5;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(255, 48);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.ReadOnly = true;
            this.txtVendorID.Size = new System.Drawing.Size(100, 20);
            this.txtVendorID.TabIndex = 6;
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Location = new System.Drawing.Point(103, 110);
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.ReadOnly = true;
            this.txtInvoiceTotal.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceTotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "VendorID:";
            // 
            // txtTermsID
            // 
            this.txtTermsID.Location = new System.Drawing.Point(103, 136);
            this.txtTermsID.Name = "txtTermsID";
            this.txtTermsID.ReadOnly = true;
            this.txtTermsID.Size = new System.Drawing.Size(100, 20);
            this.txtTermsID.TabIndex = 9;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(103, 162);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(100, 20);
            this.txtDueDate.TabIndex = 10;
            // 
            // txtPaymentTotal
            // 
            this.txtPaymentTotal.Location = new System.Drawing.Point(313, 84);
            this.txtPaymentTotal.Name = "txtPaymentTotal";
            this.txtPaymentTotal.ReadOnly = true;
            this.txtPaymentTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentTotal.TabIndex = 11;
            // 
            // txtCreditTotal
            // 
            this.txtCreditTotal.Location = new System.Drawing.Point(313, 110);
            this.txtCreditTotal.Name = "txtCreditTotal";
            this.txtCreditTotal.ReadOnly = true;
            this.txtCreditTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCreditTotal.TabIndex = 12;
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Location = new System.Drawing.Point(313, 136);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.ReadOnly = true;
            this.txtPaymentDate.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentDate.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date Made:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Terms ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date Due:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Payment Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Credit Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Date Paid:";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 244);
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
            this.Controls.Add(this.txtTermsID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtViewInvoiceNo);
            this.Controls.Add(this.btnGetInvoice);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label1);
            this.Name = "frmInvoice";
            this.Text = "Invoice";
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
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTermsID;
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
    }
}