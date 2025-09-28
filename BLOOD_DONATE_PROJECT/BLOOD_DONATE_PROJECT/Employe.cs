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
    public partial class Employe : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");

        public Employe()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void Employe_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from tblRegister", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");

            grdEmployee.DataSource = ds.Tables[0];
        }

        private void grdEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusername.Text = grdEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtpassword.Text = grdEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text != "" && txtpassword.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Update tblRegister set password='" + txtpassword.Text + "',cpassword='" + txtpassword.Text + "' where username='" + txtusername.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Updated Successfully !");
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    Employe_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Select A User !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtusername.Text !="" && txtpassword.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Delete from tblRegister where username='"+txtusername.Text+"'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Deleted Successfully !");
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    Employe_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Select A User !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Register r1 = new Register();
            r1.Show();
        }

        private void bntRefresh_Click(object sender, EventArgs e)
        {
            Employe_Load(sender, e);
        }
    }
}
