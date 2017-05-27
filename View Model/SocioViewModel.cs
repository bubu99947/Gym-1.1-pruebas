using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_1_1_pruebas.Model;


namespace Gym_1_1_pruebas.View_Model
{
    class SocioViewModel
    {
        GimnasioPruebasDataSet.SociosDataTable sociosTabla;
        GimnasioPruebasDataSetTableAdapters.SociosTableAdapter sociosConsultas;
        Util.Imagen formatoImagen;

        public SocioViewModel() {
            sociosTabla = new GimnasioPruebasDataSet.SociosDataTable();
            sociosConsultas = new GimnasioPruebasDataSetTableAdapters.SociosTableAdapter();
            formatoImagen = new Util.Imagen();

        }

        public int alta(string nombre,string apellidoPaterno,string apellidoMaterno,DateTime fechaNacimiento,string sexo, string telefono,string email, System.Drawing.Bitmap foto )
        {
            try {
                return sociosConsultas.Insert(nombre, apellidoPaterno, apellidoMaterno, sexo, email, telefono, fechaNacimiento, formatoImagen.toByteArray(foto));
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return 0;

            }
            

            
            //throw NotImplementedException();
        }

        public bool baja(int clave)
        {
            return true;
            //throw NotImplementedException();
        }


        public GimnasioPruebasDataSet.SociosDataTable buscarNombre(string nombre) {

            try
            {
                
                sociosTabla = sociosConsultas.ObtieneBuscarNombre(nombre);
                return sociosTabla;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new GimnasioPruebasDataSet.SociosDataTable();
            }

        }
        public void buscarNombre(string nombre,GimnasioPruebasDataSet.SociosDataTable sociosEncontrados)
        {
            try
            {
                sociosTabla = sociosEncontrados;
                sociosConsultas.RellenaBuscarNombre(sociosEncontrados,nombre);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }

        }
        public GimnasioPruebasDataSet.SociosRow buscquedaLocal(int clave)
        {
            return sociosTabla.FindByClave(clave);
            
        }

        

        public GimnasioPruebasDataSet.SociosDataTable refresh()
        {
            try
            {
                return sociosConsultas.GetData();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new GimnasioPruebasDataSet.SociosDataTable();
            }
        }

        public int rellena(GimnasioPruebasDataSet.SociosDataTable socios)
        {
            try
            {
                return sociosConsultas.Fill(socios);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }



    }
}
