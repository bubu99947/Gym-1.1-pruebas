using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_1_1_pruebas.Views;

namespace Gym_1_1_pruebas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Views.FrmAdministracionGimnasio());
            //Application.Run(new Views.FrmPagarMembresia());
            //Application.Run(new Formprueba());
            Application.Run(new FrmAdministracionGimnasio());
        }
    }
}
