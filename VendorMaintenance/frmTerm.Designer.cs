namespace VendorMaintenance
{
    partial class frmTerm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDueDay = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Term ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Due Day:";
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(80, 18);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(40, 20);
            this.txtVendorID.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Vendor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGetVendor_Click);
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(80, 60);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.ReadOnly = true;
            this.txtTerm.Size = new System.Drawing.Size(40, 20);
            this.txtTerm.TabIndex = 6;
            this.txtTerm.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(80, 100);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(286, 20);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.TabStop = false;
            // 
            // txtDueDay
            // 
            this.txtDueDay.Location = new System.Drawing.Point(80, 146);
            this.txtDueDay.Name = "txtDueDay";
            this.txtDueDay.ReadOnly = true;
            this.txtDueDay.Size = new System.Drawing.Size(100, 20);
            this.txtDueDay.TabIndex = 8;
            this.txtDueDay.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(100, 200);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(181, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(291, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 233);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDueDay);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTerm";
            this.Text = "frmTerm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDueDay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}