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
    public partial class DonationReciept : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");

        public DonationReciept()
        {
            InitializeComponent();
        }
        private void DonationReciept_Load(object sender, EventArgs e)
        {
            txtSearchDonor.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchDonor.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("select * from tblDonorRegister where Dname='" + txtSearchDonor.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DonorDetails");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtDusername.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtDage.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtDgender.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtDbg.Text = ds.Tables[0].Rows[0][5].ToString();

                        txtSearchDonor.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found");
                        txtSearchDonor.Text = "";
                        DonationReciept_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Donor Name...");
                }
            }
            catch { }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
            d1.Show();
            this.Hide();
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
            lblClose.BackColor = Color.White;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
            lblClose.BackColor = Color.DarkMagenta;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("welcome", new Font("Arial", 12, FontStyle.Regular),Brushes.Black,new Point(30,30));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
