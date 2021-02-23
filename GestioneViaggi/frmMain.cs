using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestioneViaggi.View;

namespace GestioneViaggi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsBtnAutisti_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmAutista))
                {
                    form.Activate();
                    return;
                }
            }

            Form myForm = new frmAutista();
            SetForm(myForm);
            myForm.Show();
        }

        private void tsBtnMezzi_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmMezzi))
                {
                    form.Activate();
                    return;
                }
            }

            Form myForm = new frmMezzi();
            SetForm(myForm);
            myForm.Show();
        }

        private void tsBtnViaggi_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmViaggi))
                {
                    form.Activate();
                    return;
                }
            }

            Form myForm = new frmViaggi();
            SetForm(myForm);
            myForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form myForm = new frmViaggi();
            SetForm(myForm);
            myForm.Show();
        }

        private void SetForm(Form myForm)
        {
            myForm.MdiParent = this;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.ControlBox = false;
            myForm.MaximizeBox = false;
            myForm.MinimizeBox = false;
            myForm.ShowIcon = false;
            myForm.Text = "";
            myForm.Dock = DockStyle.Fill;
        }
    }
}
