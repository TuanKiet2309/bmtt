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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinCA)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.côngCụToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 28);
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
            this.côngCụToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.côngCụToolStripMenuItem.Text = "Yêu cầu";
            // 
            // menuCapmoi
            // 
            this.menuCapmoi.Name = "menuCapmoi";
            this.menuCapmoi.Size = new System.Drawing.Size(181, 26);
            this.menuCapmoi.Text = "Cấp mới";
            this.menuCapmoi.Click += new System.EventHandler(this.menuCapmoi_Click);
            // 
            // menuTimkiem
            // 
            this.menuTimkiem.Name = "menuTimkiem";
            this.menuTimkiem.Size = new System.Drawing.Size(181, 26);
            this.menuTimkiem.Text = "Tìm kiếm";
            // 
            // menuCapnhat
            // 
            this.menuCapnhat.Name = "menuCapnhat";
            this.menuCapnhat.Size = new System.Drawing.Size(181, 26);
            this.menuCapnhat.Text = "Cập nhật";
            // 
            // menuThuhoi
            // 
            this.menuThuhoi.Name = "menuThuhoi";
            this.menuThuhoi.Size = new System.Drawing.Size(181, 26);
            this.menuThuhoi.Text = "Thu hồi";
            // 
            // giaHạnToolStripMenuItem
            // 
            this.giaHạnToolStripMenuItem.Name = "giaHạnToolStripMenuItem";
            this.giaHạnToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.giaHạnToolStripMenuItem.Text = "Gia hạn";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            // 
            // dgvThongtinCA
            // 
            this.dgvThongtinCA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinCA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clChusohuu,
            this.clCungcap,
            this.clHansudung});
            this.dgvThongtinCA.Location = new System.Drawing.Point(12, 108);
            this.dgvThongtinCA.Name = "dgvThongtinCA";
            this.dgvThongtinCA.RowTemplate.Height = 24;
            this.dgvThongtinCA.Size = new System.Drawing.Size(505, 318);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "FinalC-L CA Manager";
            // 
            // frmCAmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongtinCA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCAmanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CA Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinCA)).EndInit();
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
    }
}