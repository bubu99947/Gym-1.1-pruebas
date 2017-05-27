using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_1_1_pruebas.View_Model
{
    class MembresiaSocioViewModel
    {
        GimnasioPruebasDataSet.MembresiaSocioDataTable membresiaSocioDataTable;
        GimnasioPruebasDataSetTableAdapters.MembresiaSocioTableAdapter membresiaSocioTableAdapter;

        public MembresiaSocioViewModel() {
            membresiaSocioDataTable = new GimnasioPruebasDataSet.MembresiaSocioDataTable();
            membresiaSocioTableAdapter = new GimnasioPruebasDataSetTableAdapters.MembresiaSocioTableAdapter();

        }


        public int renovarMembresia(int idMembresia,int claveSocio,DateTime fechaInicial,DateTime fechaFin,string codigoPromocion) {

            try
            {
                if (codigoPromocion == string.Empty)
                    codigoPromocion = null;
                return membresiaSocioTableAdapter.RenovarMembresia(idMembresia, claveSocio, fechaInicial.ToString(), fechaFin.ToString(), codigoPromocion);

            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }
         
    }
}
