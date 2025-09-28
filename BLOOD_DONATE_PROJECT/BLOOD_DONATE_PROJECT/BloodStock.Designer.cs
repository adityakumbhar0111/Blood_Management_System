namespace BLOOD_DONATE_PROJECT
{
    partial class BloodStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grdViewCurrentStock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbBloodStock = new System.Windows.Forms.ComboBox();
            this.btnBstock = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewCurrentStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.Controls.Add(this.btnBstock);
            this.panel3.Location = new System.Drawing.Point(-7, -18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 654);
            this.panel3.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel4.Location = new System.Drawing.Point(311, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(987, 82);
            this.panel4.TabIndex = 40;
            // 
            // grdViewCurrentStock
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewCurrentStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdViewCurrentStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grdViewCurrentStock.ColumnHeadersHeight = 4;
            this.grdViewCurrentStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdViewCurrentStock.DefaultCellStyle = dataGridViewCellStyle12;
            this.grdViewCurrentStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdViewCurrentStock.Location = new System.Drawing.Point(392, 233);
            this.grdViewCurrentStock.Name = "grdViewCurrentStock";
            this.grdViewCurrentStock.RowHeadersVisible = false;
            this.grdViewCurrentStock.RowHeadersWidth = 62;
            this.grdViewCurrentStock.RowTemplate.Height = 28;
            this.grdViewCurrentStock.Size = new System.Drawing.Size(802, 337);
            this.grdViewCurrentStock.TabIndex = 41;
            this.grdViewCurrentStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdViewCurrentStock.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewCurrentStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdViewCurrentStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdViewCurrentStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdViewCurrentStock.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdViewCurrentStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdViewCurrentStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdViewCurrentStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdViewCurrentStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdViewCurrentStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdViewCurrentStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdViewCurrentStock.ThemeStyle.HeaderStyle.Height = 4;
            this.grdViewCurrentStock.ThemeStyle.ReadOnly = false;
            this.grdViewCurrentStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdViewCurrentStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdViewCurrentStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grdViewCurrentStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdViewCurrentStock.ThemeStyle.RowsStyle.Height = 28;
            this.grdViewCurrentStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdViewCurrentStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(609, 165);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(85, 30);
            this.lblFilter.TabIndex = 42;
            this.lblFilter.Text = "Filter";
            // 
            // cmbBloodStock
            // 
            this.cmbBloodStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBloodStock.FormattingEnabled = true;
            this.cmbBloodStock.Items.AddRange(new object[] {
            "A+",
            "AB+",
            "B+",
            "O+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.cmbBloodStock.Location = new System.Drawing.Point(736, 160);
            this.cmbBloodStock.Name = "cmbBloodStock";
            this.cmbBloodStock.Size = new System.Drawing.Size(242, 40);
            this.cmbBloodStock.TabIndex = 43;
            this.cmbBloodStock.SelectedIndexChanged += new System.EventHandler(this.cmbBloodStock_SelectedIndexChanged);
            // 
            // btnBstock
            // 
            this.btnBstock.BackColor = System.Drawing.Color.Transparent;
            this.btnBstock.BorderRadius = 10;
            this.btnBstock.BorderThickness = 1;
            this.btnBstock.CustomBorderColor = System.Drawing.Color.DarkMagenta;
            this.btnBstock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBstock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBstock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBstock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBstock.FillColor = System.Drawing.Color.Transparent;
            this.btnBstock.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBstock.ForeColor = System.Drawing.Color.White;
            this.btnBstock.Location = new System.Drawing.Point(34, 111);
            this.btnBstock.Name = "btnBstock";
            this.btnBstock.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnBstock.Size = new System.Drawing.Size(269, 54);
            this.btnBstock.TabIndex = 22;
            this.btnBstock.Text = "BLOOD STOCK";
            this.btnBstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBstock.Tile = true;
            // 
            // BloodStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1275, 618);
            this.Controls.Add(this.cmbBloodStock);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.grdViewCurrentStock);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "BloodStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodStock";
            this.Load += new System.EventHandler(this.BloodStock_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewCurrentStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView grdViewCurrentStock;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbBloodStock;
        private Guna.UI2.WinForms.Guna2Button btnBstock;
    }
}