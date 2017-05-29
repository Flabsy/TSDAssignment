namespace VendorMaintenance
{

    using System.Windows.Forms;
    /**
     * Author: Nathan Genikas
     * Date: 01/05/2017
     * Version:1.0.1
     * Description: Uses VendorID to display All fields from VendorsSummary Table.
     * VendorID, SumOfInvoices, 
     * LastInvoiceDate, SumOfPayments, 
     * LastPaymentDate, SumOfCredits, BalanceDue.
     */ 

    partial class frmSummaryVendor
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
            this.components = new System.ComponentModel.Container();
            this.lbl_VendorID = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.lbl_SumOfInvoices = new System.Windows.Forms.Label();
            this.lbl_LastInvoiceDate = new System.Windows.Forms.Label();
            this.lbl_SumOfPayments = new System.Windows.Forms.Label();
            this.lbl_PaymentDate = new System.Windows.Forms.Label();
            this.lbl_SumOfCredits = new System.Windows.Forms.Label();
            this.lbl_BalanceDue = new System.Windows.Forms.Label();
            this.txtbox_SumOfInvoices = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbox_BalanceDue = new System.Windows.Forms.TextBox();
            this.txtbox_SumOfCredits = new System.Windows.Forms.TextBox();
            this.txtbox_LastPaymentDate = new System.Windows.Forms.TextBox();
            this.txtbox_SumOfPayments = new System.Windows.Forms.TextBox();
            this.txtbox_LastInvoiceDate = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtbox_VendorID = new System.Windows.Forms.TextBox();
            this.btn_AddVendor = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOfInvoicesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastInvoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOfPaymentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPaymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOfCreditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorsSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payablesDataSet = new VendorMaintenance.PayablesDataSet();
            this.vendorsSummaryTableAdapter = new VendorMaintenance.PayablesDataSetTableAdapters.VendorsSummaryTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_VendorID
            // 
            this.lbl_VendorID.AutoSize = true;
            this.lbl_VendorID.Location = new System.Drawing.Point(3, 7);
            this.lbl_VendorID.Name = "lbl_VendorID";
            this.lbl_VendorID.Size = new System.Drawing.Size(55, 13);
            this.lbl_VendorID.TabIndex = 0;
            this.lbl_VendorID.Text = "Vendor ID";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(473, 352);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(264, 352);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(122, 23);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(3, 23);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(147, 23);
            this.btn_Load.TabIndex = 17;
            this.btn_Load.Text = "Get Summary";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // lbl_SumOfInvoices
            // 
            this.lbl_SumOfInvoices.AutoSize = true;
            this.lbl_SumOfInvoices.Location = new System.Drawing.Point(11, 12);
            this.lbl_SumOfInvoices.Name = "lbl_SumOfInvoices";
            this.lbl_SumOfInvoices.Size = new System.Drawing.Size(84, 13);
            this.lbl_SumOfInvoices.TabIndex = 2;
            this.lbl_SumOfInvoices.Text = "Sum Of invoices";
            // 
            // lbl_LastInvoiceDate
            // 
            this.lbl_LastInvoiceDate.AutoSize = true;
            this.lbl_LastInvoiceDate.Location = new System.Drawing.Point(11, 47);
            this.lbl_LastInvoiceDate.Name = "lbl_LastInvoiceDate";
            this.lbl_LastInvoiceDate.Size = new System.Drawing.Size(91, 13);
            this.lbl_LastInvoiceDate.TabIndex = 4;
            this.lbl_LastInvoiceDate.Text = "Last Invoice Date";
            // 
            // lbl_SumOfPayments
            // 
            this.lbl_SumOfPayments.AutoSize = true;
            this.lbl_SumOfPayments.Location = new System.Drawing.Point(11, 91);
            this.lbl_SumOfPayments.Name = "lbl_SumOfPayments";
            this.lbl_SumOfPayments.Size = new System.Drawing.Size(91, 13);
            this.lbl_SumOfPayments.TabIndex = 6;
            this.lbl_SumOfPayments.Text = "Sum Of Payments";
            // 
            // lbl_PaymentDate
            // 
            this.lbl_PaymentDate.AutoSize = true;
            this.lbl_PaymentDate.Location = new System.Drawing.Point(11, 131);
            this.lbl_PaymentDate.Name = "lbl_PaymentDate";
            this.lbl_PaymentDate.Size = new System.Drawing.Size(97, 13);
            this.lbl_PaymentDate.TabIndex = 8;
            this.lbl_PaymentDate.Text = "Last Payment Date";
            // 
            // lbl_SumOfCredits
            // 
            this.lbl_SumOfCredits.AutoSize = true;
            this.lbl_SumOfCredits.Location = new System.Drawing.Point(11, 168);
            this.lbl_SumOfCredits.Name = "lbl_SumOfCredits";
            this.lbl_SumOfCredits.Size = new System.Drawing.Size(77, 13);
            this.lbl_SumOfCredits.TabIndex = 10;
            this.lbl_SumOfCredits.Text = "Sum Of Credits";
            // 
            // lbl_BalanceDue
            // 
            this.lbl_BalanceDue.AutoSize = true;
            this.lbl_BalanceDue.Location = new System.Drawing.Point(11, 200);
            this.lbl_BalanceDue.Name = "lbl_BalanceDue";
            this.lbl_BalanceDue.Size = new System.Drawing.Size(69, 13);
            this.lbl_BalanceDue.TabIndex = 12;
            this.lbl_BalanceDue.Text = "Balance Due";
            // 
            // txtbox_SumOfInvoices
            // 
            this.txtbox_SumOfInvoices.Location = new System.Drawing.Point(7, 12);
            this.txtbox_SumOfInvoices.Name = "txtbox_SumOfInvoices";
            this.txtbox_SumOfInvoices.Size = new System.Drawing.Size(346, 20);
            this.txtbox_SumOfInvoices.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 277);
            this.panel1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_SumOfInvoices);
            this.panel3.Controls.Add(this.lbl_LastInvoiceDate);
            this.panel3.Controls.Add(this.lbl_SumOfCredits);
            this.panel3.Controls.Add(this.lbl_PaymentDate);
            this.panel3.Controls.Add(this.lbl_BalanceDue);
            this.panel3.Controls.Add(this.lbl_SumOfPayments);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 271);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbox_BalanceDue);
            this.panel2.Controls.Add(this.txtbox_SumOfCredits);
            this.panel2.Controls.Add(this.txtbox_LastPaymentDate);
            this.panel2.Controls.Add(this.txtbox_SumOfPayments);
            this.panel2.Controls.Add(this.txtbox_LastInvoiceDate);
            this.panel2.Controls.Add(this.txtbox_SumOfInvoices);
            this.panel2.Location = new System.Drawing.Point(176, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 271);
            this.panel2.TabIndex = 20;
            // 
            // txtbox_BalanceDue
            // 
            this.txtbox_BalanceDue.Location = new System.Drawing.Point(7, 200);
            this.txtbox_BalanceDue.Name = "txtbox_BalanceDue";
            this.txtbox_BalanceDue.Size = new System.Drawing.Size(346, 20);
            this.txtbox_BalanceDue.TabIndex = 23;
            // 
            // txtbox_SumOfCredits
            // 
            this.txtbox_SumOfCredits.Location = new System.Drawing.Point(7, 168);
            this.txtbox_SumOfCredits.Name = "txtbox_SumOfCredits";
            this.txtbox_SumOfCredits.Size = new System.Drawing.Size(346, 20);
            this.txtbox_SumOfCredits.TabIndex = 22;
            // 
            // txtbox_LastPaymentDate
            // 
            this.txtbox_LastPaymentDate.Location = new System.Drawing.Point(7, 131);
            this.txtbox_LastPaymentDate.Name = "txtbox_LastPaymentDate";
            this.txtbox_LastPaymentDate.Size = new System.Drawing.Size(346, 20);
            this.txtbox_LastPaymentDate.TabIndex = 21;
            // 
            // txtbox_SumOfPayments
            // 
            this.txtbox_SumOfPayments.Location = new System.Drawing.Point(7, 91);
            this.txtbox_SumOfPayments.Name = "txtbox_SumOfPayments";
            this.txtbox_SumOfPayments.Size = new System.Drawing.Size(346, 20);
            this.txtbox_SumOfPayments.TabIndex = 20;
            // 
            // txtbox_LastInvoiceDate
            // 
            this.txtbox_LastInvoiceDate.Location = new System.Drawing.Point(7, 47);
            this.txtbox_LastInvoiceDate.Name = "txtbox_LastInvoiceDate";
            this.txtbox_LastInvoiceDate.Size = new System.Drawing.Size(346, 20);
            this.txtbox_LastInvoiceDate.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtbox_VendorID);
            this.panel4.Controls.Add(this.lbl_VendorID);
            this.panel4.Controls.Add(this.btn_Load);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(536, 51);
            this.panel4.TabIndex = 20;
            // 
            // txtbox_VendorID
            // 
            this.txtbox_VendorID.Location = new System.Drawing.Point(183, 7);
            this.txtbox_VendorID.Name = "txtbox_VendorID";
            this.txtbox_VendorID.Size = new System.Drawing.Size(346, 20);
            this.txtbox_VendorID.TabIndex = 1;
            // 
            // btn_AddVendor
            // 
            this.btn_AddVendor.Location = new System.Drawing.Point(12, 352);
            this.btn_AddVendor.Name = "btn_AddVendor";
            this.btn_AddVendor.Size = new System.Drawing.Size(122, 23);
            this.btn_AddVendor.TabIndex = 21;
            this.btn_AddVendor.Text = "Add Vendor";
            this.btn_AddVendor.UseVisualStyleBackColor = true;
            this.btn_AddVendor.Click += new System.EventHandler(this.btn_AddVendor_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(392, 352);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(140, 352);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(122, 23);
            this.btn_Insert.TabIndex = 23;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorIDDataGridViewTextBoxColumn,
            this.sumOfInvoicesDataGridViewTextBoxColumn,
            this.lastInvoiceDateDataGridViewTextBoxColumn,
            this.sumOfPaymentsDataGridViewTextBoxColumn,
            this.lastPaymentDateDataGridViewTextBoxColumn,
            this.sumOfCreditsDataGridViewTextBoxColumn,
            this.balanceDueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendorsSummaryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 236);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "VendorID";
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            // 
            // sumOfInvoicesDataGridViewTextBoxColumn
            // 
            this.sumOfInvoicesDataGridViewTextBoxColumn.DataPropertyName = "SumOfInvoices";
            this.sumOfInvoicesDataGridViewTextBoxColumn.HeaderText = "SumOfInvoices";
            this.sumOfInvoicesDataGridViewTextBoxColumn.Name = "sumOfInvoicesDataGridViewTextBoxColumn";
            // 
            // lastInvoiceDateDataGridViewTextBoxColumn
            // 
            this.lastInvoiceDateDataGridViewTextBoxColumn.DataPropertyName = "LastInvoiceDate";
            this.lastInvoiceDateDataGridViewTextBoxColumn.HeaderText = "LastInvoiceDate";
            this.lastInvoiceDateDataGridViewTextBoxColumn.Name = "lastInvoiceDateDataGridViewTextBoxColumn";
            // 
            // sumOfPaymentsDataGridViewTextBoxColumn
            // 
            this.sumOfPaymentsDataGridViewTextBoxColumn.DataPropertyName = "SumOfPayments";
            this.sumOfPaymentsDataGridViewTextBoxColumn.HeaderText = "SumOfPayments";
            this.sumOfPaymentsDataGridViewTextBoxColumn.Name = "sumOfPaymentsDataGridViewTextBoxColumn";
            // 
            // lastPaymentDateDataGridViewTextBoxColumn
            // 
            this.lastPaymentDateDataGridViewTextBoxColumn.DataPropertyName = "LastPaymentDate";
            this.lastPaymentDateDataGridViewTextBoxColumn.HeaderText = "LastPaymentDate";
            this.lastPaymentDateDataGridViewTextBoxColumn.Name = "lastPaymentDateDataGridViewTextBoxColumn";
            // 
            // sumOfCreditsDataGridViewTextBoxColumn
            // 
            this.sumOfCreditsDataGridViewTextBoxColumn.DataPropertyName = "SumOfCredits";
            this.sumOfCreditsDataGridViewTextBoxColumn.HeaderText = "SumOfCredits";
            this.sumOfCreditsDataGridViewTextBoxColumn.Name = "sumOfCreditsDataGridViewTextBoxColumn";
            // 
            // balanceDueDataGridViewTextBoxColumn
            // 
            this.balanceDueDataGridViewTextBoxColumn.DataPropertyName = "BalanceDue";
            this.balanceDueDataGridViewTextBoxColumn.HeaderText = "BalanceDue";
            this.balanceDueDataGridViewTextBoxColumn.Name = "balanceDueDataGridViewTextBoxColumn";
            // 
            // vendorsSummaryBindingSource
            // 
            this.vendorsSummaryBindingSource.DataMember = "VendorsSummary";
            this.vendorsSummaryBindingSource.DataSource = this.payablesDataSet;
            // 
            // payablesDataSet
            // 
            this.payablesDataSet.DataSetName = "PayablesDataSet";
            this.payablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsSummaryTableAdapter
            // 
            this.vendorsSummaryTableAdapter.ClearBeforeFill = true;
            // 
            // frmSummaryVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 633);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_AddVendor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Exit);
            this.Name = "frmSummaryVendor";
            this.Text = "frmSummaryVendor";
            this.Load += new System.EventHandler(this.frmSummaryVendor_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payablesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_VendorID;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Label lbl_SumOfInvoices;
        private System.Windows.Forms.Label lbl_LastInvoiceDate;
        private System.Windows.Forms.Label lbl_SumOfPayments;
        private System.Windows.Forms.Label lbl_PaymentDate;
        private System.Windows.Forms.Label lbl_SumOfCredits;
        private System.Windows.Forms.Label lbl_BalanceDue;
        private System.Windows.Forms.TextBox txtbox_SumOfInvoices;
        private System.Windows.Forms.Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtbox_BalanceDue;
        private TextBox txtbox_SumOfCredits;
        private TextBox txtbox_LastPaymentDate;
        private TextBox txtbox_SumOfPayments;
        private TextBox txtbox_LastInvoiceDate;
        private Panel panel4;
        private Button btn_AddVendor;
        private TextBox txtbox_VendorID;
        private Button btn_Delete;
        private Button btn_Insert;
        private DataGridView dataGridView1;
        private PayablesDataSet payablesDataSet;
        private BindingSource vendorsSummaryBindingSource;
        private PayablesDataSetTableAdapters.VendorsSummaryTableAdapter vendorsSummaryTableAdapter;
        private DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumOfInvoicesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastInvoiceDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumOfPaymentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastPaymentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumOfCreditsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDueDataGridViewTextBoxColumn;
    }
}