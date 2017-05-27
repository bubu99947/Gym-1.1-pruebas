using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_1_1_pruebas.Model;

namespace Gym_1_1_pruebas.View_Model
{
    class EjerciciosViewModel
    {
        private List<Ejercicio> ejercicios;
        private String parametrosBusqueda;
        

        public bool alta(string nombre, string descripcion, int series, int repeticones, string tipo)
        {
            return true;
            //throw NotImplementedException();
        }

        public bool baja(int id)
        {
            return true;
            //throw NotImplementedException();
        }

        public List<Ejercicio> buscar(int id, string nombre,string descripcion)
        {
            return null;
            //throw NotImplementedException();
        }

        public List<Ejercicio> refresh()
        {
            return null;
        }

        
    }
}
