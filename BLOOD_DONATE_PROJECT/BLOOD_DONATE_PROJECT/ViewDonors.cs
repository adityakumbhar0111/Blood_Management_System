using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BLOOD_DONATE_PROJECT
{
    public partial class ViewDonors : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");


        public ViewDonors()
        {
            InitializeComponent();
        }


        private void ViewDonors_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblDonorRegister",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"DonorDetails");

            grdViewdonors.DataSource = ds.Tables[0];
        }



        private void btnFindDonor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFindDonor.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("select * from tblDonorRegister where Dname='" + txtFindDonor.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DonorDetails");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        grdViewdonors.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found !");
                        ViewDonors_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Search An Record..");
                    txtFindDonor.Focus();
                }
            }
            catch
            {
                
            }
        }


        //private void btnBloodstock_Click(object sender, EventArgs e)
        //{
        //    BloodStock b1 = new BloodStock();
        //    b1.Show();
        //    this.Hide();
        //}


        private void grdViewdonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDid.Text = grdViewdonors.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDname.Text = grdViewdonors.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDage.Text = grdViewdonors.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbDgender.Text = grdViewdonors.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDphone.Text = grdViewdonors.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbDgroup.Text = grdViewdonors.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDaddress.Text = grdViewdonors.Rows[e.RowIndex].Cells[6].Value.ToString();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDid.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Delete from tblDonorRegister where DId='" + txtDid.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Deleted Successfully !");
                    ViewDonors_Load(sender, e);
                    txtDid.Text = "";
                }
                else
                {
                    MessageBox.Show("Select A Donor You Want To Delete..","",MessageBoxButtons.OKCancel);
                }
            }
            catch 
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void btnDonor_Click_1(object sender, EventArgs e)
        {
            DonorDetails d1 = new DonorDetails();
            d1.Show();
            this.Hide();
        }

        private void btnDonet_Click_1(object sender, EventArgs e)
        {
            Donet d1 = new Donet();
            d1.Show();
            this.Hide();
        }

        private void btnViewdonors_Click_2(object sender, EventArgs e)
        {
            ViewDonors v1 = new ViewDonors();
            v1.Show();
            this.Hide();
        }

        private void btnViewPatient_Click_1(object sender, EventArgs e)
        {
            ViewPatients v1 = new ViewPatients();
            v1.Show();
            this.Hide();
        }

        private void btnPatients_Click_1(object sender, EventArgs e)
        {
            PatientDetails p1 = new PatientDetails();
            p1.Show();
            this.Hide();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            SellingPage s1 = new SellingPage();
            s1.Show();
           
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void ClearData()
        {
            txtDname.Text = "";
            txtDage.Text = "";
            cmbDgender.Text = "";
            txtDphone.Text = "";
            cmbDgroup.Text = "";
            txtDaddress.Text = "";
        }
        private void btnPedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDname.Text != "" && txtDaddress.Text != "" && txtDage.Text != "" && txtDphone.Text != "" && cmbDgroup.Text != "" && cmbDgender.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Update tblDonorRegister set Dname='" + txtDname.Text + "', Dage='" + txtDage.Text + "',Dgender='" + cmbDgender.Text + "',Dphone='" + txtDphone.Text + "',DbloodGroup='" + cmbDgroup.Text + "',Daddress='" + txtDaddress.Text + "' where Did = '" + txtDid.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Updated Successfully !");
                    ViewDonors_Load(sender, e);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Select A Donor...", "", MessageBoxButtons.OK);
                }
            }
            catch 
            {

            }
        }

        private void txtDname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 08 || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 08)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 08)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDphone_TextChanged(object sender, EventArgs e)
        {
            int cnt = txtDphone.Text.Count();
            lblPhoneCount.Text = cnt.ToString();
        }
    }
}
