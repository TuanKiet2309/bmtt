using CA_Client.VO;
using Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_Client
{
    public partial class frmCAmanager : Form
    {
        Connect connect;
        public frmCAmanager(Connect frm)
        {
            InitializeComponent();
            this.connect = frm;
            
        }

        private void menuCapmoi_Click(object sender, EventArgs e)
        {

            frmCapmoi frmCapmoi = new frmCapmoi(connect, this);
            frmCapmoi.ShowDialog();
        }

        public void frmCAmanager_Load(object sender, EventArgs e)
        {
            connect.Bw.Write("view#" + connect.UserID);
            connect.Bw.Flush();
            string str = connect.Br.ReadString();
            string[] kq = str.Split('#');
            if (kq[0] == "yes")
            {
                string[] noidung = kq[1].Split('^');
                int n = noidung.Length - 1;
                for (int i = 0; i < n; i++)
                {
                    string[] thanhphan = noidung[i].Split('*');
                    for (int j = 0; j < thanhphan.Length; j++)
                    {
                        this.dgvThongtinCA.Rows[i].Cells[j].Value = thanhphan[j];
                    }
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            CaVO ca = new CaVO(dgvThongtinCA.CurrentRow.Cells[0].Value.ToString(), connect.UserID, dgvThongtinCA.CurrentRow.Cells[4].Value.ToString(), dgvThongtinCA.CurrentRow.Cells[5].Value.ToString(), dgvThongtinCA.CurrentRow.Cells[7].Value.ToString(), dgvThongtinCA.CurrentRow.Cells[8].Value.ToString(),"", dgvThongtinCA.CurrentRow.Cells[10].Value.ToString());
            string kq = Lib.ca2string(ca);
            MessageBox.Show(kq);

        }
        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CaVO ca = new CaVO(dgvThongtinCA.CurrentRow.Cells[0].Value.ToString(), connect.UserID, dgvThongtinCA.CurrentRow.Cells[4].Value.ToString(), dgvThongtinCA.CurrentRow.Cells[5].Value.ToString(), dgvThongtinCA.CurrentRow.Cells[6].Value.ToString(), dgvThongtinCA.CurrentRow.Cells[7].Value.ToString(), "", dgvThongtinCA.CurrentRow.Cells[9].Value.ToString());
            string kq = Lib.ca2string(ca);
            bool bl1 = false;
            do
            {
                MessageBox.Show("Chọn nơi lưu file");
                string curentDirectory = System.IO.Directory.GetCurrentDirectory();
                string filter1 = "txt files (*.txt)|*.txt";
                string path = Lib.SaveFile(curentDirectory, filter1);
                bl1 = Lib.WriteTextFile_CSymm4(path, kq);
                if (bl1)
                    MessageBox.Show("Lưu thành công!");
                else
                    MessageBox.Show("Lưu thất bại!");
            } while (!bl1);
        }
        

        private void menuTimkiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem(connect);
            frm.ShowDialog();
        }


        private void btnThuHoi_Click(object sender, EventArgs e)
        {
            try
            {
                string privateKey = "";
                string curentDirectory = System.IO.Directory.GetCurrentDirectory();
                string filter = "xml files (*.xml)|*.xml";
                MessageBox.Show("Import Private Key của CA");
                string path = Lib.SelectFile(curentDirectory, filter);
                if (path != "")
                {
                    string key = Lib.ReadTextFile_CSymm4("publicKey.xml");
                    privateKey = Lib.ReadTextFile_CSymm4(path);
                    privateKey = Lib.Encrypt(privateKey, key);

                }
                if (!String.IsNullOrEmpty(privateKey))
                {
                    connect.Bw.Write("thuhoi#" + dgvThongtinCA.CurrentRow.Cells[0].Value.ToString() + "*" + privateKey);
                    connect.Bw.Flush();
                    string str = connect.Br.ReadString();
                    string[] kq = str.Split('#');
                    if (kq[0] == "yes")
                    {
                        MessageBox.Show("Đã thu hồi chứng chỉ");
                        this.frmCAmanager_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Thông tin không trùng khớp. Hãy thử lại");
                }
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.ToString());
            }
            this.frmCAmanager_Load(sender, e);
        }
    }
}
