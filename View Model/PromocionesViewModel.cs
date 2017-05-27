using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_1_1_pruebas.View_Model
{
    class PromocionesViewModel
    {
        GimnasioPruebasDataSet.PromocionesDataTable tablaPromociones;
        GimnasioPruebasDataSetTableAdapters.PromocionesTableAdapter promocionesTA;
        public PromocionesViewModel() {
            promocionesTA = new GimnasioPruebasDataSetTableAdapters.PromocionesTableAdapter();
            tablaPromociones = new GimnasioPruebasDataSet.PromocionesDataTable();
        }

        public GimnasioPruebasDataSet.PromocionesDataTable obtieneVigentes() {
            try {
                promocionesTA.rellenaVigentes(tablaPromociones);
                return tablaPromociones;

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return new GimnasioPruebasDataSet.PromocionesDataTable();
            }

        }

        public GimnasioPruebasDataSet.PromocionesRow busquedaLocal(string codigo) {

            return tablaPromociones.FindBycodigo(codigo);

        }
    }
}
