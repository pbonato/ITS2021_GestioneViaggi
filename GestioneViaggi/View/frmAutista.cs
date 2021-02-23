using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestioneViaggi.Model;

namespace GestioneViaggi.View
{
    public partial class frmAutista : Form
    {
        Autisti listAutisti;
        public frmAutista()
        {
            listAutisti = new Autisti();
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
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            
            foreach (Autista tmp in listAutisti.GetAutisti())
            {
                comboSource.Add(tmp.id, tmp.Cognome + " " + tmp.Nome);
               
            }
            if (comboSource.Count > 0)
            {
                cmbAutista.DataSource = new BindingSource(comboSource, null);
                cmbAutista.DisplayMember = "Value";
                cmbAutista.ValueMember = "Key";
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = ((KeyValuePair<int, string>)cmbAutista.SelectedItem).Key;
            listAutisti.Edit(id,new Autista(txtCognome.Text,txtNome.Text));
            InitUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = ((KeyValuePair<int, string>)cmbAutista.SelectedItem).Key;
            listAutisti.Delete(id);
            InitUI();
        }
    }
}
