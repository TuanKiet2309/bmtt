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

            frmCapmoi frmCapmoi = new frmCapmoi(connect);
            frmCapmoi.ShowDialog();

        }
    }
}
