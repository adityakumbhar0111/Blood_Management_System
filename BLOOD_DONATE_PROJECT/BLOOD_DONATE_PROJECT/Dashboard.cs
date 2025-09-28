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
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");

        public Dashboard()
        {
            InitializeComponent();
        }

      

        //private void btnBloodstock_Click(object sender, EventArgs e)
        //{
        //    BloodStock b1 = new BloodStock();
        //    b1.Show();
        //    this.Hide();
        //}

       

        private void getDonor()
        {
            SqlCommand cmd = new SqlCommand("select * from tblDonorRegister",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int count = ds.Tables[0].Rows.Count;
            lblDonorCount.Text = count.ToString();
        }

        private void getPatient()
        {
            SqlCommand cmd = new SqlCommand("select * from tblPatientRegister", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int count = ds.Tables[0].Rows.Count;
            lblPatientCount.Text = count.ToString();
        }

        private void getUser()
        {
            SqlCommand cmd = new SqlCommand("select * from tblRegister", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int count = ds.Tables[0].Rows.Count;
            lblUserCount.Text = count.ToString();
        }

        private void getBloodStock()
        {
            SqlCommand cmd = new SqlCommand("select * from tblBloodStock", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            string countA = ds.Tables[0].Rows[0][1].ToString();
            lblAP.Text = countA.ToString();
            pbrA.Value = Convert.ToInt32(countA);

            string countO = ds.Tables[0].Rows[6][1].ToString();
            lblOP.Text = countO.ToString();
            pbrO.Value = Convert.ToInt32(countO);

            string countB = ds.Tables[0].Rows[4][1].ToString();
            lblBP.Text = countB.ToString();
            pbrB.Value = Convert.ToInt32(countB);

            string countAB = ds.Tables[0].Rows[2][1].ToString();
            lblABP.Text = countAB.ToString();
            pbrABP.Value = Convert.ToInt32(countAB);

            string countABN = ds.Tables[0].Rows[3][1].ToString();
            lblABNEG.Text = countABN.ToString();
            pbrABN.Value = Convert.ToInt32(countABN);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            getDonor();
            getPatient();
            getUser();
            getBloodStock();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void btnReciept_Click(object sender, EventArgs e)
        {
            DonationReceipt d1 = new DonationReceipt();
            d1.Show();
     
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
            ViewDonors d1 = new ViewDonors();
            d1.Show();
            this.Hide();
        }

        private void btnPatients_Click_1(object sender, EventArgs e)
        {
            PatientDetails d1 = new PatientDetails();
            d1.Show();
            this.Hide();
        }

        private void btnViewPatient_Click_1(object sender, EventArgs e)
        {
            ViewPatients d1 = new ViewPatients();
            d1.Show();
            this.Hide();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            SellingPage s1 = new SellingPage();
            s1.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            d1.Show();
            this.Hide();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Login d1 = new Login();
            d1.Show();
            this.Hide();
        }

        private void btnBstock_Click(object sender, EventArgs e)
        {
            BloodStock s1 = new BloodStock();
            s1.Show();
        }

        private void btnDoctorReg_Click(object sender, EventArgs e)
        {
            Doctor d1 = new Doctor();
            d1.Show();
        }
    }
}
