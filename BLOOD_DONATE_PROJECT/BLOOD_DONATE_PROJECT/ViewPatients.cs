using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLOOD_DONATE_PROJECT
{
    public partial class ViewPatients : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");

        public ViewPatients()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            txtPname.Text = "";
            txtPage.Text = "";
            cmbPgender.Text = "";
            txtPphone.Text = "";
            cmbPgroup.Text = "";
            txtPaddress.Text = "";
        }
        private void grdViewPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtPid.Text = grdViewPatient.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPname.Text = grdViewPatient.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPage.Text = grdViewPatient.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbPgender.Text = grdViewPatient.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPphone.Text = grdViewPatient.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbPgroup.Text = grdViewPatient.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPaddress.Text = grdViewPatient.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDoctorid.Text = grdViewPatient.Rows[e.RowIndex].Cells[8].Value.ToString();
                cmbDoctors.Text = grdViewPatient.Rows[e.RowIndex].Cells[9].Value.ToString();
            } catch { }
        }

        public void Doctorlist()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblDoctorRegister", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmbDoctors.DataSource = ds.Tables[0];
                cmbDoctors.ValueMember = "Dcid";
                cmbDoctors.DisplayMember = "DcName";
            }
            catch { }
        }

        private void ViewPatients_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblPatientRegister", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Patient");

            grdViewPatient.DataSource = ds.Tables[0];

            Doctorlist();
        }


        private void btnPedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPname.Text !="" && txtPaddress.Text != "" && txtPage.Text !="" && txtPphone.Text !="" && cmbPgroup.Text !="" && cmbPgender.Text!="")
                {
                    SqlCommand cmd = new SqlCommand("Update tblPatientRegister set Pname='" + txtPname.Text + "', Page='" + txtPage.Text + "',Pgender='" + cmbPgender.Text + "',Pphone='" + txtPphone.Text + "',PbloodGroup='" + cmbPgroup.Text + "',Paddress='" + txtPaddress.Text + "',Dcid='"+txtDoctorid.Text+"',DoctorName='"+cmbDoctors.Text+"' where Pid = '" + txtPid.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Updated Successfully !");
                    ViewPatients_Load(sender, e);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Select A Patient...","",MessageBoxButtons.OK);
                }
            }
            catch
            {

            }
        }

        private void btnPdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPname.Text != "" && txtPaddress.Text != "" && txtPage.Text != "" && txtPphone.Text != "" && cmbPgroup.Text != "" && cmbPgender.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Delete from tblPatientRegister where Pname='" + txtPname.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Deleted Successfully !");
                    ViewPatients_Load(sender, e);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Select A Patient...","",MessageBoxButtons.OK);
                }
            }
            catch 
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //private void btnBloodstock_Click(object sender, EventArgs e)
        //{
        //    BloodStock b1 = new BloodStock();
        //    b1.Show();
        //    this.Hide();
        //}


        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPphone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnViewdonors_Click_1(object sender, EventArgs e)
        {
            ViewDonors v1 = new ViewDonors();
            v1.Show();
            this.Hide();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            ViewPatients p1 = new ViewPatients();
            p1.Show();
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

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFindPatient.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("select * from tblPatientRegister where Pname='" + txtFindPatient.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DonorDetails");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        grdViewPatient.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found !");
                        ViewPatients_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Search An Record..");
                    txtFindPatient.Focus();
                }
            }
            catch 
            {

            }
        }

        private void grdViewPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDoctorid.Text = cmbDoctors.SelectedValue.ToString();
        }

        private void txtPname_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtPage_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtPphone_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtPphone_TextChanged(object sender, EventArgs e)
        {
            int cnt = txtPphone.Text.Count();
            lblPhoneCount.Text = cnt.ToString();
        }
    }
}
