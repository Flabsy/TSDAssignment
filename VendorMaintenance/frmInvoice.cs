using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorMaintenance
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        
        Invoice selectedInvoice;

        private void btnGetVendor_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtInvoiceNo))
            {
                try
                {
                    selectedInvoice =
                        (from invoice in DataContext.payables.Invoices
                         where invoice.InvoiceNumber == txtInvoiceNo.Text
                         select invoice).Single();
                    this.DisplayInvoice();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No invoice found with this number. " +
                        "Please try again.", "Invoice Not Found");
                    this.ClearControls();
                    txtInvoiceNo.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }


        private void DisplayInvoice()
        {
            txtViewInvoiceNo.Text = selectedInvoice.InvoiceNumber;
            txtVendorID.Text = selectedInvoice.VendorID.ToString();
            txtInvoiceDate.Text = selectedInvoice.InvoiceDate.ToString();
            txtPaymentTotal.Text = selectedInvoice.PaymentTotal.ToString();
            txtInvoiceTotal.Text = selectedInvoice.InvoiceTotal.ToString();
            txtCreditTotal.Text = selectedInvoice.CreditTotal.ToString();
            txtTermsID.Text = selectedInvoice.TermsID.ToString();
            txtPaymentDate.Text = selectedInvoice.PaymentDate.ToString();
            txtDueDate.Text = selectedInvoice.DueDate.ToString();
            //btnModify.Enabled = true;
            //btnDelete.Enabled = true;
        }

        private void ClearControls()
        {
            txtViewInvoiceNo.Text = "";
            txtVendorID.Text = "";
            txtInvoiceDate.Text = "";
            txtPaymentTotal.Text = "";
            txtInvoiceTotal.Text = "";
            txtCreditTotal.Text = "";
            txtTermsID.Text = "";
            txtPaymentDate.Text = "";
            txtDueDate.Text = "";
            //btnModify.Enabled = false;
            //btnDelete.Enabled = false;
        }

    }
}
