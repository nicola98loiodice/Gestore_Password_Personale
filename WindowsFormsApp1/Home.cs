using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCerca : Form
    {
        public frmCerca()
        {
            InitializeComponent();
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            frmAggiorna frm = new frmAggiorna();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmWarningDelete frm = new frmWarningDelete();
            frm.ShowDialog();
        }

        private void btnCreaNuovo_Click(object sender, EventArgs e)
        {
            frmCreaCredenziali frm = new frmCreaCredenziali();
            frm.ShowDialog();
        }
    }
}
