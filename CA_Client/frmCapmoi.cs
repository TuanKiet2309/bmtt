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
        public frmCapmoi(Connect frm)
        {
            InitializeComponent();
            this.connect = frm;
        }

        public string Privatekey
        {
            get
            {
                string key = Lib.ReadTextFile_CSymm4("publicKey.txt");
                privatekey = Lib.Encrypt(privatekey, key);
                return privatekey;
            }
            set
            {
                privatekey = value;
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
            Lib.generateKey(ref publickey, ref privatekey);
            StringBuilder builder = new StringBuilder();
            builder.Append("capmoi#");
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
            builder.Append(publickey);
            builder.Append("*");
            connect.Bw.Write(this.Privatekey);
            connect.Bw.Flush();

        }
    }
}
