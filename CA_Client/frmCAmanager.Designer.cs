namespace CA_Client
{
    partial class frmCAmanager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.côngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCapmoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCapnhat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThuhoi = new System.Windows.Forms.ToolStripMenuItem();
            this.giaHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvThongtinCA = new System.Windows.Forms.DataGridView();
            this.clChusohuu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHansudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinCA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Cooper Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.côngCụToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // côngCụToolStripMenuItem
            // 
            this.côngCụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCapmoi,
            this.menuTimkiem,
            this.menuCapnhat,
            this.menuThuhoi,
            this.giaHạnToolStripMenuItem});
            this.côngCụToolStripMenuItem.Name = "côngCụToolStripMenuItem";
            this.côngCụToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.côngCụToolStripMenuItem.Text = "Yêu cầu";
            // 
            // menuCapmoi
            // 
            this.menuCapmoi.Name = "menuCapmoi";
            this.menuCapmoi.Size = new System.Drawing.Size(152, 22);
            this.menuCapmoi.Text = "Cấp mới";
            this.menuCapmoi.Click += new System.EventHandler(this.menuCapmoi_Click);
            // 
            // menuTimkiem
            // 
            this.menuTimkiem.Name = "menuTimkiem";
            this.menuTimkiem.Size = new System.Drawing.Size(152, 22);
            this.menuTimkiem.Text = "Tìm kiếm";
            // 
            // menuCapnhat
            // 
            this.menuCapnhat.Name = "menuCapnhat";
            this.menuCapnhat.Size = new System.Drawing.Size(152, 22);
            this.menuCapnhat.Text = "Cập nhật";
            // 
            // menuThuhoi
            // 
            this.menuThuhoi.Name = "menuThuhoi";
            this.menuThuhoi.Size = new System.Drawing.Size(152, 22);
            this.menuThuhoi.Text = "Thu hồi";
            // 
            // giaHạnToolStripMenuItem
            // 
            this.giaHạnToolStripMenuItem.Name = "giaHạnToolStripMenuItem";
            this.giaHạnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.giaHạnToolStripMenuItem.Text = "Gia hạn";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            // 
            // dgvThongtinCA
            // 
            this.dgvThongtinCA.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongtinCA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongtinCA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinCA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clChusohuu,
            this.clCungcap,
            this.clHansudung});
            this.dgvThongtinCA.Location = new System.Drawing.Point(0, 137);
            this.dgvThongtinCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThongtinCA.Name = "dgvThongtinCA";
            this.dgvThongtinCA.RowTemplate.Height = 24;
            this.dgvThongtinCA.Size = new System.Drawing.Size(594, 265);
            this.dgvThongtinCA.TabIndex = 1;
            // 
            // clChusohuu
            // 
            this.clChusohuu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clChusohuu.HeaderText = "Chủ sở hữu";
            this.clChusohuu.Name = "clChusohuu";
            // 
            // clCungcap
            // 
            this.clCungcap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clCungcap.HeaderText = "Cung cấp bởi";
            this.clCungcap.Name = "clCungcap";
            // 
            // clHansudung
            // 
            this.clHansudung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clHansudung.HeaderText = "Hạn dùng";
            this.clHansudung.Name = "clHansudung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(125, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "FinalC-L CA Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CA_Client.Properties.Resources._51_VBd0YqNL__AC_UL115_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 111);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmCAmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(594, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongtinCA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCAmanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CA Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinCA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem côngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCapmoi;
        private System.Windows.Forms.ToolStripMenuItem menuTimkiem;
        private System.Windows.Forms.ToolStripMenuItem menuCapnhat;
        private System.Windows.Forms.ToolStripMenuItem menuThuhoi;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaHạnToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvThongtinCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChusohuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHansudung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}