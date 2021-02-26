using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogIn());
            while (true)
            {
                try
                {
                    MainCoordinator.Instance.OtvoriLogInFormu();
                    Application.Run();
                }
                catch (ServerException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
