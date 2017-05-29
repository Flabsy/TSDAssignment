using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Linq.Expressions;
using System.Data.OleDb;
using System.Data.SqlClient;

/**
 * NC-4 Create Account
 * NC-5 Set up and run stored procedure only if Customer Name is present.
 * NC-6 Create the connection.
 * NC-7 Create a SQLCommand, and identify it as a stored procedure.
 * NC-8 Add Input parameter from the stored procedure and specify what to use as its value.
 * NC-9 Add output parameter
 * NC-10 Try-Catch Finally
 * NC-11 Open the Connection
 * NC-12 Run the stored procedure
 * NC-14 A Simple Catch
 * NC-15 Close the Connection
 */


namespace VendorMaintenance
{
    public partial class frmSummaryVendor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Payables;Integrated Security=True");
        private PayablesDataContext db = new PayablesDataContext();
        //private VendorsSummary tbl_VendorsSummary;
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private int ID = 0;

        public frmSummaryVendor()
        {
            InitializeComponent();
        }

        //Insert Data
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Boolean vendorExists = false;
            if (txtbox_VendorID.Text != "")
            {
                con.Open();
                do{
                    cmd = new SqlCommand("insert into VendorsSummary" +
                        "(VendorID, SumOfInvoices, LastInvoiceDate, SumOfPayments, LastPaymentDate, SumOfCredits, BalanceDue) " +
                        "values(@id, @sumOfInvoices, @lastInvoiceDate, @sumOfPayments, @lastPaymentDate, @sumOfCredits, @balanceDue)",
                        con);
                    cmd.Parameters.AddWithValue("@id", txtbox_VendorID.Text);
                    cmd.Parameters.AddWithValue("@balanceDue", txtbox_BalanceDue.Text);
                    cmd.Parameters.AddWithValue("@lastInvoiceDate", txtbox_LastInvoiceDate.Text);
                    cmd.Parameters.AddWithValue("@lastPaymentDate", txtbox_LastPaymentDate.Text);
                    cmd.Parameters.AddWithValue("@sumOfCredits", txtbox_SumOfCredits.Text);
                    cmd.Parameters.AddWithValue("@sumOfInvoices", txtbox_SumOfInvoices.Text);
                    cmd.Parameters.AddWithValue("@sumOfPayments", txtbox_SumOfPayments.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        vendorExists = true;
                    }
                    catch (SqlException) {
                        MessageBox.Show("A Vendor MUST Exist before Inserting VendorSummary");
                        btn_AddVendor_Click(sender, e);
                    }
                }while(vendorExists == false);

                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        //Display Data in ...[Enter View]
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from VendorsSummary", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //Clear Data
        private void ClearData()
        {
            txtbox_SumOfPayments.Text = "";
            txtbox_SumOfInvoices.Text = "";
            txtbox_SumOfCredits.Text = "";
            txtbox_LastPaymentDate.Text = "";
            txtbox_LastInvoiceDate.Text = "";
            txtbox_BalanceDue.Text = "";
            ID = 0;
        }

        //dataGridView1 RowHeaderMoustClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtbox_VendorID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbox_SumOfInvoices.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbox_LastInvoiceDate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbox_SumOfPayments.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbox_LastPaymentDate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtbox_SumOfCredits.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtbox_BalanceDue.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        //Update Record
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtbox_VendorID.Text != "")
            {
                cmd = new SqlCommand("update VendorsSummary set SumOfInvoices=@sumOfInvoices,LastInvoiceDate=@lastInvoiceDate," +
                    "SumOfPayments=@sumOfPayments,LastPaymentDate=@lastPaymentDate,SumOfCredits=@sumOfCredits,BalanceDue=@balanceDue where VendorID=@id", con);
                con.Open();
                //PayablesDataContext PDB = new PayablesDataContext();
                cmd.Parameters.AddWithValue("@id", txtbox_VendorID.Text);
                cmd.Parameters.AddWithValue("@balanceDue", txtbox_BalanceDue.Text);
                cmd.Parameters.AddWithValue("@lastInvoiceDate", txtbox_LastInvoiceDate.Text);
                cmd.Parameters.AddWithValue("@lastPaymentDate", txtbox_LastPaymentDate.Text);
                cmd.Parameters.AddWithValue("@sumOfCredits", txtbox_SumOfCredits.Text);
                cmd.Parameters.AddWithValue("@sumOfInvoices", txtbox_SumOfInvoices.Text);
                cmd.Parameters.AddWithValue("@sumOfPayments", txtbox_SumOfPayments.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        //Delete Record
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete VendorsSummary where VendorID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }

        private void frmSummaryVendor_Load(object sender, EventArgs e)
        {
            this.vendorsSummaryTableAdapter.Fill(this.payablesDataSet.VendorsSummary);
        }


        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (txtbox_VendorID.Text != "")
            {
                var searchValue = txtbox_VendorID.Text;
                int rowIndex = -1;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["vendorIDDataGridViewTextBoxColumn"].Value != null)
                    {
                        if (row.Cells["vendorIDDataGridViewTextBoxColumn"].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;

                            txtbox_SumOfInvoices.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                            txtbox_LastInvoiceDate.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                            txtbox_SumOfPayments.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                            txtbox_LastPaymentDate.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                            txtbox_SumOfCredits.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                            txtbox_BalanceDue.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();

                            break;
                        }
                    }
                }
            }
        }

        private void btn_AddVendor_Click(object sender, EventArgs e)
        {
            frmAddModifyVendor addModifyVendorForm = new frmAddModifyVendor();
            addModifyVendorForm.addVendor = true;
            DialogResult result = addModifyVendorForm.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
