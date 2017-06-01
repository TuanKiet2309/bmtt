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
    public partial class frmDangky : Form
    {
        Connect connect;
        public frmDangky(Connect frmConnect)
        {
            InitializeComponent();
            this.connect = frmConnect;
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            UserVO user = new UserVO(this.txtUser.Text, this.txtMatkhau.Text, this.txtEmail.Text, this.txtPhone.Text);
            StringBuilder builder = new StringBuilder();
            builder.Append("dangky#");
            builder.Append(user.UserName1);
            builder.Append("*");
            builder.Append(user.PassWord1);
            builder.Append("*");
            builder.Append(user.Email1);
            builder.Append("*");
            builder.Append(user.Phone1);
            builder.Append("*");
            connect.Bw.Write(builder.ToString());
            connect.Bw.Flush();
            string str = connect.Br.ReadString();
            if(str=="True")
                MessageBox.Show("Đăng ký thành công");
            else
                MessageBox.Show("Đăng ký thất bại");
        }

        private void frmDangky_Load(object sender, EventArgs e)
        {

        }
    }
}
