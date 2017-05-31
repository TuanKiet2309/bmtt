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
    public partial class frmXacnhan : Form
    {
        frmDangnhap frm;
        public frmXacnhan(frmDangnhap frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            frm.check = true;
            this.Close();
        }
    }
}
