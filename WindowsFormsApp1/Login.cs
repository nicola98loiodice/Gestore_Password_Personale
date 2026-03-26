using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{

    public partial class frmLogin : Form
    {
        private LIBRERIA miaLibreria = new LIBRERIA();

        public frmLogin()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            frmCreaUtente frmCrea = new frmCreaUtente(miaLibreria);
            frmCrea.ShowDialog();
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            string user = txtName.Text;
            string pass = txtPassword.Text;

            // Chiediamo alla libreria di verificare
            if (miaLibreria.Autentica(user, pass))
            {
                frmCerca frm = new frmCerca();
                frm.Show();

                lblError.Text = "Accesso eseguito!";
                this.Hide(); // Nascondiamo il login
            }
            else
            {
                lblError.Text = "Nome utente o password errati.";
                lblError.ForeColor = Color.Red;
            }
        }
    }
}
