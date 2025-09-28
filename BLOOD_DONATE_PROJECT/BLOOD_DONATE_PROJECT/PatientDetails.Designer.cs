namespace BLOOD_DONATE_PROJECT
{
    partial class PatientDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPsave = new System.Windows.Forms.Button();
            this.txtPaddress = new System.Windows.Forms.TextBox();
            this.cmbPgroup = new System.Windows.Forms.ComboBox();
            this.txtPphone = new System.Windows.Forms.TextBox();
            this.cmbPgender = new System.Windows.Forms.ComboBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhoneCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientRegDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnViewPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnBloodstock = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewdonors = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonet = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonor = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbDoctors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDcid = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPsave
            // 
            this.btnPsave.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnPsave.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPsave.ForeColor = System.Drawing.Color.White;
            this.btnPsave.Location = new System.Drawing.Point(974, 830);
            this.btnPsave.Name = "btnPsave";
            this.btnPsave.Size = new System.Drawing.Size(287, 83);
            this.btnPsave.TabIndex = 50;
            this.btnPsave.Text = "SAVE";
            this.btnPsave.UseVisualStyleBackColor = false;
            this.btnPsave.Click += new System.EventHandler(this.btnPsave_Click);
            // 
            // txtPaddress
            // 
            this.txtPaddress.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtPaddress.Location = new System.Drawing.Point(1111, 469);
            this.txtPaddress.Multiline = true;
            this.txtPaddress.Name = "txtPaddress";
            this.txtPaddress.Size = new System.Drawing.Size(566, 113);
            this.txtPaddress.TabIndex = 49;
            // 
            // cmbPgroup
            // 
            this.cmbPgroup.Font = new System.Drawing.Font("Cambria", 16F);
            this.cmbPgroup.FormattingEnabled = true;
            this.cmbPgroup.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.cmbPgroup.Location = new System.Drawing.Point(1445, 297);
            this.cmbPgroup.Name = "cmbPgroup";
            this.cmbPgroup.Size = new System.Drawing.Size(232, 45);
            this.cmbPgroup.TabIndex = 48;
            // 
            // txtPphone
            // 
            this.txtPphone.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPphone.Location = new System.Drawing.Point(454, 467);
            this.txtPphone.MaxLength = 10;
            this.txtPphone.Multiline = true;
            this.txtPphone.Name = "txtPphone";
            this.txtPphone.Size = new System.Drawing.Size(287, 60);
            this.txtPphone.TabIndex = 47;
            this.txtPphone.TextChanged += new System.EventHandler(this.txtPphone_TextChanged);
            this.txtPphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPphone_KeyPress);
            // 
            // cmbPgender
            // 
            this.cmbPgender.Font = new System.Drawing.Font("Cambria", 16F);
            this.cmbPgender.FormattingEnabled = true;
            this.cmbPgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbPgender.Location = new System.Drawing.Point(1111, 297);
            this.cmbPgender.Name = "cmbPgender";
            this.cmbPgender.Size = new System.Drawing.Size(232, 45);
            this.cmbPgender.TabIndex = 46;
            // 
            // txtPage
            // 
            this.txtPage.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.Location = new System.Drawing.Point(782, 301);
            this.txtPage.MaxLength = 3;
            this.txtPage.Multiline = true;
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(287, 60);
            this.txtPage.TabIndex = 45;
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPage_KeyPress);
            // 
            // txtPname
            // 
            this.txtPname.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPname.Location = new System.Drawing.Point(454, 301);
            this.txtPname.Multiline = true;
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(287, 60);
            this.txtPname.TabIndex = 44;
            this.txtPname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPname_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(1105, 412);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(116, 36);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "Address";
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.lblBloodGroup.Location = new System.Drawing.Point(1439, 246);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(177, 36);
            this.lblBloodGroup.TabIndex = 42;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(448, 412);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(96, 36);
            this.lblPhone.TabIndex = 41;
            this.lblPhone.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(1105, 246);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(109, 36);
            this.lblGender.TabIndex = 40;
            this.lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.lblAge.Location = new System.Drawing.Point(776, 246);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(64, 36);
            this.lblAge.TabIndex = 39;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(448, 246);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 36);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "/10";
            // 
            // lblPhoneCount
            // 
            this.lblPhoneCount.AutoSize = true;
            this.lblPhoneCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneCount.Location = new System.Drawing.Point(449, 536);
            this.lblPhoneCount.Name = "lblPhoneCount";
            this.lblPhoneCount.Size = new System.Drawing.Size(24, 25);
            this.lblPhoneCount.TabIndex = 52;
            this.lblPhoneCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(776, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 36);
            this.label4.TabIndex = 55;
            this.label4.Text = "Reg. Date";
            // 
            // PatientRegDate
            // 
            this.PatientRegDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientRegDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PatientRegDate.Location = new System.Drawing.Point(782, 469);
            this.PatientRegDate.Name = "PatientRegDate";
            this.PatientRegDate.Size = new System.Drawing.Size(232, 44);
            this.PatientRegDate.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.Controls.Add(this.btnViewPatient);
            this.panel3.Controls.Add(this.btnDashboard);
            this.panel3.Controls.Add(this.guna2Button3);
            this.panel3.Controls.Add(this.btnBloodstock);
            this.panel3.Controls.Add(this.btnPatients);
            this.panel3.Controls.Add(this.btnViewdonors);
            this.panel3.Controls.Add(this.btnDonet);
            this.panel3.Controls.Add(this.btnDonor);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.guna2Button2);
            this.panel3.Location = new System.Drawing.Point(-4, -27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 1032);
            this.panel3.TabIndex = 56;
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnViewPatient.BorderRadius = 10;
            this.btnViewPatient.BorderThickness = 1;
            this.btnViewPatient.CustomBorderColor = System.Drawing.Color.DarkMagenta;
            this.btnViewPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewPatient.FillColor = System.Drawing.Color.Transparent;
            this.btnViewPatient.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPatient.ForeColor = System.Drawing.Color.White;
            this.btnViewPatient.Location = new System.Drawing.Point(44, 570);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnViewPatient.Size = new System.Drawing.Size(322, 70);
            this.btnViewPatient.TabIndex = 20;
            this.btnViewPatient.Text = "VIEW PATIENT";
            this.btnViewPatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewPatient.Tile = true;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.BorderThickness = 1;
            this.btnDashboard.CustomBorderColor = System.Drawing.Color.DarkMagenta;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(44, 770);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnDashboard.Size = new System.Drawing.Size(322, 70);
            this.btnDashboard.TabIndex = 19;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Tile = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.CustomBorderColor = System.Drawing.Color.DarkMagenta;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(44, 670);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.guna2Button3.Size = new System.Drawing.Size(322, 70);
            this.guna2Button3.TabIndex = 18;
            this.guna2Button3.Text = "SELLING";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Tile = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click_1);
            // 
            // btnBloodstock
            // 
            this.btnBloodstock.BackColor = System.Drawing.Color.Transparent;
            this.btnBloodstock.BorderRadius = 10;
            this.btnBloodstock.BorderThickness = 1;
            this.btnBloodstock.CustomBorderColor = System.Drawing.Color.DarkMagenta;
            this.btnBloodstock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBloodstock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBloodstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBloodstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBloodstock.FillColor = System.Drawing.Color.Transparent;
            this.btnBloodstock.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodstock.ForeColor = System.Drawing.Color.White;
            this.btnBloodstock.Location = new System.Drawing.Point(44, 670);
            this.btnBloodstock.Name = "btnBloodstock";
            this.btnBloodstock.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnBloodstock.Size = new System.Drawing.Size(322, 70);
            this.btnBloodstock.TabIndex = 17;
            this.btnBloodstock.Text = "BLOOD STOCK";
            this.btnBloodstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBloodstock.Tile = true;
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.Color.Transparent;
            this.btnPatients.BorderRadius = 10;
            this.btnPatients.BorderThickness = 1;
            this.btnPatients.CustomBorderColor = System.Drawing.Color.DarkMagenta;
            this.btnPatients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatients.FillColor = System.Drawing.Color.Transparent;
            this.btnPatients.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.Location = new System.Drawing.Point(44, 470);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnPatients.Size = new System.Drawing.Size(322, 70);
            this.btnPatients.TabIndex = 16;
            this.btnPatients.Text = "PATIENTS";
            this.btnPatients.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatients.Tile = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnViewdonors
            // 
            this.btnViewdonors.BackColor = System.Drawing.Color.Transparent;
            this.btnViewdonors.BorderRadius = 10;
            this.btnViewdonors.BorderThickness = 1;
            this.btnViewdonors.CustomBorderColor = System.Drawing.Color.DarkMagenta;
            this.btnViewdonors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewdonors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewdonors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewdonors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewdonors.FillColor = System.Drawing.Color.Transparent;
            this.btnViewdonors.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewdonors.ForeColor = System.Drawing.Color.White;
            this.btnViewdonors.Location = new System.Drawing.Point(44, 370);
            this.btnViewdonors.Name = "btnViewdonors";
            this.btnViewdonors.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnViewdonors.Size = new System.Drawing.Size(322, 70);
            this.btnViewdonors.TabIndex = 15;
            this.btnViewdonors.Text = "VIEW DONORS";
            this.btnViewdonors.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewdonors.Tile = true;
            this.btnViewdonors.Click += new System.EventHandler(this.btnViewdonors_Click_2);
            // 
            // btnDonet
            // 
            this.btnDonet.BorderRadius = 10;
            this.btnDonet.BorderThickness = 1;
            this.btnDonet.CustomBorderColor = System.Drawing.Color.DarkMagenta;
            this.btnDonet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonet.FillColor = System.Drawing.Color.Transparent;
            this.btnDonet.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonet.ForeColor = System.Drawing.Color.White;
            this.btnDonet.Location = new System.Drawing.Point(44, 270);
            this.btnDonet.Name = "btnDonet";
            this.btnDonet.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnDonet.Size = new System.Drawing.Size(322, 70);
            this.btnDonet.TabIndex = 14;
            this.btnDonet.Text = "DONET";
            this.btnDonet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDonet.Click += new System.EventHandler(this.btnDonet_Click_1);
            // 
            // btnDonor
            // 
            this.btnDonor.BorderRadius = 10;
            this.btnDonor.BorderThickness = 1;
            this.btnDonor.CustomBorderColor = System.Drawing.Color.DarkMagenta;
            this.btnDonor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonor.FillColor = System.Drawing.Color.Transparent;
            this.btnDonor.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor.ForeColor = System.Drawing.Color.White;
            this.btnDonor.Location = new System.Drawing.Point(44, 170);
            this.btnDonor.Name = "btnDonor";
            this.btnDonor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnDonor.Size = new System.Drawing.Size(322, 70);
            this.btnDonor.TabIndex = 13;
            this.btnDonor.Text = "DONORS";
            this.btnDonor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDonor.Click += new System.EventHandler(this.btnDonor_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vineta BT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "|";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.CustomBorderColor = System.Drawing.Color.DarkMagenta;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(44, 870);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.guna2Button2.Size = new System.Drawing.Size(322, 70);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "LOG OUT";
            this.guna2Button2.Tile = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel4.Location = new System.Drawing.Point(317, -8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1629, 134);
            this.panel4.TabIndex = 57;
            // 
            // cmbDoctors
            // 
            this.cmbDoctors.Font = new System.Drawing.Font("Cambria", 16F);
            this.cmbDoctors.FormattingEnabled = true;
            this.cmbDoctors.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbDoctors.Location = new System.Drawing.Point(454, 643);
            this.cmbDoctors.Name = "cmbDoctors";
            this.cmbDoctors.Size = new System.Drawing.Size(287, 45);
            this.cmbDoctors.TabIndex = 59;
            this.cmbDoctors.SelectedIndexChanged += new System.EventHandler(this.cmbDoctors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(448, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 58;
            this.label1.Text = "Ref. Doctor ";
            // 
            // txtDcid
            // 
            this.txtDcid.AutoSize = true;
            this.txtDcid.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.txtDcid.Location = new System.Drawing.Point(776, 648);
            this.txtDcid.Name = "txtDcid";
            this.txtDcid.Size = new System.Drawing.Size(74, 36);
            this.txtDcid.TabIndex = 60;
            this.txtDcid.Text = "Dcid";
            // 
            // PatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1800, 950);
            this.Controls.Add(this.txtDcid);
            this.Controls.Add(this.cmbDoctors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatientRegDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPhoneCount);
            this.Controls.Add(this.btnPsave);
            this.Controls.Add(this.txtPaddress);
            this.Controls.Add(this.cmbPgroup);
            this.Controls.Add(this.txtPphone);
            this.Controls.Add(this.cmbPgender);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "PatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PatientDetails_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPsave;
        private System.Windows.Forms.TextBox txtPaddress;
        private System.Windows.Forms.ComboBox cmbPgroup;
        private System.Windows.Forms.TextBox txtPphone;
        private System.Windows.Forms.ComboBox cmbPgender;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhoneCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker PatientRegDate;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnViewPatient;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnBloodstock;
        private Guna.UI2.WinForms.Guna2Button btnPatients;
        private Guna.UI2.WinForms.Guna2Button btnViewdonors;
        private Guna.UI2.WinForms.Guna2Button btnDonet;
        private Guna.UI2.WinForms.Guna2Button btnDonor;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbDoctors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDcid;
    }
}