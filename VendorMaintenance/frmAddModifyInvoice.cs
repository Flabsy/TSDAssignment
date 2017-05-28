using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorMaintenance
{
    public partial class frmAddModifyInvoice : Form
    {
        public frmAddModifyInvoice()
        {
            InitializeComponent();


            var terms = (from term in DataContext.payables.Terms select term);
            var termDict = new Dictionary<int, string>();
            foreach (var term in terms)
            {
                termDict.Add(term.TermsID, term.Description);
            }
            cboxTerms.DataSource = termDict.ToList();
            cboxTerms.DisplayMember = "Value";
            cboxTerms.ValueMember = "Key";


            var vendors = (from vendor in DataContext.payables.Vendors select vendor);
            var vendorDict = new Dictionary<int, string>();
            foreach (var vendor in vendors)
            {
                vendorDict.Add(vendor.VendorID, vendor.Name);
            }
            cboxVendor.DataSource = vendorDict.ToList();
            cboxVendor.DisplayMember = "Value";
            cboxVendor.ValueMember = "Key";

        
        }


        public Invoice theInvoice;
        public Term theTerm;
        public Vendor theVendor;
        public bool addInvoice;

        public void DisplayInvoice()
        {
            txtInvoiceNumber.Text = theInvoice.InvoiceNumber;
            txtCreditTotal.Text = theInvoice.CreditTotal.ToString("C");
            txtPaymentTotal.Text = theInvoice.PaymentTotal.ToString("C");
            dateCreated.Value = theInvoice.InvoiceDate;
            dateDue.Value = theInvoice.DueDate;
            datePaid.Value = (DateTime) theInvoice.PaymentDate;
            cboxTerms.SelectedValue = theInvoice.TermsID;
            cboxVendor.SelectedValue = theInvoice.VendorID;
        }

        private bool IsValidData() { return true; }

        private void PutInvoice(Invoice invoice)
        {
            theInvoice.InvoiceNumber = txtInvoiceNumber.Text;
            try
            {
                theInvoice.CreditTotal = decimal.Parse(txtCreditTotal.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
                theInvoice.PaymentTotal = decimal.Parse(txtPaymentTotal.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
            }
            catch
            {
                MessageBox.Show("Dollar amounts must be a decimal figure (##.##)");
                return;
            }
            theInvoice.PaymentDate = datePaid.Value;
            theInvoice.DueDate = dateDue.Value;
            theInvoice.InvoiceDate = dateCreated.Value;
            theInvoice.VendorID = (int) cboxVendor.SelectedValue;
            theInvoice.TermsID = (int) cboxTerms.SelectedValue;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addInvoice)
                {

                    Invoice checkInvoice = null;
                    try
                    {
                        checkInvoice =
                            (from invoice in DataContext.payables.Invoices
                             where invoice.InvoiceNumber == txtInvoiceNumber.Text
                             select invoice).Single();
                    }
                    catch
                    {}

                    if (checkInvoice != null) { 
                        MessageBox.Show("An invoice with that number already exists!");
                        return;
                    }

                    theInvoice = new Invoice();
                    this.PutInvoice(theInvoice);
                    DataContext.payables.Invoices.InsertOnSubmit(theInvoice);

                    try
                    {
                        DataContext.payables.SubmitChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    this.PutInvoice(theInvoice);
                    try
                    {
                        DataContext.payables.SubmitChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (ChangeConflictException)
                    {
                        DataContext.GetCurrentValues();
                        if (DataContext.vendorDeleted)
                        {
                            MessageBox.Show("Another user has deleted " +
                                "that vendor.", "Database Error");
                            this.DialogResult = DialogResult.Abort;
                        }
                        else
                        {
                            MessageBox.Show("Another user has updated " +
                                "that vendor.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
