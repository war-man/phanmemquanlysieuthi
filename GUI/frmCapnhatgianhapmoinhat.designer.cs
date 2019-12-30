namespace GUI
{
    partial class frmCapnhatgianhapmoinhat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltongso = new System.Windows.Forms.Label();
            this.lbltatca = new System.Windows.Forms.Label();
            this.lblcapnhatgiamoinhat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslbldieukien = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblnaplai = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblcapnhatgia = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblin = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbltrove = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvcapnhatgiamoinhat = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcapnhatgiamoinhat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lbltongso);
            this.panel1.Controls.Add(this.lbltatca);
            this.panel1.Controls.Add(this.lblcapnhatgiamoinhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbltongso
            // 
            this.lbltongso.AutoSize = true;
            this.lbltongso.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongso.ForeColor = System.Drawing.SystemColors.Info;
            this.lbltongso.Location = new System.Drawing.Point(243, 63);
            this.lbltongso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltongso.Name = "lbltongso";
            this.lbltongso.Size = new System.Drawing.Size(60, 17);
            this.lbltongso.TabIndex = 2;
            this.lbltongso.Text = "Tổng số:";
            // 
            // lbltatca
            // 
            this.lbltatca.AutoSize = true;
            this.lbltatca.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltatca.ForeColor = System.Drawing.SystemColors.Info;
            this.lbltatca.Location = new System.Drawing.Point(351, 16);
            this.lbltatca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltatca.Name = "lbltatca";
            this.lbltatca.Size = new System.Drawing.Size(61, 17);
            this.lbltatca.TabIndex = 1;
            this.lbltatca.Text = "<Tất cả>";
            // 
            // lblcapnhatgiamoinhat
            // 
            this.lblcapnhatgiamoinhat.AutoSize = true;
            this.lblcapnhatgiamoinhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapnhatgiamoinhat.ForeColor = System.Drawing.SystemColors.Info;
            this.lblcapnhatgiamoinhat.Location = new System.Drawing.Point(4, 6);
            this.lblcapnhatgiamoinhat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcapnhatgiamoinhat.Name = "lblcapnhatgiamoinhat";
            this.lblcapnhatgiamoinhat.Size = new System.Drawing.Size(239, 23);
            this.lblcapnhatgiamoinhat.TabIndex = 0;
            this.lblcapnhatgiamoinhat.Text = "Cập nhật giá nhập mới nhất";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.dgvcapnhatgiamoinhat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 222);
            this.panel2.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbldieukien,
            this.tsslblnaplai,
            this.tsslblcapnhatgia,
            this.tsslblin,
            this.tsslbltrove});
            this.statusStrip1.Location = new System.Drawing.Point(0, 190);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(834, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslbldieukien
            // 
            this.tsslbldieukien.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsslbldieukien.Image = global::GUI.Properties.Resources.Loc;
            this.tsslbldieukien.Name = "tsslbldieukien";
            this.tsslbldieukien.Size = new System.Drawing.Size(162, 27);
            this.tsslbldieukien.Spring = true;
            this.tsslbldieukien.Text = "Điều kiện";
            this.tsslbldieukien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsslbldieukien.Click += new System.EventHandler(this.tsslbldieukien_Click);
            this.tsslbldieukien.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.tsslbldieukien.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // tsslblnaplai
            // 
            this.tsslblnaplai.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsslblnaplai.Image = global::GUI.Properties.Resources.refresh;
            this.tsslblnaplai.Name = "tsslblnaplai";
            this.tsslblnaplai.Size = new System.Drawing.Size(162, 27);
            this.tsslblnaplai.Spring = true;
            this.tsslblnaplai.Text = "Nạp lại";
            this.tsslblnaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsslblnaplai.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.tsslblnaplai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // tsslblcapnhatgia
            // 
            this.tsslblcapnhatgia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsslblcapnhatgia.Image = global::GUI.Properties.Resources.Cap_nhat_gia;
            this.tsslblcapnhatgia.Name = "tsslblcapnhatgia";
            this.tsslblcapnhatgia.Size = new System.Drawing.Size(162, 27);
            this.tsslblcapnhatgia.Spring = true;
            this.tsslblcapnhatgia.Text = "Cập nhật giá";
            this.tsslblcapnhatgia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsslblcapnhatgia.Click += new System.EventHandler(this.tsslblcapnhatgia_Click);
            this.tsslblcapnhatgia.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.tsslblcapnhatgia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // tsslblin
            // 
            this.tsslblin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsslblin.Image = global::GUI.Properties.Resources.In;
            this.tsslblin.Name = "tsslblin";
            this.tsslblin.Size = new System.Drawing.Size(162, 27);
            this.tsslblin.Spring = true;
            this.tsslblin.Text = "In";
            this.tsslblin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsslblin.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.tsslblin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // tsslbltrove
            // 
            this.tsslbltrove.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsslbltrove.Image = global::GUI.Properties.Resources.Tro_ve;
            this.tsslbltrove.Name = "tsslbltrove";
            this.tsslbltrove.Size = new System.Drawing.Size(162, 27);
            this.tsslbltrove.Spring = true;
            this.tsslbltrove.Text = "Trở về";
            this.tsslbltrove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsslbltrove.Click += new System.EventHandler(this.tsslbltrove_Click);
            this.tsslbltrove.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.tsslbltrove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // dgvcapnhatgiamoinhat
            // 
            this.dgvcapnhatgiamoinhat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvcapnhatgiamoinhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcapnhatgiamoinhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcapnhatgiamoinhat.Location = new System.Drawing.Point(0, 0);
            this.dgvcapnhatgiamoinhat.Margin = new System.Windows.Forms.Padding(4);
            this.dgvcapnhatgiamoinhat.Name = "dgvcapnhatgiamoinhat";
            this.dgvcapnhatgiamoinhat.Size = new System.Drawing.Size(834, 222);
            this.dgvcapnhatgiamoinhat.TabIndex = 0;
            // 
            // frmCapnhatgianhapmoinhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 322);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapnhatgianhapmoinhat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật giá nhập mới nhất";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcapnhatgiamoinhat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltongso;
        private System.Windows.Forms.Label lbltatca;
        private System.Windows.Forms.Label lblcapnhatgiamoinhat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslbldieukien;
        private System.Windows.Forms.DataGridView dgvcapnhatgiamoinhat;
        private System.Windows.Forms.ToolStripStatusLabel tsslblnaplai;
        private System.Windows.Forms.ToolStripStatusLabel tsslblcapnhatgia;
        private System.Windows.Forms.ToolStripStatusLabel tsslblin;
        private System.Windows.Forms.ToolStripStatusLabel tsslbltrove;
    }
}