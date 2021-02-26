using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Helpers
{
    public static class UserControlHelpers
    {
        public static bool DobroUnetTextBox(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.Red;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static void OcistiTextBoxove(List<TextBox> listaTextBoxova)
        {
            foreach(TextBox txt in listaTextBoxova)
            {
                txt.Text = "";
            }
        }
        public static DateTime? DobraFormaDatuma(string txtDatumKraja)
        {
            DateTime datumKraja;
            string[] cifre = new string[3];

            if (!DateTime.TryParseExact(txtDatumKraja.Trim(), "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return null;
            }
            datumKraja = DateTime.ParseExact(txtDatumKraja.Trim(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            if (DateTime.Compare(datumKraja, DateTime.Now) > 0)
            {
                return datumKraja;
            }
            return null;
        }
        internal static bool DobarFormatKubikaze(TextBox txt)
        {
            if (!Double.TryParse(txt.Text, out _) || Double.Parse(txt.Text) < 0 || Double.Parse(txt.Text) > 10000)
            {
                txt.BackColor = Color.Red;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
        public static void DobroUnetaRegistracija(TextBox txt)
        {
            if (DobraRegistracija(txt.Text))
            {
                txt.BackColor = Color.White;
                return;
            }
            txt.BackColor = Color.Red;
            throw new Exception("Registracija mora biti u formatu: xx-yyyy-xx (gde x predstavlja slovo, a y cifru)");
        }

        private static bool DobraRegistracija(string registracija)
        {
            string[] deo = registracija.Split('-');
            if (deo[0].Length != 2 || deo[1].Length != 4 || deo[2].Length != 2)
            {
                return false;
            }
            for (int i = 0; i < 3; i += 2)
            {
                foreach (char c in deo[0])
                {
                    if (!char.IsLetter(c))
                    {
                        return false;
                    }
                }
            }
            foreach (char c in deo[1])
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
