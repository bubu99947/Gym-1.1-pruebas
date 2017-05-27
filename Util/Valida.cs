using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Gym_1_1_pruebas.Util
{
    public class Valida
    {

        public bool alfanumerico(TextBox alfanumerico,ErrorProvider epError)
        {

            string value = alfanumerico.Text = alfanumerico.Text.Trim();

            foreach (char car in value)
            {
                if (!char.IsLetterOrDigit(car) && car != (char)Keys.Space)
                {
                    epError.SetError(alfanumerico, "");
                    epError.SetError(alfanumerico, "Error! Solo se permiten letras y números");
                    return false;
                }
            }

            epError.SetError(alfanumerico, "");
            return true;
        }

        public bool isNumero(TextBox txt, ErrorProvider epError, int tamanio)
        {
            string value = txt.Text = txt.Text.Trim();
            if (value.Length != 0)
            {
                if (txt.Text.Length != tamanio)
                {
                    epError.SetError(txt, "");
                    epError.SetError(txt, "Error! Deben de ser " + tamanio.ToString() + " digitos");
                    return false;
                }

                foreach (char car in value)
                    if (!char.IsDigit(car))
                    {
                        epError.SetError(txt, "");
                        epError.SetError(txt, "Error! Solo se permiten números");
                        return false;
                    }

                epError.SetError(txt, "");
                return true;
            }
            return true;
        }




        /////////////////////////////////////////////////////////////////
/*
        public bool isCadena(string value)
        {
            value = value.Trim();

            foreach (char car in value)
            {
                if (!char.IsLetter(car) && car != (char)Keys.Space)
                {
                    return false;
                }
            }

            return true;
        }

        public bool isCadena(TextBox txt, ErrorProvider epError)
        {
            string value = txt.Text.Trim();

            foreach (char car in value)
            {
                if (!char.IsLetter(car) && car != (char)Keys.Space)
                {
                    epError.SetError(txt, "");
                    epError.SetError(txt, "Solo se permiten letras");
                    return false;
                }
            }
            epError.SetError(txt, "");
            return true;
        }

        public bool isCharacter(char key, bool espacio = false)
        {
            return (char.IsLetter(key) || (espacio && key == ' '));
        }

        public bool isCharacterOrDigit(char key)
        {
            return char.IsLetterOrDigit(key);
        }

        public bool isEmailValidCaracter(char key)
        {

            if (isCharacterOrDigit(key) || key == '_' || key == '@' || key == '.')
            {
                return true;
            }

            return false;
        }

        public bool isEmail(string value)
        {
            value = value.Trim();
            char car;
            bool existe_punto = false;
            short caracteres_despues = 0;
            int tamano = value.Length;

            //valida que la cadena no empiece o termine con @ 
            if ((value[0] == '@') || value[tamano - 1] == '@')
            {
                return false;
            }


            for (int i = 0; i < tamano; i++)
            {
                car = value[i];

                //valida que la cadena solo contenga caracteres validos
                if ((car < 48 || (car < 65 && car > 57) || (car > 90 && car < 97) || car > 122) && (car != 46 && car != 64 && car != 95))
                {
                    return false;
                }

                //valida que la cadena sea un correo
                if (value[i] == '@')
                {
                    int j = i + 1;
                    while (j < tamano)
                    {
                        if (value[j] == '@')
                            return false;

                        if (caracteres_despues < 2 && (value[j] == 46 || j == (tamano + 1)))
                            return false;

                        caracteres_despues++;

                        if (caracteres_despues > 2 && value[j] == 46)
                        {
                            caracteres_despues = 0;
                            existe_punto = true;
                        }

                        j++;
                    }
                }

            }
            return existe_punto;
        }
        */
        public bool isEmail(TextBox txt, ErrorProvider epError)
        {
            string value = txt.Text = txt.Text.Trim();
            char car;
            bool existe_punto = false;
            short caracteres_despues = 0;
            int tamano = value.Length;

            if (tamano > 0)
            {
                //valida que la cadena no empiece o termine con @ ó .
                if ((value[0] == '@') || value[tamano - 1] == '@' || (value[0] == '.') || value[tamano - 1] == '.')
                {
                    epError.SetError(txt, "");
                    epError.SetError(txt, "No puede iniciar ni terminar con \"@\" o \".\"");
                    return false;
                }

                for (int i = 0; i < tamano; i++)
                {
                    car = value[i];

                    //valida que la cadena solo contenga caracteres validos
                    if ((car < 48 || (car < 65 && car > 57) || (car > 90 && car < 97) || car > 122) && (car != 46 && car != 64 && car != 95))
                    {
                        epError.SetError(txt, "");
                        epError.SetError(txt, "Solo se permiten \".\",\"_\",letras y números");
                        return false;
                    }

                    //valida que la cadena sea un correo
                    if (value[i] == '@')
                    {
                        if (i < 4)
                        {
                            epError.SetError(txt, "");
                            epError.SetError(txt, "4 caracteres minimos antes del @");
                            return false;
                        }

                        int j = i + 1;
                        //checa desde que se encontró el @ hasta el final de la cadena si tiene el formato @xx.xx
                        while (j < tamano)
                        {
                            //si existe más de una @ es cadena inválida
                            if (value[j] == '@')
                            {
                                epError.SetError(txt, "");
                                epError.SetError(txt, "Solo se permite un \"@\"");
                                return false;
                            }
                            //checa que entre @ y puntos haya mínimo 2 carácteres
                            if (caracteres_despues < 2 && (value[j] == 46 || j == (tamano + 1)))
                            {
                                epError.SetError(txt, "");
                                epError.SetError(txt, "Entre cada \".\" tiene que existir mínimo 2 carácteres");
                                return false;
                            }

                            caracteres_despues++;

                            if (caracteres_despues > 2 && value[j] == 46)
                            {
                                caracteres_despues = 0;
                                existe_punto = true;
                            }

                            j++;
                        }
                    }

                }

                if (value[tamano - 1] == 46 || value[tamano - 2] == 46)
                    existe_punto = false;

                if (existe_punto)
                    epError.SetError(txt, "");
                else
                {
                    epError.SetError(txt, "");
                    epError.SetError(txt, "El formato es incorrecto");
                }


                return existe_punto;
            }
            return true;

        }
        /*
        public bool isNumero(String value)
        {
            value = value.Trim();

            foreach (char car in value)
                if (!char.IsDigit(car))
                    return false;
            return true;
        }
        */
        public bool isNumero(TextBox txt, ErrorProvider epError, int tamMax, int tamMin)
        {
            string value = txt.Text = txt.Text.Trim();

            if (txt.Text.Length < tamMin && txt.Text.Length != 0)
            {
                epError.SetError(txt, "");
                epError.SetError(txt, "Error! Mínimo " + tamMin.ToString() + " digitos");
                return false;
            }

            if (txt.Text.Length > tamMax && txt.Text.Length != 0)
            {
                epError.SetError(txt, "");
                epError.SetError(txt, "Error! Máximo " + tamMax.ToString() + " digitos");
                return false;
            }

            foreach (char car in value)
                if (!char.IsDigit(car))
                {
                    epError.SetError(txt, "");
                    epError.SetError(txt, "Error! Solo se permiten números");
                    return false;
                }

            epError.SetError(txt, "");
            return true;
        }
        /*
        public bool isRFC(TextBox txt, ErrorProvider epError)
        {
            string value = txt.Text.Trim();

            if (value.Length != 13 && value.Length != 0)
            {
                epError.SetError(txt, "");
                epError.SetError(txt, "Requerido 13 carácteres");
                return false;
            }

            //valida que la cadena solo contenga caracteres validos
            foreach (char car in value)
                if ((car < 48 || (car < 65 && car > 57) || (car > 90 && car < 97) || car > 122))
                {
                    epError.SetError(txt, "");
                    epError.SetError(txt, "Solo se permiten letras y números");
                    return false;
                }
            epError.SetError(txt, "");
            return true;
        }
        /*

        public bool isCadenaONumero(TextBox txt, ErrorProvider epError)
        {
            string value = txt.Text.Trim();

            foreach (char car in value)
            {
                if (!char.IsLetterOrDigit(car) && car != (char)Keys.Space)
                {
                    epError.SetError(txt, "");
                    epError.SetError(txt, "Error! Solo se permiten letras y números");
                    return false;
                }
            }

            epError.SetError(txt, "");
            return true;
        }
        */
        //Validacion con expresiones regulares
        public bool isReal(TextBox txt, ErrorProvider epError)
        {
            //Solo permite numeros reales
            string value = txt.Text.Trim();
            string evalReal = "^[0-9]*\\.?[0-9]*$";
            Match match = Regex.Match(value, evalReal);

            if (!match.Success)
            {
                epError.SetError(txt, "");
                epError.SetError(txt, "El formato es inválido");
            }
            else
            {
                epError.SetError(txt, "");
            }

            return match.Success;
        }/*

        //Validacion con expresiones regulares
        private bool isEntero(TextBox txt, ErrorProvider epError)
        {
            string value = txt.Text.Trim();
            string evalEntero = "^\\d*$";
            Match match = Regex.Match(value, evalEntero);

            if (!match.Success)
            {
                epError.SetError(txt, "");
                epError.SetError(txt, "Solo se aceptan enteros");
            }
            else
            {
                epError.SetError(txt, "");
            }

            return match.Success;
        }

        public bool isEntero(string txt)
        {
            txt = txt.Trim();
            string evalEntero = "^\\d*$";//"^(\w+?\s)*$";
            Match match = Regex.Match(txt, evalEntero);

            return match.Success;
        }

        //Validacion con expresiones regulares
        public bool isCadena(ErrorProvider epError, TextBox txt)
        {
            string value = txt.Text.Trim();
            string evalCadena = "^(\\w+?\\.?\\s?)*$";
            Match match = Regex.Match(value, evalCadena, RegexOptions.Multiline | RegexOptions.CultureInvariant);

            if (!match.Success)
            {
                epError.SetError(txt, "");
                epError.SetError(txt, "Solo se aceptan carácteres");
            }
            else
            {
                epError.SetError(txt, "");
            }

            return match.Success;
        }

        public bool isUsuario(TextBox txt, ErrorProvider epError)
        {
            string value = txt.Text.Trim();
            string evalCadena = "^(\\w+?\\d*)*$";
            Match match = Regex.Match(value, evalCadena, RegexOptions.CultureInvariant);

            if (!match.Success)
            {
                epError.SetError(txt, "");
                epError.SetError(txt, "Solo se permiten letras y numeros");

            }
            else
                epError.SetError(txt, "");

            return match.Success;
        }

    
    */
    }




}
