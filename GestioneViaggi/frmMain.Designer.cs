
namespace GestioneViaggi
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnViaggi = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAutisti = new System.Windows.Forms.ToolStripButton();
            this.tsBtnMezzi = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnViaggi,
            this.tsBtnAutisti,
            this.tsBtnMezzi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(643, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnViaggi
            // 
            this.tsBtnViaggi.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnViaggi.Image")));
            this.tsBtnViaggi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnViaggi.Name = "tsBtnViaggi";
            this.tsBtnViaggi.Size = new System.Drawing.Size(60, 22);
            this.tsBtnViaggi.Text = "Viaggi";
            // 
            // tsBtnAutisti
            // 
            this.tsBtnAutisti.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAutisti.Image")));
            this.tsBtnAutisti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAutisti.Name = "tsBtnAutisti";
            this.tsBtnAutisti.Size = new System.Drawing.Size(61, 22);
            this.tsBtnAutisti.Text = "Autisti";
            this.tsBtnAutisti.Click += new System.EventHandler(this.tsBtnAutisti_Click);
            // 
            // tsBtnMezzi
            // 
            this.tsBtnMezzi.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMezzi.Image")));
            this.tsBtnMezzi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMezzi.Name = "tsBtnMezzi";
            this.tsBtnMezzi.Size = new System.Drawing.Size(57, 22);
            this.tsBtnMezzi.Text = "Mezzi";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 346);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Gestione Viaggi";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnViaggi;
        private System.Windows.Forms.ToolStripButton tsBtnAutisti;
        private System.Windows.Forms.ToolStripButton tsBtnMezzi;
    }
}

