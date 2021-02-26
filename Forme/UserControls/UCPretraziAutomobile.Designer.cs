namespace Forme.UserControls
{
    partial class UCPretraziAutomobile
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
            this.dgvAutomobili = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKubikaza = new System.Windows.Forms.TextBox();
            this.btnOceni = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnIznajmi = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutomobili
            // 
            this.dgvAutomobili.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAutomobili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobili.Location = new System.Drawing.Point(16, 200);
            this.dgvAutomobili.Name = "dgvAutomobili";
            this.dgvAutomobili.ReadOnly = true;
            this.dgvAutomobili.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutomobili.Size = new System.Drawing.Size(672, 433);
            this.dgvAutomobili.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraga automobila";
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistracija.Location = new System.Drawing.Point(371, 153);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(131, 25);
            this.lblRegistracija.TabIndex = 2;
            this.lblRegistracija.Text = "Registracija:";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegistracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistracija.Location = new System.Drawing.Point(522, 147);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(166, 31);
            this.txtRegistracija.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model:";
            // 
            // cbMarka
            // 
            this.cbMarka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(116, 92);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(207, 33);
            this.cbMarka.TabIndex = 6;
            // 
            // cbModel
            // 
            this.cbModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(116, 147);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(207, 33);
            this.cbModel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Max kubikaza:";
            // 
            // txtKubikaza
            // 
            this.txtKubikaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKubikaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKubikaza.Location = new System.Drawing.Point(522, 92);
            this.txtKubikaza.Name = "txtKubikaza";
            this.txtKubikaza.Size = new System.Drawing.Size(166, 31);
            this.txtKubikaza.TabIndex = 9;
            // 
            // btnOceni
            // 
            this.btnOceni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOceni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOceni.Location = new System.Drawing.Point(569, 650);
            this.btnOceni.Name = "btnOceni";
            this.btnOceni.Size = new System.Drawing.Size(119, 55);
            this.btnOceni.TabIndex = 10;
            this.btnOceni.Text = "Oceni";
            this.btnOceni.UseVisualStyleBackColor = true;
            this.btnOceni.Click += new System.EventHandler(this.BtnOceni_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUkloni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloni.Location = new System.Drawing.Point(444, 650);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(119, 55);
            this.btnUkloni.TabIndex = 11;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.BtnUkloni_Click);
            // 
            // btnIznajmi
            // 
            this.btnIznajmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIznajmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIznajmi.Location = new System.Drawing.Point(319, 650);
            this.btnIznajmi.Name = "btnIznajmi";
            this.btnIznajmi.Size = new System.Drawing.Size(119, 55);
            this.btnIznajmi.TabIndex = 13;
            this.btnIznajmi.Text = "Iznajmi";
            this.btnIznajmi.UseVisualStyleBackColor = true;
            this.btnIznajmi.Click += new System.EventHandler(this.BtnIznajmi_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(16, 650);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(119, 55);
            this.btnPretrazi.TabIndex = 14;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.BtnPretrazi_Click);
            // 
            // UCPretraziAutomobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnIznajmi);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnOceni);
            this.Controls.Add(this.txtKubikaza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAutomobili);
            this.Name = "UCPretraziAutomobile";
            this.Size = new System.Drawing.Size(703, 737);
            this.Load += new System.EventHandler(this.UCPretraziAutomobile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobili)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomobili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKubikaza;
        private System.Windows.Forms.Button btnOceni;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnIznajmi;
        private System.Windows.Forms.Button btnPretrazi;
    }
}
