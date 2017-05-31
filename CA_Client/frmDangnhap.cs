using CA_Client.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_Client
{

    public partial class frmDangnhap : Form
    {
        Connect connect;
        public bool check;
        public frmDangnhap(Connect frmConnect)
        {
            InitializeComponent();
            this.connect = frmConnect;
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangky frm = new frmDangky(connect);
            frm.ShowDialog();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            UserVO user = new UserVO(this.txtUser.Text, this.txtMatkhau.Text,"","");
            StringBuilder builder = new StringBuilder();
            builder.Append("dangnhap#");
            builder.Append(user.UserName1);
            builder.Append("*");
            builder.Append(user.PassWord1);
            builder.Append("*");
            connect.Bw.Write(builder.ToString());
            connect.Bw.Flush();
            string str = connect.Br.ReadString();
            if (str == "False")
                MessageBox.Show("Tài khoản không tồn tại");
            else
            {
                frmXacnhan frm = new frmXacnhan(this);
                frm.ShowDialog();
                if(check)
                {
                    connect.UserID = Int32.Parse(str);
                    this.Close();
                    Client frmClient = new Client(connect);
                    frmClient.Show();
                }

            }
        }
    }
}
