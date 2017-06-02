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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.côngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCapmoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvThongtinCA = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignatureAlgorithm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidityPeriod_before = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidityPeriod_after = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevocationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignatureCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThuHoi = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinCA)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.côngCụToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(705, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // côngCụToolStripMenuItem
            // 
            this.côngCụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCapmoi,
            this.menuTimkiem});
            this.côngCụToolStripMenuItem.Name = "côngCụToolStripMenuItem";
            this.côngCụToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
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
            this.menuTimkiem.Click += new System.EventHandler(this.menuTimkiem_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // dgvThongtinCA
            // 
            this.dgvThongtinCA.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongtinCA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongtinCA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinCA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.Version,
            this.SignatureAlgorithm,
            this.IssuerName,
            this.ValidityPeriod_before,
            this.ValidityPeriod_after,
            this.RevocationDate,
            this.SubjectName,
            this.PublicKey,
            this.Extensions,
            this.SignatureCA});
            this.dgvThongtinCA.Location = new System.Drawing.Point(16, 133);
            this.dgvThongtinCA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThongtinCA.Name = "dgvThongtinCA";
            this.dgvThongtinCA.RowTemplate.Height = 24;
            this.dgvThongtinCA.Size = new System.Drawing.Size(676, 266);
            this.dgvThongtinCA.TabIndex = 1;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "Serial Number";
            this.SerialNumber.Name = "SerialNumber";
            // 
            // Version
            // 
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            // 
            // SignatureAlgorithm
            // 
            this.SignatureAlgorithm.HeaderText = "Signature Algorithm";
            this.SignatureAlgorithm.Name = "SignatureAlgorithm";
            // 
            // IssuerName
            // 
            this.IssuerName.HeaderText = "Issuer Name";
            this.IssuerName.Name = "IssuerName";
            // 
            // ValidityPeriod_before
            // 
            this.ValidityPeriod_before.HeaderText = "ValidityPeriod_before";
            this.ValidityPeriod_before.Name = "ValidityPeriod_before";
            // 
            // ValidityPeriod_after
            // 
            this.ValidityPeriod_after.HeaderText = "ValidityPeriod_after";
            this.ValidityPeriod_after.Name = "ValidityPeriod_after";
            // 
            // RevocationDate
            // 
            this.RevocationDate.HeaderText = "Revocation Date";
            this.RevocationDate.Name = "RevocationDate";
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "Subject Name";
            this.SubjectName.Name = "SubjectName";
            // 
            // PublicKey
            // 
            this.PublicKey.HeaderText = "Public Key";
            this.PublicKey.Name = "PublicKey";
            // 
            // Extensions
            // 
            this.Extensions.HeaderText = "Extensions";
            this.Extensions.Name = "Extensions";
            // 
            // SignatureCA
            // 
            this.SignatureCA.HeaderText = "SignatureCA";
            this.SignatureCA.Name = "SignatureCA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(167, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "FinalC-L CA Manager";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(592, 407);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 28);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(484, 407);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu file";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThuHoi
            // 
            this.btnThuHoi.Location = new System.Drawing.Point(376, 407);
            this.btnThuHoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThuHoi.Name = "btnThuHoi";
            this.btnThuHoi.Size = new System.Drawing.Size(100, 28);
            this.btnThuHoi.TabIndex = 5;
            this.btnThuHoi.Text = "Thu hồi";
            this.btnThuHoi.UseVisualStyleBackColor = true;
            this.btnThuHoi.Click += new System.EventHandler(this.btnThuHoi_Click);
            // 
            // frmCAmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 446);
            this.Controls.Add(this.btnThuHoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongtinCA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCAmanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CA Manager";
            this.Load += new System.EventHandler(this.frmCAmanager_Load);
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
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvThongtinCA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThuHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignatureAlgorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidityPeriod_before;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidityPeriod_after;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevocationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignatureCA;
    }
}