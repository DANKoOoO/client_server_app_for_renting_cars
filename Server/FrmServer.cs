using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Vreme;
            timer.Start();
        }

        private void Vreme(object sender, EventArgs e)
        {
            lblTrenutnoVreme.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void BtnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();

                Thread thread = new Thread(s.Listen);
                thread.IsBackground = true;
                thread.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                s.Korisnici.ListChanged += Korisnici_ListChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Korisnici_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvKlijenti.Invoke(new Action(()=> dgvKlijenti.DataSource = s.Korisnici.ToList()));
        }

        private void BtnZaustavi_Click(object sender, EventArgs e)
        {
            s.Stop();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
        }
    }
}
