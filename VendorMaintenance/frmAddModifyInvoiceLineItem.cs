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
    public partial class frmAddModifyInvoiceLineItem : Form
    {
        public InvoiceLineItem lineItem;
        public bool addInvoiceLineItem;
        public string invoice;
        public int invoiceID;


        public frmAddModifyInvoiceLineItem()
        {
            InitializeComponent();
        }


        public void DisplayLineItem()
        {
            //txtAccNo.Text = lineItem.AccountNo.ToString();
            txtAmount.Text = lineItem.Amount.ToString("C");
            txtDescription.Text = lineItem.Description;
            txtInvoiceNo.Text = this.invoice;
            txtItemNo.Text = lineItem.InvoiceSequence.ToString();

            //List<InvoiceLineItem> accounts = from GLAccount in DataContext.payables.GLAccounts
            //           orderby GLAccount.AccountNo
            //           select new { GLAccount.AccountNo, GLAccount.Description };

            var accounts = (from acc in DataContext.payables.GLAccounts select acc);

            var accountDict = new Dictionary<int, string>();
            foreach (var acc in accounts)
            {
                accountDict.Add(acc.AccountNo, acc.AccountNo + ": " + acc.Description);
            }

            cboxAccNo.DataSource = accountDict.ToList();
            cboxAccNo.DisplayMember = "Value";
            cboxAccNo.ValueMember = "Key";
            cboxAccNo.SelectedValue = lineItem.AccountNo;

        }

        public bool IsValidData()
        {
            GLAccount selectedAccount;

            if (cboxAccNo.SelectedValue == null)
            {
                MessageBox.Show("Please select an account.");
                return false;
            }

            selectedAccount =
                        (from GLaccount in DataContext.payables.GLAccounts
                         where GLaccount.AccountNo == int.Parse(cboxAccNo.SelectedValue.ToString())
                         select GLaccount).Single();

            if (selectedAccount == null) { return false; } 

            return true;
        }

        private void PutInvoiceLineItemData(InvoiceLineItem lineItem)
        {
            lineItem.Description = txtDescription.Text;
            lineItem.Amount = decimal.Parse(txtAmount.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
            try
            {
                lineItem.Amount = decimal.Parse(txtAmount.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number);
            }
            catch
            {
                MessageBox.Show("Amount must be a decimal figure (##.##)");
                return;
            }
            try
            {
                lineItem.AccountNo = Convert.ToInt32(cboxAccNo.SelectedValue);
            }
            catch
            {
                MessageBox.Show("AccountNo must be a number.");
                return;
            }
            lineItem.InvoiceID = invoiceID;
            lineItem.InvoiceSequence = short.Parse(txtItemNo.Text);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addInvoiceLineItem)
                {
                    lineItem = new InvoiceLineItem();
                    this.PutInvoiceLineItemData(lineItem);
                    DataContext.payables.InvoiceLineItems.InsertOnSubmit(lineItem);
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
                    this.PutInvoiceLineItemData(lineItem);
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
    }
}
