using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLOOD_DONATE_PROJECT
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if(txtpassword.Text == "")
            {
                MessageBox.Show("Enter A Password !","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            if (txtpassword.Text == "admin")
            {
                Employe e1 = new Employe();
                e1.Show();
                this.Hide();
            }
            else
            {
                lblErrorPass.Text = "Incorrect Password";
                lblErrorPass.ForeColor = Color.Red;
                //MessageBox.Show("Invalid Password !","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblErrorPass.Text = "";
            txtpassword.Focus();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
