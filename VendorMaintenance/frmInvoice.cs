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
        List<InvoiceLineItem> selectedLineItems;
        Term selectedTerms;
        Vendor selectedVendor;

        private void btnGetInvoice_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtInvoiceNo))
            {
                try
                {
                    selectedInvoice =
                        (from invoice in DataContext.payables.Invoices
                         where invoice.InvoiceNumber == txtInvoiceNo.Text
                         select invoice).Single();

                    selectedTerms = (from term in DataContext.payables.Terms
                                          where term.TermsID == selectedInvoice.TermsID
                                          select term).Single();

                    selectedVendor = (from vendor in DataContext.payables.Vendors
                                      where vendor.VendorID == selectedInvoice.VendorID
                                      select vendor).Single();
                    
                    selectedLineItems =
                        (from invoicelineitem in DataContext.payables.InvoiceLineItems
                         where invoicelineitem.InvoiceID == selectedInvoice.InvoiceID
                         select invoicelineitem).ToList();

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
            txtVendor.Text = selectedVendor.Name;
            txtInvoiceDate.Text = selectedInvoice.InvoiceDate.ToString();
            txtPaymentTotal.Text = selectedInvoice.PaymentTotal.ToString("C");
            txtInvoiceTotal.Text = selectedInvoice.InvoiceTotal.ToString("C");
            txtCreditTotal.Text = selectedInvoice.CreditTotal.ToString("C");
            txtTerms.Text = selectedTerms.Description;
            txtPaymentDate.Text = selectedInvoice.PaymentDate.ToString();
            txtDueDate.Text = selectedInvoice.DueDate.ToString();
            lboxInvoiceLineItems.DataSource = selectedLineItems;
        }

        private void ClearControls()
        {
            txtViewInvoiceNo.Text = "";
            txtVendor.Text = "";
            txtInvoiceDate.Text = "";
            txtPaymentTotal.Text = "";
            txtInvoiceTotal.Text = "";
            txtCreditTotal.Text = "";
            txtTerms.Text = "";
            txtPaymentDate.Text = "";
            txtDueDate.Text = "";
            lboxInvoiceLineItems.DataSource = null;
        }

        private void btnModifyInvoiceItem_Click(object sender, EventArgs e)
        {

            if (selectedInvoice == null)
            {
                MessageBox.Show("No invoice loaded.");
                return;
            }

            if (lboxInvoiceLineItems.SelectedItem == null) 
            {
                MessageBox.Show("You must select a line item to modify.");
                return;
            }
            object selectedLineItem = lboxInvoiceLineItems.SelectedItem;

            frmAddModifyInvoiceLineItem editLineItemForm = new frmAddModifyInvoiceLineItem();

            editLineItemForm.addInvoiceLineItem = false;
            editLineItemForm.lineItem = (InvoiceLineItem)selectedLineItem;
            editLineItemForm.invoiceID = selectedInvoice.InvoiceID;
            editLineItemForm.invoice = selectedInvoice.InvoiceNumber;
            editLineItemForm.DisplayLineItem();

            DialogResult result = editLineItemForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedLineItems[lboxInvoiceLineItems.SelectedIndex] = editLineItemForm.lineItem;

                this.ClearControls();
                this.DisplayInvoice();
            }
            
        }

        private void btnAddInvoiceItem_Click(object sender, EventArgs e)
        {

            if (selectedInvoice == null)
            {
                MessageBox.Show("No invoice loaded.");
                return;
            }
            
            frmAddModifyInvoiceLineItem editLineItemForm = new frmAddModifyInvoiceLineItem();

            InvoiceLineItem lineItem = new InvoiceLineItem();
            lineItem.InvoiceSequence = short.Parse((selectedLineItems.Count + 1).ToString());
            lineItem.InvoiceID = selectedInvoice.InvoiceID;
            editLineItemForm.addInvoiceLineItem = true;

            editLineItemForm.lineItem = lineItem;
            editLineItemForm.invoiceID = selectedInvoice.InvoiceID;
            editLineItemForm.invoice = selectedInvoice.InvoiceNumber;
            editLineItemForm.DisplayLineItem();

            DialogResult result = editLineItemForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedLineItems.Add(editLineItemForm.lineItem);

                this.ClearControls();
                this.DisplayInvoice();
            } 
            else if (result == DialogResult.Cancel)
            {

                this.ClearControls();
                this.DisplayInvoice();
            }
        }
    }
}
