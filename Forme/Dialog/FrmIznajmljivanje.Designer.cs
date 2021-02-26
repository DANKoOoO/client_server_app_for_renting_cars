namespace Forme
{
    partial class FrmIznajmljivanje
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
            this.dgvAutomobili = new System.Windows.Forms.DataGridView();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatumPocetka = new System.Windows.Forms.TextBox();
            this.txtDatumKraja = new System.Windows.Forms.TextBox();
            this.btnIznajmi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnosClanova = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomobili
            // 
            this.dgvAutomobili.AllowUserToAddRows = false;
            this.dgvAutomobili.AllowUserToDeleteRows = false;
            this.dgvAutomobili.AllowUserToResizeColumns = false;
            this.dgvAutomobili.AllowUserToResizeRows = false;
            this.dgvAutomobili.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAutomobili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobili.Cursor = System.Windows.Forms.Cursors.No;
            this.dgvAutomobili.Enabled = false;
            this.dgvAutomobili.Location = new System.Drawing.Point(12, 12);
            this.dgvAutomobili.Name = "dgvAutomobili";
            this.dgvAutomobili.ReadOnly = true;
            this.dgvAutomobili.Size = new System.Drawing.Size(1190, 296);
            this.dgvAutomobili.TabIndex = 0;
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClanovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(12, 401);
            this.dgvClanovi.MultiSelect = false;
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.ReadOnly = true;
            this.dgvClanovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanovi.Size = new System.Drawing.Size(513, 264);
            this.dgvClanovi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datum pocetka:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum kraja:";
            // 
            // txtDatumPocetka
            // 
            this.txtDatumPocetka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumPocetka.Enabled = false;
            this.txtDatumPocetka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumPocetka.Location = new System.Drawing.Point(830, 354);
            this.txtDatumPocetka.Name = "txtDatumPocetka";
            this.txtDatumPocetka.Size = new System.Drawing.Size(263, 31);
            this.txtDatumPocetka.TabIndex = 4;
            // 
            // txtDatumKraja
            // 
            this.txtDatumKraja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumKraja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumKraja.Location = new System.Drawing.Point(830, 425);
            this.txtDatumKraja.Name = "txtDatumKraja";
            this.txtDatumKraja.Size = new System.Drawing.Size(263, 31);
            this.txtDatumKraja.TabIndex = 5;
            // 
            // btnIznajmi
            // 
            this.btnIznajmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIznajmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIznajmi.Location = new System.Drawing.Point(940, 558);
            this.btnIznajmi.Name = "btnIznajmi";
            this.btnIznajmi.Size = new System.Drawing.Size(153, 66);
            this.btnIznajmi.TabIndex = 6;
            this.btnIznajmi.Text = "Iznajmi";
            this.btnIznajmi.UseVisualStyleBackColor = true;
            this.btnIznajmi.Click += new System.EventHandler(this.BtnIznajmi_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unesite ime clana:";
            // 
            // txtUnosClanova
            // 
            this.txtUnosClanova.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnosClanova.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnosClanova.Location = new System.Drawing.Point(207, 351);
            this.txtUnosClanova.Name = "txtUnosClanova";
            this.txtUnosClanova.Size = new System.Drawing.Size(318, 31);
            this.txtUnosClanova.TabIndex = 8;
            this.txtUnosClanova.TextChanged += new System.EventHandler(this.TxtUnosClanova_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(879, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "(dd-MM-yyyy)";
            // 
            // FrmIznajmljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 677);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnosClanova);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIznajmi);
            this.Controls.Add(this.txtDatumKraja);
            this.Controls.Add(this.txtDatumPocetka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClanovi);
            this.Controls.Add(this.dgvAutomobili);
            this.Name = "FrmIznajmljivanje";
            this.Text = "Iznajmljivanje";
            this.Load += new System.EventHandler(this.FrmIznajmljivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomobili;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatumPocetka;
        private System.Windows.Forms.TextBox txtDatumKraja;
        private System.Windows.Forms.Button btnIznajmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnosClanova;
        private System.Windows.Forms.Label label4;
    }
}