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
using System.Xml.Linq;

namespace BLOOD_DONATE_PROJECT
{
    public partial class Donet : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");

        public Donet()
        {
            InitializeComponent();
        }

        private void getDonors()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblDonorRegister", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "DonorDetails");

                grdViewDonors.DataSource = ds.Tables[0];
            }
            catch { }
        }

        private void getBloodStock()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblBloodStock", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "BloodStock");
            }
            catch { }
        }

        int oldStock;
        private void getCurrentBloodStock(string blood)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblBloodStock where BloodGroup='" + blood + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "CurrentBloodStock");

                oldStock = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
            }
            catch { }
        }

        private void Donet_Load(object sender, EventArgs e)
        {
            getDonors();
            getBloodStock();

        }

        private void grdViewDonors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDid.Text = grdViewDonors.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDonorName.Text = grdViewDonors.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDonorBg.Text = grdViewDonors.Rows[e.RowIndex].Cells[5].Value.ToString();
            getPreDate();
        }

        public void getPreDate()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblDonet where DId='" + txtDid.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                int count = ds.Tables[0].Rows.Count;

                txtPreDate.Text = ds.Tables[0].Rows[count - 1][3].ToString();
            }
            catch
            {
                MessageBox.Show("You Are New Donor ! ");
                txtPreDate.Visible = false;
            }
        }

        private void btnDonetDonor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDonorName.Text == "" || txtDonorBg.Text == "" || txtbagqty.Text == "" || txtCamp.Text == "")
                {
                    MessageBox.Show("Enter All Credentials !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime preDate = Convert.ToDateTime(txtPreDate.Text);
                    DateTime currDate = Convert.ToDateTime(DonetDate.Value);

                    DateTime ThreeMonth = preDate.AddMonths(3);


                    if (currDate >= ThreeMonth)
                    {
                        getCurrentBloodStock(txtDonorBg.Text);
                        int qty = Convert.ToInt32(txtbagqty.Text);

                        int stock = oldStock + qty;
                        SqlCommand cmd = new SqlCommand("update tblBloodStock set Stock='" + stock + "' where BloodGroup='" + txtDonorBg.Text + "'", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Stock");

                        SqlCommand cmd1 = new SqlCommand("insert into tblDonet values('" + txtDid.Text + "','" + txtDonorName.Text + "','" + txtDonorBg.Text + "','" + DonetDate.Text + "','" + txtbagqty.Text + "','" + txtCamp.Text + "')", con);
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1, "Donet");

                        MessageBox.Show("Blood Donate Successfully");
                        getBloodStock();
                    }
                    else
                    {
                        MessageBox.Show("You Are Not Eligible To Donet A Blood", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            catch {
                donetNewDonorBlood();
            }
        }

        public void donetNewDonorBlood()
        {
            getCurrentBloodStock(txtDonorBg.Text);
            int qty = Convert.ToInt32(txtbagqty.Text);

            int stock = oldStock + qty;
            SqlCommand cmd = new SqlCommand("update tblBloodStock set Stock='" + stock + "' where BloodGroup='" + txtDonorBg.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Stock");

            SqlCommand cmd1 = new SqlCommand("insert into tblDonet values('" + txtDid.Text + "','" + txtDonorName.Text + "','" + txtDonorBg.Text + "','" + DonetDate.Text + "','" + txtbagqty.Text + "','" + txtCamp.Text + "')", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "Donet");

            MessageBox.Show("Blood Donate Successfully");
            getBloodStock();
        }

        private void btnBloodstock_Click(object sender, EventArgs e)
        {
            BloodStock b1 = new BloodStock();
            b1.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnDonor_Click_1(object sender, EventArgs e)
        {
            DonorDetails d1 = new DonorDetails();
            d1.Show();
            this.Hide();
        }

        private void btnDonet_Click(object sender, EventArgs e)
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

        private void grdViewDonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDSearch.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("select * from tblDonorRegister where Dname='" + txtDSearch.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DonorDetails");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        grdViewDonors.DataSource = ds.Tables["DonorDetails"];
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found !");
                        Donet_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Search An Record..");
                    txtDSearch.Focus();
                }
            }
            catch { }
        }
    }
}
