namespace BLOOD_DONATE_PROJECT
{
    partial class DonationReciept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonationReciept));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchDonor = new System.Windows.Forms.TextBox();
            this.lblFindDonor = new System.Windows.Forms.Label();
            this.txtDbg = new System.Windows.Forms.TextBox();
            this.txtDgender = new System.Windows.Forms.TextBox();
            this.txtDage = new System.Windows.Forms.TextBox();
            this.txtDusername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.lblClose);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(-20, -7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1025, 91);
            this.panel4.TabIndex = 41;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Sylfaen", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(961, 16);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(34, 36);
            this.lblClose.TabIndex = 43;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblClose_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donation Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 42;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 44;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 28);
            this.label5.TabIndex = 45;
            this.label5.Text = "Blood Group";
            // 
            // txtSearchDonor
            // 
            this.txtSearchDonor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDonor.Location = new System.Drawing.Point(606, 119);
            this.txtSearchDonor.Multiline = true;
            this.txtSearchDonor.Name = "txtSearchDonor";
            this.txtSearchDonor.Size = new System.Drawing.Size(267, 42);
            this.txtSearchDonor.TabIndex = 50;
            // 
            // lblFindDonor
            // 
            this.lblFindDonor.AutoSize = true;
            this.lblFindDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindDonor.Location = new System.Drawing.Point(645, 91);
            this.lblFindDonor.Name = "lblFindDonor";
            this.lblFindDonor.Size = new System.Drawing.Size(207, 25);
            this.lblFindDonor.TabIndex = 51;
            this.lblFindDonor.Text = "Search Donor Name";
            // 
            // txtDbg
            // 
            this.txtDbg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDbg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDbg.Location = new System.Drawing.Point(221, 401);
            this.txtDbg.Multiline = true;
            this.txtDbg.Name = "txtDbg";
            this.txtDbg.ReadOnly = true;
            this.txtDbg.Size = new System.Drawing.Size(291, 48);
            this.txtDbg.TabIndex = 56;
            // 
            // txtDgender
            // 
            this.txtDgender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDgender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDgender.Location = new System.Drawing.Point(221, 329);
            this.txtDgender.Multiline = true;
            this.txtDgender.Name = "txtDgender";
            this.txtDgender.ReadOnly = true;
            this.txtDgender.Size = new System.Drawing.Size(291, 48);
            this.txtDgender.TabIndex = 55;
            // 
            // txtDage
            // 
            this.txtDage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDage.Location = new System.Drawing.Point(221, 257);
            this.txtDage.Multiline = true;
            this.txtDage.Name = "txtDage";
            this.txtDage.ReadOnly = true;
            this.txtDage.Size = new System.Drawing.Size(291, 48);
            this.txtDage.TabIndex = 54;
            // 
            // txtDusername
            // 
            this.txtDusername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDusername.Location = new System.Drawing.Point(221, 181);
            this.txtDusername.Multiline = true;
            this.txtDusername.Name = "txtDusername";
            this.txtDusername.ReadOnly = true;
            this.txtDusername.Size = new System.Drawing.Size(291, 48);
            this.txtDusername.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(900, 28);
            this.label6.TabIndex = 57;
            this.label6.Text = "Donate Blood , Save lives your small act of kindness can make a big difference..." +
    " 🩸";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BLOOD_DONATE_PROJECT.Properties.Resources.Donation;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(652, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 192);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::BLOOD_DONATE_PROJECT.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(890, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 42);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(33, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(48, 44);
            this.btnPrint.TabIndex = 44;
            this.btnPrint.Text = "print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DonationReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(987, 630);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDbg);
            this.Controls.Add(this.txtDgender);
            this.Controls.Add(this.txtDage);
            this.Controls.Add(this.txtDusername);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblFindDonor);
            this.Controls.Add(this.txtSearchDonor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonationReciept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonationReciept";
            this.Load += new System.EventHandler(this.DonationReciept_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchDonor;
        private System.Windows.Forms.Label lblFindDonor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDbg;
        private System.Windows.Forms.TextBox txtDgender;
        private System.Windows.Forms.TextBox txtDage;
        private System.Windows.Forms.TextBox txtDusername;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}