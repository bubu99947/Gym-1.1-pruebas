using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gym_1_1_pruebas.Model
{
    class Socio : Persona
    {
        public string clave { get; set; }
        public string sexo { get; set; }
        public Image foto { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
