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
    public partial class Doctor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PC\\Documents\\BLOOD_MANAGEMENT.mdf;Integrated Security=True");

        public Doctor()
        {
            InitializeComponent();
        }

        private void btnFindDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFindDoctor.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("select * from tblDoctorRegister where DcName='" + txtFindDoctor.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DoctorDetails");

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        grdViewdoctor.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Record Not Found !");
                        Doctor_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Search An Record..");
                    txtFindDoctor.Focus();
                }
            }
            catch
            {

            }
        }

        private void ClearData()
        {
            txtDcid.Text = "";
            txtHRid.Text = "";
            txtDcname.Text = "";
            cmbDcgender.Text = "";
            cmbDcDegree.Text = "";
            txtDcphone.Text = "";
            txtHospitalname.Text = "";
        }
        private void Doctor_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblDoctorRegister", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "DoctorDetails");

                grdViewdoctor.DataSource = ds.Tables[0];
                ClearData();
            }
            catch { }
        }

        private void btnDsave_Click(object sender, EventArgs e)
        {
            string HRNo, name, gender, degree, phone, Hospital;
            HRNo = txtHRid.Text;
            name = txtDcname.Text;
            gender = cmbDcgender.Text;
            degree = cmbDcDegree.Text;
            phone = txtDcphone.Text;
            Hospital = txtHospitalname.Text;

            if (name == "" && HRNo == "" && phone == "" && Hospital == "")
            {
                MessageBox.Show("Enter All Credentials !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand cmd1 = new SqlCommand("select * from tblDoctorRegister where DcName='"+txtDcname.Text+"'", con);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "DoctorDetails1");

                    string Dname = ds1.Tables["DoctorDetails1"].Rows[0][2].ToString();

                    if(Dname == txtDcname.Text)
                    {
                        MessageBox.Show("The Same Name Doctor Already Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("insert into tblDoctorRegister values('" + HRNo + "','" + name + "','" + gender + "','" + degree + "','" + phone + "','" + Hospital + "')", con);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "Doctor");
                            MessageBox.Show("Doctor Register Successfully");
                            Doctor_Load(sender, e);
                            ClearData();
                        }
                        catch
                        {
                            MessageBox.Show("Register Not Successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }catch {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("insert into tblDoctorRegister values('" + HRNo + "','" + name + "','" + gender + "','" + degree + "','" + phone + "','" + Hospital + "')", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Doctor");
                        MessageBox.Show("Doctor Register Successfully");
                        Doctor_Load(sender, e);
                        ClearData();
                    }
                    catch
                    {
                        MessageBox.Show("Register Not Successfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        
        private void btnDedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDcname.Text != "" && txtDcid.Text != "" && txtHospitalname.Text != "" && txtDcphone.Text != "" && cmbDcDegree.Text != "" && cmbDcgender.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("update tblDoctorRegister set HospitalRegNo='" + txtHRid.Text + "', DcName='" + txtDcname.Text + "',Dgender='" + cmbDcgender.Text + "',DcDegree='" + cmbDcDegree.Text + "',DcPhone='" + txtDcphone.Text + "',HospitalName='" + txtHospitalname.Text + "' where Dcid = '" + txtDcid.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Updated Successfully !");
                    Doctor_Load(sender, e);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Select A Doctor...", "", MessageBoxButtons.OK);
                }
            }
            catch
            {

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDcid.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Delete from tblDoctorRegister where Dcid='" + txtDcid.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Deleted Successfully !");
                    Doctor_Load(sender, e);
                    txtDcid.Text = "";
                }
                else
                {
                    MessageBox.Show("Select A Doctor You Want To Delete..", "", MessageBoxButtons.OKCancel);
                }
            }
            catch 
            {
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void grdViewdoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtDcid.Text = grdViewdoctor.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHRid.Text = grdViewdoctor.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDcname.Text = grdViewdoctor.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbDcgender.Text = grdViewdoctor.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbDcDegree.Text = grdViewdoctor.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDcphone.Text = grdViewdoctor.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtHospitalname.Text = grdViewdoctor.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }
    }
}
