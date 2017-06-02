namespace CA_Client
{
    partial class frmTimKiem
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
            this.dgvThongtinCA = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinCA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongtinCA
            // 
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
            this.dgvThongtinCA.Location = new System.Drawing.Point(12, 38);
            this.dgvThongtinCA.Name = "dgvThongtinCA";
            this.dgvThongtinCA.RowTemplate.Height = 24;
            this.dgvThongtinCA.Size = new System.Drawing.Size(586, 233);
            this.dgvThongtinCA.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(442, 277);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu file";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(523, 277);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(96, 17);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Serial number";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(115, 9);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(402, 22);
            this.txtTimkiem.TabIndex = 8;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(523, 9);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
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
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 307);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dgvThongtinCA);
            this.Name = "frmTimKiem";
            this.Text = "Tìm Kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinCA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongtinCA;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
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