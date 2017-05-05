using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace VendorMaintenance
{
    public partial class frmState : Form
    {
        public frmState()
        {
            InitializeComponent();
        }

        Vendor selectedVendor;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyVendor addModifyVendorForm = new frmAddModifyVendor();
            addModifyVendorForm.addVendor = true;
            DialogResult result = addModifyVendorForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedVendor = addModifyVendorForm.vendor;
                txtVendorID.Text = selectedVendor.VendorID.ToString();
                this.DisplayVendor();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyVendor addModifyVendorForm = new frmAddModifyVendor();
            addModifyVendorForm.addVendor = false;
            addModifyVendorForm.vendor = selectedVendor;
            DialogResult result = addModifyVendorForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedVendor = addModifyVendorForm.vendor;
                this.DisplayVendor();
            }
            else if (result == DialogResult.Abort)
            {
                txtVendorID.Text = "";
                this.ClearControls();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Delete " + selectedVendor.Name + "?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataContext.payables.Vendors.DeleteOnSubmit(selectedVendor);
                    DataContext.payables.SubmitChanges();
                    txtVendorID.Text = "";
                    this.ClearControls();
                }
                catch (ChangeConflictException)
                {
                    DataContext.GetCurrentValues();
                    MessageBox.Show("Another user has updated that vendor.",
                        "Database Error");
                    this.DisplayVendor();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetVendor_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtVendorID) &&
                Validator.IsInt32(txtVendorID))
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

        private void ClearControls()
        {
            txtVendorID.Text = "";
            cboStates.Text = "";
            txtStateName.Text = "";
            txtZip1.Text = "";
            txtZip2.Text = "";
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void DisplayVendor()
        {
            cboStates.Text = selectedVendor.State1.StateCode;
            txtStateName.Text = selectedVendor.State1.StateName;
            txtZip1.Text = selectedVendor.State1.FirstZipCode.ToString();
            txtZip2.Text = selectedVendor.State1.LastZipCode.ToString();
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }
    }
}
