namespace Forme
{
    partial class FrmGlavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiKorisnici = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutomobili = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziAutomobileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDodajAutomobil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIzmenaStanja = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGlavni = new System.Windows.Forms.Panel();
            this.lblGlavna = new System.Windows.Forms.Label();
            this.izmeniKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlGlavni.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKorisnici,
            this.tsmiAutomobili});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1239, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiKorisnici
            // 
            this.tsmiKorisnici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKorisnikaToolStripMenuItem,
            this.izmeniKorisnikaToolStripMenuItem});
            this.tsmiKorisnici.Name = "tsmiKorisnici";
            this.tsmiKorisnici.Size = new System.Drawing.Size(64, 20);
            this.tsmiKorisnici.Text = "Korisnici";
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.DodajKorisnikaToolStripMenuItem_Click);
            // 
            // tsmiAutomobili
            // 
            this.tsmiAutomobili.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretraziAutomobileToolStripMenuItem,
            this.tsmiDodajAutomobil,
            this.tsmiIzmenaStanja});
            this.tsmiAutomobili.Name = "tsmiAutomobili";
            this.tsmiAutomobili.Size = new System.Drawing.Size(79, 20);
            this.tsmiAutomobili.Text = "Automobili";
            // 
            // pretraziAutomobileToolStripMenuItem
            // 
            this.pretraziAutomobileToolStripMenuItem.Name = "pretraziAutomobileToolStripMenuItem";
            this.pretraziAutomobileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.pretraziAutomobileToolStripMenuItem.Text = "Pretrazi automobile";
            this.pretraziAutomobileToolStripMenuItem.Click += new System.EventHandler(this.PretraziAutomobileToolStripMenuItem_Click);
            // 
            // tsmiDodajAutomobil
            // 
            this.tsmiDodajAutomobil.Name = "tsmiDodajAutomobil";
            this.tsmiDodajAutomobil.Size = new System.Drawing.Size(207, 22);
            this.tsmiDodajAutomobil.Text = "Dodaj automobil";
            this.tsmiDodajAutomobil.Click += new System.EventHandler(this.DodajAutomobilToolStripMenuItem_Click);
            // 
            // tsmiIzmenaStanja
            // 
            this.tsmiIzmenaStanja.Name = "tsmiIzmenaStanja";
            this.tsmiIzmenaStanja.Size = new System.Drawing.Size(207, 22);
            this.tsmiIzmenaStanja.Text = "Izmeni stanje automobila";
            this.tsmiIzmenaStanja.Click += new System.EventHandler(this.TsmiIzmenaStanja_Click);
            // 
            // pnlGlavni
            // 
            this.pnlGlavni.Controls.Add(this.lblGlavna);
            this.pnlGlavni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGlavni.Location = new System.Drawing.Point(0, 24);
            this.pnlGlavni.Name = "pnlGlavni";
            this.pnlGlavni.Size = new System.Drawing.Size(1239, 741);
            this.pnlGlavni.TabIndex = 1;
            // 
            // lblGlavna
            // 
            this.lblGlavna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGlavna.AutoSize = true;
            this.lblGlavna.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlavna.Location = new System.Drawing.Point(330, 273);
            this.lblGlavna.Name = "lblGlavna";
            this.lblGlavna.Size = new System.Drawing.Size(115, 39);
            this.lblGlavna.TabIndex = 0;
            this.lblGlavna.Text = "label1";
            // 
            // izmeniKorisnikaToolStripMenuItem
            // 
            this.izmeniKorisnikaToolStripMenuItem.Name = "izmeniKorisnikaToolStripMenuItem";
            this.izmeniKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izmeniKorisnikaToolStripMenuItem.Text = "Izmeni korisnika";
            this.izmeniKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.IzmeniKorisnikaToolStripMenuItem_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 765);
            this.Controls.Add(this.pnlGlavni);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni meni";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGlavna_FormClosed);
            this.Load += new System.EventHandler(this.FrmGlavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlGlavni.ResumeLayout(false);
            this.pnlGlavni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlGlavni;
        private System.Windows.Forms.ToolStripMenuItem tsmiKorisnici;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutomobili;
        private System.Windows.Forms.ToolStripMenuItem pretraziAutomobileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDodajAutomobil;
        private System.Windows.Forms.Label lblGlavna;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzmenaStanja;
        private System.Windows.Forms.ToolStripMenuItem izmeniKorisnikaToolStripMenuItem;
    }
}