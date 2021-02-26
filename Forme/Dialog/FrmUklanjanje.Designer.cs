namespace Forme
{
    partial class FrmUklanjanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.dgvAutomobiliZaUklanjanje = new System.Windows.Forms.DataGridView();
            this.btnIzbaci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobiliZaUklanjanje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukanjanje:";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.Location = new System.Drawing.Point(566, 429);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(121, 67);
            this.btnUkloni.TabIndex = 2;
            this.btnUkloni.Text = "Ukloni!";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.BtnUkloni_Click);
            // 
            // dgvAutomobiliZaUklanjanje
            // 
            this.dgvAutomobiliZaUklanjanje.AllowUserToAddRows = false;
            this.dgvAutomobiliZaUklanjanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAutomobiliZaUklanjanje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutomobiliZaUklanjanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobiliZaUklanjanje.Location = new System.Drawing.Point(12, 63);
            this.dgvAutomobiliZaUklanjanje.Name = "dgvAutomobiliZaUklanjanje";
            this.dgvAutomobiliZaUklanjanje.ReadOnly = true;
            this.dgvAutomobiliZaUklanjanje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutomobiliZaUklanjanje.Size = new System.Drawing.Size(675, 346);
            this.dgvAutomobiliZaUklanjanje.TabIndex = 3;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbaci.Location = new System.Drawing.Point(12, 429);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(74, 67);
            this.btnIzbaci.TabIndex = 5;
            this.btnIzbaci.Text = "-";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            this.btnIzbaci.Click += new System.EventHandler(this.BtnIzbaci_Click);
            // 
            // FrmUklanjanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 521);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.dgvAutomobiliZaUklanjanje);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.label1);
            this.Name = "FrmUklanjanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uklanjanje automobila";
            this.Load += new System.EventHandler(this.FrmUklanjanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobiliZaUklanjanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.DataGridView dgvAutomobiliZaUklanjanje;
        private System.Windows.Forms.Button btnIzbaci;
    }
}