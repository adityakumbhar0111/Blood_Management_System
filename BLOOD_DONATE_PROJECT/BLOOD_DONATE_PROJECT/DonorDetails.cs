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
    public partial class DonorDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");

        public DonorDetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void lblViewDonor_Click(object sender, EventArgs e)
        {
            DonorDetails d1 = new DonorDetails();
            d1.Show();
            this.Hide();
        }

        private void btnViewdonors_Click(object sender, EventArgs e)
        {
            ViewDonors v1 = new ViewDonors();
            v1.Show();
            this.Hide();
        }

        private void btnDsave_Click(object sender, EventArgs e)
        {
            string name,age,gender,phone,bloodgroup,address,date;
            name = txtDname.Text;
            age = txtDage.Text;
            gender = cmbDgender.Text;
            phone = txtDphone.Text;
            bloodgroup = cmbDgroup.Text;
            address = txtDaddress.Text;
            date = DonorRegDate.Text;

            if (name == "" && age == "" && phone == "" && address == "")
            {
                MessageBox.Show("Enter All Credentials !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {  
                        SqlCommand cmd = new SqlCommand("insert into tblDonorRegister values('" + name + "','" + age + "','" + gender + "','" + phone + "','" + bloodgroup + "','" + address + "','"+date+"')", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Donor");
                        MessageBox.Show("Donor Register Successfully");    
                }
                catch 
                {
                    MessageBox.Show("Donor Already Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientDetails p1 = new PatientDetails();
            p1.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void btnViewdonors_Click_1(object sender, EventArgs e)
        {
            ViewDonors v1 = new ViewDonors();
            v1.Show();
            this.Hide();
        }

        private void btnPatients_Click_1(object sender, EventArgs e)
        {
            PatientDetails p1 = new PatientDetails();
            p1.Show();
            this.Hide();
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            ViewPatients v1 = new ViewPatients();
            v1.Show();
            this.Hide();
        }

        private void btnDonet_Click(object sender, EventArgs e)
        {
            Donet d1 = new Donet();
            d1.Show();
            this.Hide();
        }

        private void DonorDetails_Load(object sender, EventArgs e)
        {
            lblDeases.Visible = false;
            btnDsave.Visible = false;
        }

        private void lblPhoneCount_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDphone_TextChanged(object sender, EventArgs e)
        {
            int cnt = txtDphone.Text.Count();
            lblPhoneCount.Text = cnt.ToString();
        }

        private void btnBloodstock_Click(object sender, EventArgs e)
        {
            BloodStock b1 = new BloodStock();
            b1.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SellingPage s1 = new SellingPage();
            s1.Show();
   
        }

        private void btnDashboard_Click(object sender, EventArgs e)
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

        private void txtDphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar>=48 &&  e.KeyChar<=57 || e.KeyChar== 08)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYes.Checked)
            {
                lblDeases.Visible = true;
                btnDsave.Visible = false;
            }
            else if (rdoNo.Checked)
            {
                lblDeases.Visible = false;
                btnDsave.Visible = true;
            }
        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYes.Checked)
            {
                lblDeases.Visible = true;
                btnDsave.Visible = false;
            }
            else if (rdoNo.Checked)
            {
                lblDeases.Visible = false;
                btnDsave.Visible = true;
            }
        }
    }
}
