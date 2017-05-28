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
            getInvoice();
        }

        private void getInvoice()
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


        private void updateTotalValue()
        {
            decimal newTotal = 0;
            foreach (var x in selectedLineItems) { newTotal += x.Amount; }
            selectedInvoice.InvoiceTotal = newTotal;

            try
            {
                DataContext.payables.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
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

                updateTotalValue();

                this.ClearControls();
                getInvoice();
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

            int sequence = 0;
            foreach (InvoiceLineItem invoiceLineItem in selectedLineItems) { 
                if (invoiceLineItem.InvoiceSequence > sequence) { sequence = invoiceLineItem.InvoiceSequence; } 
            }
            sequence++;

            lineItem.InvoiceSequence = (short) sequence;
            //lineItem.InvoiceSequence = short.Parse((selectedLineItems.Count + 1).ToString());

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

                updateTotalValue();

                this.ClearControls();
                this.DisplayInvoice();
            } 
            else if (result == DialogResult.Cancel)
            {

                this.ClearControls();
                this.DisplayInvoice();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete " + selectedInvoice.InvoiceNumber + "?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (InvoiceLineItem item in selectedLineItems)
                    {
                        DataContext.payables.InvoiceLineItems.DeleteOnSubmit(item);
                    }
                    DataContext.payables.Invoices.DeleteOnSubmit(selectedInvoice);
                    DataContext.payables.SubmitChanges();
                    this.ClearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnModifyInvoice_Click(object sender, EventArgs e)
        {
            

            frmAddModifyInvoice editInvoiceForm = new frmAddModifyInvoice();

            editInvoiceForm.theInvoice = this.selectedInvoice;
            editInvoiceForm.theTerm = selectedTerms;
            editInvoiceForm.theVendor = selectedVendor;
            editInvoiceForm.addInvoice = false;

            editInvoiceForm.DisplayInvoice();

            DialogResult result = editInvoiceForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtInvoiceNo.Text = editInvoiceForm.theInvoice.InvoiceNumber;
                this.ClearControls();
                getInvoice();
                this.DisplayInvoice();
            }


        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            frmAddModifyInvoice editInvoiceForm = new frmAddModifyInvoice();

            editInvoiceForm.theInvoice = new Invoice();
            editInvoiceForm.theTerm = selectedTerms;
            editInvoiceForm.theVendor = selectedVendor;
            editInvoiceForm.theInvoice.InvoiceNumber = "";
            editInvoiceForm.theInvoice.DueDate = DateTime.Now;
            editInvoiceForm.theInvoice.InvoiceDate = DateTime.Now;
            editInvoiceForm.theInvoice.PaymentDate = DateTime.Now;
            editInvoiceForm.theInvoice.TermsID = 1;
            editInvoiceForm.addInvoice = true;

            editInvoiceForm.DisplayInvoice();

            DialogResult result = editInvoiceForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.ClearControls();
                txtInvoiceNo.Text = editInvoiceForm.theInvoice.InvoiceNumber;
                getInvoice();
                this.DisplayInvoice();
            }
        }
    }
}
