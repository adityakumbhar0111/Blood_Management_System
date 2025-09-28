namespace BLOOD_DONATE_PROJECT
{
    partial class SellingPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbBg = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SellDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBgprice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDsave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstSellinfo = new System.Windows.Forms.ListView();
            this.Sell_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.P_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BloodGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sell_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.grdSellInfo = new System.Windows.Forms.DataGridView();
            this.lblPid = new System.Windows.Forms.Label();
            this.txtSellId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSellInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(41, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 85;
            this.label3.Text = "Sell Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(41, 169);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(186, 36);
            this.lblName.TabIndex = 83;
            this.lblName.Text = "Patient Name";
            // 
            // cmbBg
            // 
            this.cmbBg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBg.FormattingEnabled = true;
            this.cmbBg.Location = new System.Drawing.Point(688, 90);
            this.cmbBg.Name = "cmbBg";
            this.cmbBg.Size = new System.Drawing.Size(131, 40);
            this.cmbBg.TabIndex = 87;
            this.cmbBg.SelectedIndexChanged += new System.EventHandler(this.cmbBg_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(488, 99);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(177, 36);
            this.lblGender.TabIndex = 86;
            this.lblGender.Text = "Blood Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(41, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 89;
            this.label4.Text = "Sell Date";
            // 
            // SellDate
            // 
            this.SellDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SellDate.Location = new System.Drawing.Point(248, 242);
            this.SellDate.Name = "SellDate";
            this.SellDate.Size = new System.Drawing.Size(195, 39);
            this.SellDate.TabIndex = 88;
            // 
            // cmbPname
            // 
            this.cmbPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPname.FormattingEnabled = true;
            this.cmbPname.Location = new System.Drawing.Point(248, 169);
            this.cmbPname.Name = "cmbPname";
            this.cmbPname.Size = new System.Drawing.Size(195, 40);
            this.cmbPname.TabIndex = 90;
            this.cmbPname.SelectedIndexChanged += new System.EventHandler(this.cmbPname_SelectedIndexChanged);
            this.cmbPname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(488, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 36);
            this.label1.TabIndex = 91;
            this.label1.Text = "Blood Price";
            // 
            // txtBgprice
            // 
            this.txtBgprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBgprice.Location = new System.Drawing.Point(688, 169);
            this.txtBgprice.Multiline = true;
            this.txtBgprice.Name = "txtBgprice";
            this.txtBgprice.ReadOnly = true;
            this.txtBgprice.Size = new System.Drawing.Size(131, 50);
            this.txtBgprice.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(488, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 36);
            this.label2.TabIndex = 93;
            this.label2.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(688, 240);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(131, 50);
            this.txtQty.TabIndex = 94;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(688, 319);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(131, 50);
            this.txtTotal.TabIndex = 95;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(488, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 36);
            this.label5.TabIndex = 96;
            this.label5.Text = "Total";
            // 
            // btnDsave
            // 
            this.btnDsave.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnDsave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDsave.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.btnDsave.ForeColor = System.Drawing.Color.White;
            this.btnDsave.Location = new System.Drawing.Point(248, 401);
            this.btnDsave.Name = "btnDsave";
            this.btnDsave.Size = new System.Drawing.Size(151, 61);
            this.btnDsave.TabIndex = 97;
            this.btnDsave.Text = "SAVE";
            this.btnDsave.UseVisualStyleBackColor = false;
            this.btnDsave.Click += new System.EventHandler(this.btnDsave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkMagenta;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(494, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 61);
            this.button1.TabIndex = 98;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkMagenta;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(891, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 75);
            this.button2.TabIndex = 99;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkMagenta;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(891, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 75);
            this.button3.TabIndex = 100;
            this.button3.Text = "REMOVE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstSellinfo
            // 
            this.lstSellinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sell_ID,
            this.P_Id,
            this.Pname,
            this.BloodGroup,
            this.Sell_Date,
            this.Price,
            this.Qty,
            this.Total});
            this.lstSellinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSellinfo.FullRowSelect = true;
            this.lstSellinfo.GridLines = true;
            this.lstSellinfo.HideSelection = false;
            this.lstSellinfo.Location = new System.Drawing.Point(1084, 90);
            this.lstSellinfo.Name = "lstSellinfo";
            this.lstSellinfo.Size = new System.Drawing.Size(708, 372);
            this.lstSellinfo.TabIndex = 101;
            this.lstSellinfo.UseCompatibleStateImageBehavior = false;
            this.lstSellinfo.View = System.Windows.Forms.View.Details;
            // 
            // Sell_ID
            // 
            this.Sell_ID.Text = "Sell_ID";
            this.Sell_ID.Width = 113;
            // 
            // P_Id
            // 
            this.P_Id.Text = "P_Id";
            this.P_Id.Width = 117;
            // 
            // Pname
            // 
            this.Pname.Text = "Pname";
            this.Pname.Width = 195;
            // 
            // BloodGroup
            // 
            this.BloodGroup.Text = "BloodGroup";
            // 
            // Sell_Date
            // 
            this.Sell_Date.Text = "SellDate";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1511, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 36);
            this.label6.TabIndex = 103;
            this.label6.Text = "Total";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsubtotal.Location = new System.Drawing.Point(1615, 485);
            this.txtsubtotal.Multiline = true;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(166, 50);
            this.txtsubtotal.TabIndex = 102;
            this.txtsubtotal.Text = "0";
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grdSellInfo
            // 
            this.grdSellInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSellInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdSellInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSellInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdSellInfo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdSellInfo.Location = new System.Drawing.Point(37, 521);
            this.grdSellInfo.Name = "grdSellInfo";
            this.grdSellInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSellInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSellInfo.RowHeadersWidth = 62;
            this.grdSellInfo.RowTemplate.Height = 28;
            this.grdSellInfo.Size = new System.Drawing.Size(1352, 357);
            this.grdSellInfo.TabIndex = 104;
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold);
            this.lblPid.Location = new System.Drawing.Point(255, 45);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(58, 36);
            this.lblPid.TabIndex = 105;
            this.lblPid.Text = "Pid";
            this.lblPid.Visible = false;
            // 
            // txtSellId
            // 
            this.txtSellId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellId.Location = new System.Drawing.Point(248, 98);
            this.txtSellId.Multiline = true;
            this.txtSellId.Name = "txtSellId";
            this.txtSellId.Size = new System.Drawing.Size(195, 50);
            this.txtSellId.TabIndex = 106;
            this.txtSellId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellId_KeyPress);
            // 
            // SellingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 881);
            this.Controls.Add(this.txtSellId);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.grdSellInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.lstSellinfo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDsave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBgprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SellDate);
            this.Controls.Add(this.cmbBg);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Name = "SellingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SellingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSellInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbBg;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker SellDate;
        private System.Windows.Forms.ComboBox cmbPname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBgprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader P_Id;
        private System.Windows.Forms.ColumnHeader Pname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.DataGridView grdSellInfo;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.ColumnHeader Sell_ID;
        private System.Windows.Forms.ListView lstSellinfo;
        private System.Windows.Forms.TextBox txtSellId;
        private System.Windows.Forms.ColumnHeader BloodGroup;
        private System.Windows.Forms.ColumnHeader Sell_Date;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Total;
    }
}