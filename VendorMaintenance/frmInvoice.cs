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
            if (Validator.IsPresent(txtInvoiceNo) &&
                Validator.IsInt32(txtInvoiceNo))
            {
                try
                {
                    selectedVendor =
                        (from vendor in DataContext.payables.Vendors
                         where vendor.VendorID == Convert.ToInt32(txtVendorID.Text)
                         select vendor).Single();
                    this.DisplayVendor();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No vendor found with this ID. " +
                        "Please try again.", "Vendor Not Found");
                    this.ClearControls();
                    txtVendorID.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }



    }
}
