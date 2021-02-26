namespace Forme.UserControls
{
    partial class UCIzmenaStanjaAutomobila
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSviAutomobili = new System.Windows.Forms.DataGridView();
            this.dgvAutomobiliZaIzmenu = new System.Windows.Forms.DataGridView();
            this.btnDodajZaIzmenu = new System.Windows.Forms.Button();
            this.btnVratiNazad = new System.Windows.Forms.Button();
            this.btnSacuvajNovaStanja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviAutomobili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobiliZaIzmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iznena stanja:";
            // 
            // dgvSviAutomobili
            // 
            this.dgvSviAutomobili.AllowUserToAddRows = false;
            this.dgvSviAutomobili.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSviAutomobili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSviAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviAutomobili.Location = new System.Drawing.Point(16, 51);
            this.dgvSviAutomobili.Name = "dgvSviAutomobili";
            this.dgvSviAutomobili.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviAutomobili.Size = new System.Drawing.Size(965, 264);
            this.dgvSviAutomobili.TabIndex = 1;
            // 
            // dgvAutomobiliZaIzmenu
            // 
            this.dgvAutomobiliZaIzmenu.AllowUserToAddRows = false;
            this.dgvAutomobiliZaIzmenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAutomobiliZaIzmenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutomobiliZaIzmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobiliZaIzmenu.Location = new System.Drawing.Point(26, 398);
            this.dgvAutomobiliZaIzmenu.Name = "dgvAutomobiliZaIzmenu";
            this.dgvAutomobiliZaIzmenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutomobiliZaIzmenu.Size = new System.Drawing.Size(965, 215);
            this.dgvAutomobiliZaIzmenu.TabIndex = 2;
            // 
            // btnDodajZaIzmenu
            // 
            this.btnDodajZaIzmenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajZaIzmenu.Location = new System.Drawing.Point(364, 321);
            this.btnDodajZaIzmenu.Name = "btnDodajZaIzmenu";
            this.btnDodajZaIzmenu.Size = new System.Drawing.Size(106, 71);
            this.btnDodajZaIzmenu.TabIndex = 3;
            this.btnDodajZaIzmenu.Text = "dole";
            this.btnDodajZaIzmenu.UseVisualStyleBackColor = true;
            this.btnDodajZaIzmenu.Click += new System.EventHandler(this.BtnDodajZaIzmenu_Click);
            // 
            // btnVratiNazad
            // 
            this.btnVratiNazad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVratiNazad.Location = new System.Drawing.Point(545, 321);
            this.btnVratiNazad.Name = "btnVratiNazad";
            this.btnVratiNazad.Size = new System.Drawing.Size(106, 71);
            this.btnVratiNazad.TabIndex = 4;
            this.btnVratiNazad.Text = "gore";
            this.btnVratiNazad.UseVisualStyleBackColor = true;
            this.btnVratiNazad.Click += new System.EventHandler(this.BtnVratiNazad_Click);
            // 
            // btnSacuvajNovaStanja
            // 
            this.btnSacuvajNovaStanja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajNovaStanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajNovaStanja.Location = new System.Drawing.Point(364, 631);
            this.btnSacuvajNovaStanja.Name = "btnSacuvajNovaStanja";
            this.btnSacuvajNovaStanja.Size = new System.Drawing.Size(287, 58);
            this.btnSacuvajNovaStanja.TabIndex = 5;
            this.btnSacuvajNovaStanja.Text = "Sacuvaj stanja!";
            this.btnSacuvajNovaStanja.UseVisualStyleBackColor = true;
            this.btnSacuvajNovaStanja.Click += new System.EventHandler(this.BtnSacuvajNovaStanja_Click);
            // 
            // UCIzmenaStanjaAutomobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSacuvajNovaStanja);
            this.Controls.Add(this.btnVratiNazad);
            this.Controls.Add(this.btnDodajZaIzmenu);
            this.Controls.Add(this.dgvAutomobiliZaIzmenu);
            this.Controls.Add(this.dgvSviAutomobili);
            this.Controls.Add(this.label1);
            this.Name = "UCIzmenaStanjaAutomobila";
            this.Size = new System.Drawing.Size(994, 705);
            this.Load += new System.EventHandler(this.UCIzmenaStanjaAutomobila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviAutomobili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobiliZaIzmenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvSviAutomobili;
        private System.Windows.Forms.DataGridView dgvAutomobiliZaIzmenu;
        private System.Windows.Forms.Button btnDodajZaIzmenu;
        private System.Windows.Forms.Button btnVratiNazad;
        private System.Windows.Forms.Button btnSacuvajNovaStanja;
    }
}
