namespace Forme.UserControls
{
    partial class UCDodajKorisnika
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAdminClan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.lblFizickoPravno = new System.Windows.Forms.Label();
            this.cbFizickoPravno = new System.Windows.Forms.ComboBox();
            this.btnSacuvajKorisnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novi korisnik";
            // 
            // cbAdminClan
            // 
            this.cbAdminClan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAdminClan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdminClan.FormattingEnabled = true;
            this.cbAdminClan.Location = new System.Drawing.Point(245, 153);
            this.cbAdminClan.Name = "cbAdminClan";
            this.cbAdminClan.Size = new System.Drawing.Size(189, 28);
            this.cbAdminClan.TabIndex = 1;
            this.cbAdminClan.SelectedIndexChanged += new System.EventHandler(this.CbAdminClan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korisnicko ime:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lozinka:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ime:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prezime:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(245, 205);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(189, 26);
            this.txtKorisnickoIme.TabIndex = 6;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.Location = new System.Drawing.Point(245, 249);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(189, 26);
            this.txtLozinka.TabIndex = 7;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(245, 294);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(189, 26);
            this.txtIme.TabIndex = 8;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(245, 338);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(189, 26);
            this.txtPrezime.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(569, 155);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 11;
            // 
            // lblPozicija
            // 
            this.lblPozicija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPozicija.AutoSize = true;
            this.lblPozicija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.Location = new System.Drawing.Point(130, 387);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(66, 20);
            this.lblPozicija.TabIndex = 12;
            this.lblPozicija.Text = "Pozicija:";
            this.lblPozicija.Visible = false;
            // 
            // txtPozicija
            // 
            this.txtPozicija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPozicija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPozicija.Location = new System.Drawing.Point(245, 387);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.Size = new System.Drawing.Size(100, 26);
            this.txtPozicija.TabIndex = 13;
            this.txtPozicija.Visible = false;
            // 
            // lblFizickoPravno
            // 
            this.lblFizickoPravno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFizickoPravno.AutoSize = true;
            this.lblFizickoPravno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFizickoPravno.Location = new System.Drawing.Point(44, 390);
            this.lblFizickoPravno.Name = "lblFizickoPravno";
            this.lblFizickoPravno.Size = new System.Drawing.Size(154, 20);
            this.lblFizickoPravno.TabIndex = 14;
            this.lblFizickoPravno.Text = "Fizicko ili pravno lice:";
            this.lblFizickoPravno.Visible = false;
            // 
            // cbFizickoPravno
            // 
            this.cbFizickoPravno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFizickoPravno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFizickoPravno.FormattingEnabled = true;
            this.cbFizickoPravno.Location = new System.Drawing.Point(245, 385);
            this.cbFizickoPravno.Name = "cbFizickoPravno";
            this.cbFizickoPravno.Size = new System.Drawing.Size(121, 28);
            this.cbFizickoPravno.TabIndex = 15;
            this.cbFizickoPravno.Visible = false;
            // 
            // btnSacuvajKorisnika
            // 
            this.btnSacuvajKorisnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajKorisnika.Location = new System.Drawing.Point(517, 262);
            this.btnSacuvajKorisnika.Name = "btnSacuvajKorisnika";
            this.btnSacuvajKorisnika.Size = new System.Drawing.Size(152, 58);
            this.btnSacuvajKorisnika.TabIndex = 16;
            this.btnSacuvajKorisnika.Text = "Sacuvaj korisnika";
            this.btnSacuvajKorisnika.UseVisualStyleBackColor = true;
            this.btnSacuvajKorisnika.Click += new System.EventHandler(this.BtnSacuvajKorisnika_Click);
            // 
            // UCDodajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSacuvajKorisnika);
            this.Controls.Add(this.cbFizickoPravno);
            this.Controls.Add(this.lblFizickoPravno);
            this.Controls.Add(this.txtPozicija);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAdminClan);
            this.Controls.Add(this.label1);
            this.Name = "UCDodajKorisnika";
            this.Size = new System.Drawing.Size(748, 540);
            this.Load += new System.EventHandler(this.UCDodajKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAdminClan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.TextBox txtPozicija;
        private System.Windows.Forms.Label lblFizickoPravno;
        private System.Windows.Forms.ComboBox cbFizickoPravno;
        private System.Windows.Forms.Button btnSacuvajKorisnika;
    }
}
