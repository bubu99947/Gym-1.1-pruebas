using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_1_1_pruebas.Util
{
    class EventosGenericos
    {
        public void formClosing(object sender, FormClosingEventArgs e)
        {
            
            e.Cancel = false;

        }
    }
}
