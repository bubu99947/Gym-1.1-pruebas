using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_1_1_pruebas.View_Model
{
    class RutinasViewModel
    {
        private List<DiasEjercicio> diasEjercicios;

        
        public bool asignarRutina(int claveSocio,DateTime fechaInicio, DateTime fechaFin, string notas) {

            return true;
        }


        public System.Data.DataTable buscarRutina(int claveSocio, string nombreSocio)
        {
            return null;
        }

        public void agregarDiasEjercicio(int idEjercicio, bool lunes, bool martes, bool miercoles, bool jueves, bool viernes, bool sabado, bool domingo) {



        }



        private bool borrarDiasEjercicio(int idEjercicio) {
            return true;
        }

        public class DiasEjercicio
        {
            int idEjercicio;
            bool lunes, martes, miercoles, jueves, viernes, sabado, domingo;

        }




    }
}
