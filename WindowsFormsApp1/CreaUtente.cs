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
    public partial class frmCreaUtente : Form
    {
        private LIBRERIA _libreriaRiferimento;
        public frmCreaUtente(LIBRERIA libreriaPassata)
        {
            InitializeComponent();
            // Salviamo la libreria ricevuta nella nostra variabile interna
            _libreriaRiferimento = libreriaPassata;
        }

        private void btnSalvaProfilo_Click(object sender, EventArgs e)
        {
            string nuovoNome = txtNameProfilo.Text;
            string nuovaPass = txtPasswordProfilo.Text;

            if (string.IsNullOrWhiteSpace(nuovoNome) || string.IsNullOrWhiteSpace(nuovaPass))
            {
                MessageBox.Show("Compila tutti i campi!");
                return;
            }

            // Usiamo la libreria per aggiungere l'utente (che salverà anche su file)
            _libreriaRiferimento.AggiungiUtente(nuovoNome, nuovaPass);

            MessageBox.Show("Utente registrato correttamente!");
            this.Close(); // Chiudiamo questo form e torniamo al Login
        }

        private void btnAnnullaProfilo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
