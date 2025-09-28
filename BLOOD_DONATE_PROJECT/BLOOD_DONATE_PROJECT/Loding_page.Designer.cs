namespace BLOOD_DONATE_PROJECT
{
    partial class Loding_page
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm3 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm4 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblLogo = new System.Windows.Forms.Label();
            this.proBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfooter = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm3
            // 
            this.guna2BorderlessForm3.ContainerControl = this;
            this.guna2BorderlessForm3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm3.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm4
            // 
            this.guna2BorderlessForm4.ContainerControl = this;
            this.guna2BorderlessForm4.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm4.TransparentWhileDrag = true;
            // 
            // lblLogo
            // 
            this.lblLogo.AllowDrop = true;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(26, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(613, 42);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "BLOOD BANK MANAGEMENT SYSTEM";
            // 
            // proBar
            // 
            this.proBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.proBar.FillThickness = 15;
            this.proBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.proBar.ForeColor = System.Drawing.Color.White;
            this.proBar.Location = new System.Drawing.Point(247, 135);
            this.proBar.Minimum = 0;
            this.proBar.Name = "proBar";
            this.proBar.ProgressColor = System.Drawing.Color.DarkMagenta;
            this.proBar.ProgressColor2 = System.Drawing.Color.DarkMagenta;
            this.proBar.ProgressThickness = 15;
            this.proBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.proBar.Size = new System.Drawing.Size(212, 212);
            this.proBar.TabIndex = 1;
            this.proBar.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 91);
            this.panel1.TabIndex = 2;
            // 
            // lblfooter
            // 
            this.lblfooter.AutoSize = true;
            this.lblfooter.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfooter.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblfooter.Location = new System.Drawing.Point(275, 409);
            this.lblfooter.Name = "lblfooter";
            this.lblfooter.Size = new System.Drawing.Size(142, 35);
            this.lblfooter.TabIndex = 3;
            this.lblfooter.Text = "Loading...";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblcount.Location = new System.Drawing.Point(413, 413);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(27, 31);
            this.lblcount.TabIndex = 4;
            this.lblcount.Text = "0";
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // Loding_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 496);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.lblfooter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.proBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loding_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loding_page";
            this.Load += new System.EventHandler(this.Loding_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lblLogo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm3;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm4;
        private System.Windows.Forms.Label lblfooter;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar proBar;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Timer time;
    }
}