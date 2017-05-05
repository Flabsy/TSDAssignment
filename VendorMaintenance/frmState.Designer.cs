namespace VendorMaintenance
{
    partial class frmState
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStateName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZip1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.btnGetVendor = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtZip2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "State Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "State Name:";
            // 
            // txtStateName
            // 
            this.txtStateName.Location = new System.Drawing.Point(97, 92);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Size = new System.Drawing.Size(119, 20);
            this.txtStateName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Zip:";
            // 
            // txtZip1
            // 
            this.txtZip1.Location = new System.Drawing.Point(97, 140);
            this.txtZip1.Name = "txtZip1";
            this.txtZip1.Size = new System.Drawing.Size(56, 20);
            this.txtZip1.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(96, 238);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(279, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboStates
            // 
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(96, 45);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(57, 21);
            this.cboStates.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Get Vendor ID:";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(96, 10);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(57, 20);
            this.txtVendorID.TabIndex = 13;
            // 
            // btnGetVendor
            // 
            this.btnGetVendor.Location = new System.Drawing.Point(177, 8);
            this.btnGetVendor.Name = "btnGetVendor";
            this.btnGetVendor.Size = new System.Drawing.Size(75, 23);
            this.btnGetVendor.TabIndex = 14;
            this.btnGetVendor.Text = "Get Vendor";
            this.btnGetVendor.UseVisualStyleBackColor = true;
            this.btnGetVendor.Click += new System.EventHandler(this.btnGetVendor_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtZip2
            // 
            this.txtZip2.Location = new System.Drawing.Point(97, 184);
            this.txtZip2.Name = "txtZip2";
            this.txtZip2.Size = new System.Drawing.Size(56, 20);
            this.txtZip2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Final Zip:";
            // 
            // frmState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 292);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGetVendor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtZip2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStateName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmState";
            this.Text = "frmState";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStateName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Button btnGetVendor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtZip2;
        private System.Windows.Forms.Label label4;
    }
}