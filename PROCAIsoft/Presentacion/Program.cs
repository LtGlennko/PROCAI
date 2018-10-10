using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
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
<<<<<<< HEAD
            Application.Run(new BuscarGrupo());
=======
            Application.Run(new frmRegYeditEncuestas(1));
>>>>>>> 3ae4ef29592f23d100130330a37c2b7741dc79d8
        }
    }
}
