using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_1_1_pruebas.View_Model
{
    class MembresiasViewModel
    {
        GimnasioPruebasDataSet.MembresiasDataTable membresiasTabla;
        GimnasioPruebasDataSetTableAdapters.MembresiasTableAdapter membresiasConsultas;

        public MembresiasViewModel() {
            membresiasTabla = new GimnasioPruebasDataSet.MembresiasDataTable();
            membresiasConsultas = new GimnasioPruebasDataSetTableAdapters.MembresiasTableAdapter();

        }
            




        public GimnasioPruebasDataSet.MembresiasDataTable buscar(string nombre)
        {
            try {
                membresiasTabla = membresiasConsultas.ObtieneBuscar(nombre);
                return membresiasTabla;
            }
            catch (Exception e) {
                return new GimnasioPruebasDataSet.MembresiasDataTable();
            }
            
        }

        public GimnasioPruebasDataSet.MembresiasRow buscarLocal(int id) {

            return membresiasTabla.FindByID(id);

        }


    }
}
