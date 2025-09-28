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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r1 = new Register();
            r1.Show();
            this.Hide();
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtusername.Text;
            pass = txtpassword.Text;

            SqlCommand cmd = new SqlCommand("select * from tblRegister where username='" + user + "'and password='" + pass + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "register");

            if (user == "" && pass == "")
            {
                MessageBox.Show("Enter All Credentials !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string nuser = ds.Tables[0].Rows[0][0].ToString();
                    string npass = ds.Tables[0].Rows[0][1].ToString();
                    if (nuser == user && npass == pass)
                    {
                        MessageBox.Show("Login Successfully");
                        DonorDetails d1 = new DonorDetails(); 
                        d1.Show();
                        this.Hide();
                    }
                }
                catch 
                {
                    MessageBox.Show("Invalid Password !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPass.Checked)
            {
                txtpassword.PasswordChar ='\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            a1.Show();
            this.Hide();
        }
    }
}
