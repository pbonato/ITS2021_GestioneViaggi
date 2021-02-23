using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneViaggi.View
{
    public partial class frmAutista : Form
    {
        Autisti listAutisti = new Autisti();
        public frmAutista()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtCognome.Text == "") || (txtNome.Text == ""))
            {
                MessageBox.Show("Valorizzare Cognome e Nome", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.listAutisti.Add(new Autista(txtCognome.Text, txtNome.Text));
            }
            InitUI();
        }

        private void frmAutista_Load(object sender, EventArgs e)
        {
            InitUI();
        }

        private void InitUI()
        {
            cmbAutista.Items.Clear();
            
            foreach (Autista tmp in listAutisti.GetAutisti())
            {
                cmbAutista.Items.Add(tmp.Cognome + " " + tmp.Nome);
            }
        }
    }
}
