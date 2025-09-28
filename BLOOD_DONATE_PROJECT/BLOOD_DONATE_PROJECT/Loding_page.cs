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
    public partial class Loding_page : Form
    {
        public Loding_page()
        {
            InitializeComponent();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        int i = 1;
        private void Loding_page_Load(object sender, EventArgs e)
        {
            time.Start();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            i += 2;
            proBar.Value = i;
            lblcount.Text = i.ToString();

            if (i == 101)
            {
                time.Stop();
                proBar.Value = 0;
                Login l1 = new Login();
                l1.Show();  
                this.Hide();
            }
        }
    }
}
