using Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_Client
{

    public partial class frmCapmoi : Form
    {
        string emailAddress;
        string commonName;
        string localityName;
        string organizationalUnitName;
        string organizationName;
        string countryName;
        string publickey;
        string privatekey;
        Connect connect;
        frmCAmanager caMana;
        public frmCapmoi(Connect frm, frmCAmanager frm2)
        {
            InitializeComponent();
            this.connect = frm;
            this.caMana = frm2;
        }

        public string Privatekey
        {
            get
            {
                string key = Lib.ReadTextFile_CSymm4("publicKey.xml");
                privatekey = Lib.Encrypt(privatekey, key);
                return privatekey;
            }
            set
            {
                privatekey = value;
            }
        }

        public string Publickey {
            get
            {
                return publickey;
            }
            set
            {
                byte[] data = Encoding.UTF8.GetBytes(value);

                publickey = BitConverter.ToString(data).Replace("-", ":").ToLower();

            }
        }

        private void btnCapmoi_Click(object sender, EventArgs e)
        {
            emailAddress = this.txtE.Text;
            commonName = this.txtCN.Text;
            localityName = this.txtLN.Text;
            organizationalUnitName = this.txtOU.Text;
            organizationName = this.txtON.Text;
            countryName = this.txtC.Text;
            string publickey1 = "";
            string privatekey1 = "";
            Lib.generateKey(ref publickey1, ref privatekey1);
            this.Publickey = publickey1;
            this.Privatekey = privatekey1;
            StringBuilder builder = new StringBuilder();
            builder.Append("capmoi#");
            builder.Append(connect.UserID);
            builder.Append("*");
            builder.Append(emailAddress);
            builder.Append("*");
            builder.Append(commonName);
            builder.Append("*");
            builder.Append(localityName);
            builder.Append("*");
            builder.Append(organizationalUnitName);
            builder.Append("*");
            builder.Append(organizationName);
            builder.Append("*");
            builder.Append(countryName);
            builder.Append("*");
            builder.Append(this.Publickey);
            builder.Append("*");
            builder.Append(this.Privatekey);
            connect.Bw.Write(builder.ToString());
            connect.Bw.Flush();
            string str = connect.Br.ReadString();
            if (str.IndexOf('#')>0)
            {
                
            }
            else if( str=="ok")
            {
                bool bl1 = false;
                do
                {
                    MessageBox.Show("Cấp CA thành công. Hãy chọn nơi lưu private key của bạn");
                    string curentDirectory = System.IO.Directory.GetCurrentDirectory();
                    string filter1 = "xml files (*.xml)|*.xml";
                    string path = SaveFile(curentDirectory, filter1);
                    bl1 = Lib.WriteTextFile_CSymm4(path, privatekey1);
                    if (bl1)
                        MessageBox.Show("Lưu thành công!");
                    else
                        MessageBox.Show("Lưu thất bại!");
                } while (!bl1);
                this.Close();

            }
            else
                MessageBox.Show("Cấp CA thất bại. User đã có CA");
            caMana.frmCAmanager_Load(sender, e);
            
        }
        private string SaveFile(string initialDirectory, string filter)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = filter;
            dialog.InitialDirectory = initialDirectory;
            dialog.Title = "Save file";
            return (dialog.ShowDialog() == DialogResult.OK)
               ? dialog.FileName : null;
        }
    }
}
