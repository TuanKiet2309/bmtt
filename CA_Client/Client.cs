using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace CA_Client
{
    public partial class Client : Form
    {
        Connect connect;
        private static Hashtable certificateErrors = new Hashtable();
        public Client(Connect frmConnect)
        {
            InitializeComponent();
            this.connect = frmConnect;

        }

        private void btnREQUEST_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("dangky#");
            builder.Append("a");
            builder.Append("*");
            builder.Append("a");
            builder.Append("*");
            builder.Append("a");
            builder.Append("*");
            builder.Append("a");
            builder.Append("*");
            connect.Bw.Write(builder.ToString());
            connect.Bw.Flush();
            string str = connect.Br.ReadString();
            MessageBox.Show(str);
        }
        private void btnREVOKE_Click(object sender, EventArgs e)
        {
            connect.Bw.Write("revoke");
            connect.Bw.Flush();
            string str = connect.Br.ReadString();
            MessageBox.Show(str);
        }

        
    }
}
