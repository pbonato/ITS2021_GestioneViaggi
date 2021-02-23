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
    public partial class frmMezzi : Form
    {
        Mezzi listMezzi;
        public frmMezzi()
        {
            listMezzi = new Mezzi();
            InitializeComponent();
        }

        private void frmMezzi_Load(object sender, EventArgs e)
        {
            InitUI();
        }
        private void InitUI()
        {
            Dictionary<int, string> comboSource = new Dictionary<int, string>();

            foreach (Mezzo tmp in listMezzi.GetMezzi())
            {
                comboSource.Add(tmp.id, tmp.Descrizione);
            }
            if (comboSource.Count > 0)
            {
                cmbMezzo.DataSource = new BindingSource(comboSource, null);
                cmbMezzo.DisplayMember = "Value";
                cmbMezzo.ValueMember = "Key";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtDescrizione.Text == ""))
            {
                MessageBox.Show("Valorizzare Descrizione", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.listMezzi.Add(new Mezzo(txtDescrizione.Text));
            }
            InitUI();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int id = ((KeyValuePair<int, string>)cmbMezzo.SelectedItem).Key;
            listMezzi.Edit(id, new Mezzo(txtDescrizione.Text));
            InitUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = ((KeyValuePair<int, string>)cmbMezzo.SelectedItem).Key;
            listMezzi.Delete(id);
            InitUI();
        }
    }
}
