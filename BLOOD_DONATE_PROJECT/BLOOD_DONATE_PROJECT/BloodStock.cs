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
    public partial class BloodStock : Form
    {
        SqlConnection con =  new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True;Connect Timeout=30");
        public BloodStock()
        {
            InitializeComponent();
            
        }

        private void getStock()
        {
            string stk = cmbBloodStock.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand("select * from tblBloodStock where BloodGroup='" + stk + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            grdViewCurrentStock.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows[0][1].ToString() == "0")
            {
                MessageBox.Show(stk+" Not Available !");
            }
        }
        private void BloodStock_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select BloodGroup,Stock from tblBloodStock", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "CurrentBloodStock");

            grdViewCurrentStock.DataSource = ds.Tables[0];
           
        }

        private void cmbBloodStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            getStock();
        }

    }
}
