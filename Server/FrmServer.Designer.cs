namespace Server
{
    partial class FrmServer
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
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.lblTrenutnoVreme = new System.Windows.Forms.Label();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPokreni
            // 
            this.btnPokreni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPokreni.Location = new System.Drawing.Point(12, 12);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(201, 45);
            this.btnPokreni.TabIndex = 0;
            this.btnPokreni.Text = "Pokreni";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.BtnPokreni_Click);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZaustavi.Location = new System.Drawing.Point(219, 12);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(201, 45);
            this.btnZaustavi.TabIndex = 1;
            this.btnZaustavi.Text = "Zaustavi";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            this.btnZaustavi.Click += new System.EventHandler(this.BtnZaustavi_Click);
            // 
            // lblTrenutnoVreme
            // 
            this.lblTrenutnoVreme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrenutnoVreme.AutoSize = true;
            this.lblTrenutnoVreme.Location = new System.Drawing.Point(603, 28);
            this.lblTrenutnoVreme.Name = "lblTrenutnoVreme";
            this.lblTrenutnoVreme.Size = new System.Drawing.Size(35, 13);
            this.lblTrenutnoVreme.TabIndex = 2;
            this.lblTrenutnoVreme.Text = "label1";
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Location = new System.Drawing.Point(13, 79);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.Size = new System.Drawing.Size(775, 359);
            this.dgvKlijenti.TabIndex = 3;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.lblTrenutnoVreme);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Name = "FrmServer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Label lblTrenutnoVreme;
        private System.Windows.Forms.DataGridView dgvKlijenti;
    }
}

