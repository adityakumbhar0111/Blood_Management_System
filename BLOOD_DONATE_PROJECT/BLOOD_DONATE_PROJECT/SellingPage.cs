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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLOOD_DONATE_PROJECT
{
    public partial class SellingPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");


        public SellingPage()
        {
            InitializeComponent();
        }

        public void sellId()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select max(SellId) from tblSellInfo", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                string id;

                id = ds.Tables[0].Rows[0][0].ToString();
                txtSellId.Text = (Convert.ToInt32(id) + 1).ToString();

            }
            catch
            {
                txtSellId.Text = "1";
            }
        }

        public void getPatient()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblPatientRegister", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmbPname.DataSource = ds.Tables[0];
                cmbPname.ValueMember = "Pid";
                cmbPname.DisplayMember = "Pname";
            }
            catch { }
        }

        public void getBG()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblBloodStock", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                cmbBg.DataSource = ds.Tables[0];
                cmbBg.ValueMember = "BloodPrice";
                cmbBg.DisplayMember = "BloodGroup";
            }
            catch { }
        }
        private void SellingPage_Load(object sender, EventArgs e)
        {
            sellId();
            getPatient();
            getBG();
            Dispgrid();
        }

        public void clearData()
        {
            SellDate.Text = "";
            txtQty.Text = "";
            txtTotal.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSellId.Text != "" && lblPid.Text != "" && txtBgprice.Text != "" && txtQty.Text != "" & txtTotal.Text != "")
            {
                string[] arr = new string[8];
                arr[0] = txtSellId.Text;
                arr[1] = lblPid.Text;
                arr[2] = cmbPname.Text;
                arr[3] = cmbBg.Text;
                arr[4] = SellDate.Text;
                arr[5] = txtBgprice.Text;
                arr[6] = txtQty.Text;
                arr[7] = txtTotal.Text;

                ListViewItem item = new ListViewItem(arr);
                lstSellinfo.Items.Add(item);

                txtsubtotal.Text = (Convert.ToInt32(txtsubtotal.Text) + Convert.ToInt32(txtTotal.Text)).ToString();
                clearData();
            }
            else
            {
                MessageBox.Show("Fill the all credentials!");
            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            try
            {
                int total, price, quantity;
                price = Convert.ToInt32(txtBgprice.Text);
                quantity = Convert.ToInt32(txtQty.Text);
                total = price * quantity;
                txtTotal.Text = total.ToString();

            }
            catch
            {
                MessageBox.Show("Enter Quantity");
            }
        }

        private void cmbPname_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPid.Text = cmbPname.SelectedValue.ToString();
        }

        private void cmbBg_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBgprice.Text = cmbBg.SelectedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (lstSellinfo.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < lstSellinfo.SelectedItems.Count; i++)
                    {
                        if (lstSellinfo.Items[i].Selected)
                        {
                            txtsubtotal.Text = (Convert.ToInt32(txtsubtotal.Text) - Convert.ToInt32(lstSellinfo.Items[i].SubItems[7].Text)).ToString();
                            lstSellinfo.Items[i].Remove();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select An Row ");
                }
            }
            catch
            {
                MessageBox.Show("Select An Row You Want to Remove !");
            }
        }

        public void Dispgrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblSellInfo", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                grdSellInfo.DataSource = ds.Tables[0];
            }
            catch { }
        }
        private void btnDsave_Click(object sender, EventArgs e)
        {
            try
            {
                int count = lstSellinfo.Items.Count;
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        SqlCommand cmd1 = new SqlCommand("select * from tblBloodStock where BloodGroup='" + lstSellinfo.Items[i].SubItems[3].Text + "'", con);
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                        DataSet ds1 = new DataSet();
                        da1.Fill(ds1, "BS");

                        int count2 = ds1.Tables["BS"].Rows.Count;

                        int qty;
                        if (count2 > 0)
                        {
                            qty = Convert.ToInt32(ds1.Tables["BS"].Rows[0][1].ToString());
                            if (qty > 0)
                            {

                                SqlCommand cmd = new SqlCommand("insert into tblSellInfo values('" + lstSellinfo.Items[i].SubItems[0].Text + "','" + lstSellinfo.Items[i].SubItems[1].Text + "','" + lstSellinfo.Items[i].SubItems[2].Text + "','" + lstSellinfo.Items[i].SubItems[3].Text + "','" + lstSellinfo.Items[i].SubItems[4].Text + "','" + lstSellinfo.Items[i].SubItems[5].Text + "','" + lstSellinfo.Items[i].SubItems[6].Text + "','" + lstSellinfo.Items[i].SubItems[7].Text + "')", con);
                                SqlDataAdapter da = new SqlDataAdapter(cmd);
                                DataSet ds = new DataSet();
                                da.Fill(ds);

                                qty = qty - Convert.ToInt32(lstSellinfo.Items[i].SubItems[6].Text);

                                SqlCommand cmd3 = new SqlCommand("update tblBloodStock set Stock='" + qty + "' where BloodGroup='" + lstSellinfo.Items[i].SubItems[3].Text + "'", con);
                                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                                DataSet ds3 = new DataSet();
                                da3.Fill(ds3, "BU");
                                MessageBox.Show("Record Added !");
                            }
                            else
                            {
                                MessageBox.Show("Blood Stock Not Available !", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Data Not Found!");
                        }

                        SellingPage_Load(sender, e);
                    }
                  
                }
                else
                {
                    MessageBox.Show("Data Not Available!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Not Found!" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtSellId.Focus();
                if (txtSellId.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Delete from tblSellInfo where SellId=" + txtSellId.Text, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "delete");
                    MessageBox.Show("Record Deleted !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Dispgrid();
                }
                else
                {
                    MessageBox.Show("Enter An Sell-Id !", "Sell-Id", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Record Not Found !");
            }
        }

        private void txtSellId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbPname_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

