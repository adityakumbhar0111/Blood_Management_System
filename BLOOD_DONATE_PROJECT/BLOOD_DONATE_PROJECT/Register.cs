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
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblUname.Text = "";
        }


        private void Clear()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtcpassword.Text = "";
            lblError.Text = "";
            lblUname.Text = "";
        }
        
        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtcpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
                txtcpassword.PasswordChar = '*';
            }
        }

        private void btnReg_Click_1(object sender, EventArgs e)
        {
            string user, pass, cpass;
            user = txtusername.Text;
            pass = txtpassword.Text;
            cpass = txtcpassword.Text;

            if (user == "" && pass == "" && cpass == "")
            {
                MessageBox.Show("Enter All Credentials !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    if (txtusername.Text !="" && pass == cpass)
                    {
                        SqlCommand cmd = new SqlCommand("insert into tblRegister values('" + user + "','" + pass + "','" + cpass + "')", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Register");
                        MessageBox.Show("Register Successfully");
                        lblError.Text = "";
                        lblUname.Text = "";
                        Clear();
                        Register_Load(sender, e);
                    }
                    else
                    {
                        lblError.Text = "Incorrect Password";
                        lblUname.Text = "Enter Username";
                        lblError.ForeColor =Color.Red;
                    }
                }
                catch 
                {
                    MessageBox.Show("Username Already Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
            label2.BackColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
            label2.BackColor = Color.DarkMagenta;
        }
    }
}
