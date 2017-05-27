using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_1_1_pruebas.Model
{
    class Empleado : Persona
    {
        public int id { get; set; }
        public bool esEntrenador { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        

    }
}
