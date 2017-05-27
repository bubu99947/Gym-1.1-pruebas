using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_1_1_pruebas.Util
{
    class ValidacionesImplementadas
    {
        ErrorProvider epError;
        Valida validar = new Valida();
        

        public ValidacionesImplementadas(ErrorProvider epError)
        {
            this.epError = epError;
        }

        public void txtAlfanumericoValidating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            bool correcto;
           

            correcto = validar.alfanumerico(txt, epError);
            e.Cancel = !correcto;
        }

        public void txtCodigoDescuentoValidating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            bool correcto;

            correcto = validar.isNumero(txt, epError,5);
            e.Cancel = !correcto;
        }

        public void txtEmailValidating(Object sender, CancelEventArgs e) {
            TextBox txt = (TextBox)sender;
            bool correcto;

            correcto = validar.isEmail(txt, epError);
            e.Cancel = !correcto;

        }

        public void txtTelefonoValidating(Object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            bool correcto;

            correcto = validar.isNumero(txt, epError,10,10);
            e.Cancel = !correcto;

        }


        public void txtRealValidating(Object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            bool correcto;

            correcto = validar.isReal(txt, epError);
            e.Cancel = !correcto;

        }


    }
}
