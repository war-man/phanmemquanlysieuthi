﻿namespace GUI
{
    partial class frmQuanLyTheGiamGia
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
            this.palTencung = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.rdbtimkiem3 = new System.Windows.Forms.RadioButton();
            this.rdbtimkiem2 = new System.Windows.Forms.RadioButton();
            this.lblDatmua = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslnaplai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslthem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_Dong = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvbanbuon = new System.Windows.Forms.DataGridView();
            this.palTencung.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbanbuon)).BeginInit();
            this.SuspendLayout();
            // 
            // palTencung
            // 
            this.palTencung.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.palTencung.Controls.Add(this.groupBox1);
            this.palTencung.Controls.Add(this.lblDatmua);
            this.palTencung.Dock = System.Windows.Forms.DockStyle.Top;
            this.palTencung.Location = new System.Drawing.Point(0, 0);
            this.palTencung.Name = "palTencung";
            this.palTencung.Size = new System.Drawing.Size(635, 104);
            this.palTencung.TabIndex = 1;
            this.palTencung.DoubleClick += new System.EventHandler(this.palTencung_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Controls.Add(this.rdbtimkiem3);
            this.groupBox1.Controls.Add(this.rdbtimkiem2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 58);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(151, 28);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(447, 23);
            this.txttimkiem.TabIndex = 3;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // rdbtimkiem3
            // 
            this.rdbtimkiem3.AutoSize = true;
            this.rdbtimkiem3.Checked = true;
            this.rdbtimkiem3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtimkiem3.Location = new System.Drawing.Point(80, 31);
            this.rdbtimkiem3.Name = "rdbtimkiem3";
            this.rdbtimkiem3.Size = new System.Drawing.Size(65, 20);
            this.rdbtimkiem3.TabIndex = 2;
            this.rdbtimkiem3.TabStop = true;
            this.rdbtimkiem3.Text = "Tất cả";
            this.rdbtimkiem3.UseVisualStyleBackColor = true;
            this.rdbtimkiem3.CheckedChanged += new System.EventHandler(this.rdbtimkiem3_CheckedChanged);
            // 
            // rdbtimkiem2
            // 
            this.rdbtimkiem2.AutoSize = true;
            this.rdbtimkiem2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtimkiem2.Location = new System.Drawing.Point(12, 31);
            this.rdbtimkiem2.Name = "rdbtimkiem2";
            this.rdbtimkiem2.Size = new System.Drawing.Size(68, 20);
            this.rdbtimkiem2.TabIndex = 1;
            this.rdbtimkiem2.TabStop = true;
            this.rdbtimkiem2.Text = "Mã thẻ";
            this.rdbtimkiem2.UseVisualStyleBackColor = true;
            // 
            // lblDatmua
            // 
            this.lblDatmua.AutoSize = true;
            this.lblDatmua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatmua.ForeColor = System.Drawing.Color.White;
            this.lblDatmua.Location = new System.Drawing.Point(9, 6);
            this.lblDatmua.Name = "lblDatmua";
            this.lblDatmua.Size = new System.Drawing.Size(201, 20);
            this.lblDatmua.TabIndex = 0;
            this.lblDatmua.Text = "Quản Lý Thẻ Giảm Giá";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslnaplai,
            this.tsslthem,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel1,
            this.toolStripStatus_Dong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(635, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslnaplai
            // 
            this.tsslnaplai.Image = global::GUI.Properties.Resources.refresh;
            this.tsslnaplai.Name = "tsslnaplai";
            this.tsslnaplai.Size = new System.Drawing.Size(155, 27);
            this.tsslnaplai.Spring = true;
            this.tsslnaplai.Text = "Nạp lại";
            this.tsslnaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsslnaplai.Click += new System.EventHandler(this.tsslnaplai_Click);
            this.tsslnaplai.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.tsslnaplai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // tsslthem
            // 
            this.tsslthem.Image = global::GUI.Properties.Resources.Them;
            this.tsslthem.Name = "tsslthem";
            this.tsslthem.Size = new System.Drawing.Size(155, 27);
            this.tsslthem.Spring = true;
            this.tsslthem.Text = "Thêm";
            this.tsslthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsslthem.Click += new System.EventHandler(this.tsslthem_Click);
            this.tsslthem.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.tsslthem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 27);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::GUI.Properties.Resources.Dele;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(155, 27);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Xóa";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            this.toolStripStatusLabel1.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.toolStripStatusLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // toolStripStatus_Dong
            // 
            this.toolStripStatus_Dong.Image = global::GUI.Properties.Resources.Xoa;
            this.toolStripStatus_Dong.Name = "toolStripStatus_Dong";
            this.toolStripStatus_Dong.Size = new System.Drawing.Size(155, 27);
            this.toolStripStatus_Dong.Spring = true;
            this.toolStripStatus_Dong.Text = "Đóng";
            this.toolStripStatus_Dong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatus_Dong.Click += new System.EventHandler(this.toolStripStatus_Dong_Click);
            this.toolStripStatus_Dong.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.toolStripStatus_Dong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvbanbuon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 296);
            this.panel2.TabIndex = 3;
            // 
            // dtgvbanbuon
            // 
            this.dtgvbanbuon.BackgroundColor = System.Drawing.Color.White;
            this.dtgvbanbuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvbanbuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvbanbuon.Location = new System.Drawing.Point(0, 0);
            this.dtgvbanbuon.Name = "dtgvbanbuon";
            this.dtgvbanbuon.ReadOnly = true;
            this.dtgvbanbuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvbanbuon.RowHeadersVisible = false;
            this.dtgvbanbuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvbanbuon.Size = new System.Drawing.Size(635, 296);
            this.dtgvbanbuon.TabIndex = 0;
            this.dtgvbanbuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvbanbuon_CellClick);
            this.dtgvbanbuon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvbanbuon_CellDoubleClick);
            // 
            // frmQuanLyTheGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.palTencung);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmQuanLyTheGiamGia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.palTencung.ResumeLayout(false);
            this.palTencung.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbanbuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel palTencung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton rdbtimkiem3;
        private System.Windows.Forms.RadioButton rdbtimkiem2;
        private System.Windows.Forms.Label lblDatmua;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslnaplai;
        private System.Windows.Forms.ToolStripStatusLabel tsslthem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_Dong;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvbanbuon;

    }
}