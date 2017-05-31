using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_Client
{
    public partial class Connect : Form
    {
        TcpClient client;
        SslStream sslStream;
        BinaryReader br;
        BinaryWriter bw;
        int userID;

        public TcpClient Client { get => client; set => client = value; }
        public SslStream SslStream { get => sslStream; set => sslStream = value; }
        public BinaryReader Br { get => br; set => br = value; }
        public BinaryWriter Bw { get => bw; set => bw = value; }
        public int UserID { get => userID; set => userID = value; }

        public Connect()
        {
            InitializeComponent();
            connectSetup();
        }

        private void connectSetup()
        {
            try
            {
                Client = new TcpClient("127.0.0.1", 2000);
                SslStream = new SslStream(
                    Client.GetStream(),
                    false,
                    new RemoteCertificateValidationCallback(ValidateServerCertificate),
                    null
                    );
                // The server name must match the name on the server certificate.
                try
                {
                    SslStream.AuthenticateAsClient("tukida");
                    this.lblStatus.Text = "Thiết lập an toàn thành công. Kết nối đã bắt đầu";
                }
                catch (AuthenticationException e1)
                {
                    this.lblStatus.Text = "Thiết lập an toàn không thành công. Đang đóng kết nối...";
                    Client.Close();
                    return;
                }
                Br = new BinaryReader(SslStream, Encoding.UTF8);
                Bw = new BinaryWriter(SslStream, Encoding.UTF8);
                this.Hide();
                frmDangnhap frm = new frmDangnhap(this);
                frm.Show();
                

                
            }
            catch (Exception e2)
            {
                MessageBox.Show("Không thể kết nối tới Server! Hãy kiểm tra lại Server");
            }
        }
        public static bool ValidateServerCertificate(
              object sender,
              X509Certificate certificate,
              X509Chain chain,
              SslPolicyErrors sslPolicyErrors)
        {

            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;
            else
            {
                DialogResult dlr = MessageBox.Show("Kết nối này không an toàn. Bạn có muốn kết nối không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    return true;
                }
                else
                    return false;

            }

        }
    }
}
