using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace BLOOD_DONATE_PROJECT
{
    public partial class PatientDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");

        public PatientDetails()
        {
            InitializeComponent();
        }


        private void btnPsave_Click(object sender, EventArgs e)
        {
            string name, age, gender, phone, bloodgroup, address,date,Dcname;
            int dcid;

            name = txtPname.Text;
            age = txtPage.Text;
            gender = cmbPgender.Text;
            phone = txtPphone.Text;
            bloodgroup = cmbPgroup.Text;
            address = txtPaddress.Text;
            date = PatientRegDate.Text;
            Dcname= cmbDoctors.Text;
            dcid = Convert.ToInt32(txtDcid.Text);

            if (name == "" && age == "" && phone == "" && address == "")
            {
                MessageBox.Show("Enter All Credentials !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("insert into tblPatientRegister values('" + name + "','" + age + "','" + gender + "','" + phone + "','" + bloodgroup + "','" + address + "','"+date+"','"+dcid+"','"+Dcname+"')", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Patient");
                    MessageBox.Show("Patient Register Successfully");
                }
                catch 
                {
                    MessageBox.Show("Patient Already Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
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

        private void PatientDetails_Load(object sender, EventArgs e)
        {
            Doctorlist();
        }

        private void txtPphone_TextChanged(object sender, EventArgs e)
        {
            int cnt = txtPphone.Text.Count();
            lblPhoneCount.Text = cnt.ToString();
        }

        //private void btnBloodstock_Click(object sender, EventArgs e)
        //{
        //    BloodStock b1 = new BloodStock();
        //    b1.Show();
        //    this.Hide();
        //}

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


        private void btnDonor_Click_2(object sender, EventArgs e)
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

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientDetails v1 = new PatientDetails();
            v1.Show();
            this.Hide();
        }

        private void btnViewPatient_Click_1(object sender, EventArgs e)
        {
            ViewPatients v1 = new ViewPatients();
            v1.Show();
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

        private void cmbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDcid.Text= cmbDoctors.SelectedValue.ToString();
        }
    }
}
