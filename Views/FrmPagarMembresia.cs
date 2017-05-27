using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_1_1_pruebas.Model;

namespace Gym_1_1_pruebas.Views
{
    public partial class FrmPagarMembresia : Form
    {
        
        
        View_Model.SocioViewModel adminSocios;
        View_Model.MembresiasViewModel adminMembresias;
        View_Model.PromocionesViewModel adminPromociones;
        View_Model.MembresiaSocioViewModel adminMembresiSocio;

        GimnasioPruebasDataSet.MembresiasRow membresiaSeleccionada;
        GimnasioPruebasDataSet.SociosRow socioSeleccionado;
        GimnasioPruebasDataSet.PromocionesRow promocionSeleccionada;
        Util.ValidacionesImplementadas validaciones;
        ErrorProvider muestraError;

        public FrmPagarMembresia()
        {
            adminSocios = new View_Model.SocioViewModel();
            adminPromociones = new View_Model.PromocionesViewModel();
            adminMembresias = new View_Model.MembresiasViewModel();
            adminMembresiSocio = new View_Model.MembresiaSocioViewModel();

            muestraError = new ErrorProvider();
            Util.UpperCase mayusculas = new Util.UpperCase();
            validaciones = new Util.ValidacionesImplementadas(muestraError);
            InitializeComponent();
            //eventos de mayusculas
            txtBuscarSocio.KeyPress += mayusculas.txtKeyPress;
            txtBuscarTipoMembresia.KeyPress += mayusculas.txtKeyPress;
            txtCodigoDescuento.KeyPress += mayusculas.txtKeyPress;
            //eventos de validacion
            txtBuscarSocio.Validating += validaciones.txtAlfanumericoValidating;
            txtBuscarTipoMembresia.Validating += validaciones.txtAlfanumericoValidating;
            txtCobro.Validating += validaciones.txtRealValidating;
            txtPorciento.TextChanged += actualizaPrecioTotal;
            txtCobro.TextChanged += actualizaPrecioTotal;
            txtCostoMembresia.TextChanged += actualizaPrecioTotal;

            this.FormClosing += new Util.EventosGenericos().formClosing;

        }

        private void FrmPagarMembresia_Load(object sender, EventArgs e)
        {
            dtmFechaInicio.ValueChanged -= dtmFechaInicio_ValueChanged;
            dtmFechaInicio.MinDate = DateTime.Now;
            dtmFechaInicio.ValueChanged += dtmFechaInicio_ValueChanged;
            dtmFechaFInal.Enabled = false;
            adminPromociones.obtieneVigentes();
            txtPorciento.Text = "0";
            txtCostoNeto.Text = "0";



        }

        private void btnBuscarMembresia_Click(object sender, EventArgs e)
        {
            GimnasioPruebasDataSet.MembresiasDataTable membresias = new GimnasioPruebasDataSet.MembresiasDataTable();
            FrmSeleccionar selecciona;
           // if (txtBuscarTipoMembresia.Text != string.Empty)
            //{
                membresias = adminMembresias.buscar(txtBuscarTipoMembresia.Text);
                if (membresias.Count != 0)
                {
                    selecciona = new FrmSeleccionar(membresias);
                    selecciona.ShowDialog();
                    
                    if (selecciona.seleccionadoId != -1) {
                        membresiaSeleccionada = adminMembresias.buscarLocal(selecciona.seleccionadoId);
                        actualizaCamposMembresia();
                    }
                        
                }

            //}

        }

        private void dtmFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            actualizaFechaFinal();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            GimnasioPruebasDataSet.SociosDataTable socios = new GimnasioPruebasDataSet.SociosDataTable();
            FrmSeleccionar selecciona;
            //if (txtBuscarSocio.Text != string.Empty) {
                adminSocios.buscarNombre(txtBuscarSocio.Text,socios);
                if (socios.Count != 0) {
                    selecciona = new FrmSeleccionar(socios);
                    selecciona.ShowDialog();

                    if (selecciona.seleccionadoId != -1) {
                        socioSeleccionado = adminSocios.buscquedaLocal(selecciona.seleccionadoId);
                        actualizaCamposSocio();
                    }
                        
                        
                }

            //}
        }

        private void actualizaCamposSocio() {

            txtIdSocio.Text = socioSeleccionado.Clave.ToString();
            txtNombreSocio.Text = socioSeleccionado.Nombres + " " + socioSeleccionado.Apellido_Paterno + " " + socioSeleccionado.Apellido_Materno;
            pctFotoSocio.Image = new Util.Imagen().toImage(socioSeleccionado.Foto);
           

        }

        private void actualizaFechaFinal() {
            if(membresiaSeleccionada!=null)
                dtmFechaFInal.Value = dtmFechaInicio.Value.AddMonths((int)membresiaSeleccionada.Duracion);

        }

        private void actualizaCamposMembresia()
        {
            txtMembresia.Text = membresiaSeleccionada.Nombre;
            txtCostoMembresia.Text = membresiaSeleccionada.Precio.ToString();
            txtDescripcion.Text = membresiaSeleccionada.Descripcion;
            actualizaFechaFinal();

        }
        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void txtCodigoDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoDescuento_Validating(object sender, CancelEventArgs e)
        {
            validaciones.txtCodigoDescuentoValidating(sender,e);

            if (e.Cancel == false) {
                promocionSeleccionada = adminPromociones.busquedaLocal(txtCodigoDescuento.Text);
                if (promocionSeleccionada != null)
                    txtPorciento.Text = promocionSeleccionada.Porcentaje_Descuento.ToString();
                else {
                    txtPorciento.Text = "0";
                    muestraError.SetError((TextBox)sender, "Codigo de promocion invalido");
                    txtCodigoDescuento.Text = string.Empty;
                }
                    

            }
        }

        private void actualizaPrecioTotal(object sender, EventArgs e) {
            if (txtPorciento.Text != "0")
                txtCostoNeto.Text = Math.Round((Convert.ToSingle(txtCostoMembresia.Text) * Convert.ToSingle(txtPorciento.Text) / 100), 2).ToString();
            else if(txtCostoMembresia.Text!=string.Empty)
                txtCostoNeto.Text = Math.Round(Convert.ToSingle(txtCostoMembresia.Text), 2).ToString();


        }


        private void txtCobro_KeyDown(object sender, KeyEventArgs e)
        {
            CancelEventArgs cancelador = new CancelEventArgs();
            if (e.KeyCode == Keys.Enter)
                validaciones.txtRealValidating(txtCobro, cancelador);
            if (!cancelador.Cancel && txtCobro.Text!=string.Empty)
            {
                txtCambio.Text = (Convert.ToSingle(txtCobro.Text) - Convert.ToSingle(txtCostoNeto.Text)).ToString();

            }

        }

        private void txtCodigoDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCodigoDescuento_Validating(txtCodigoDescuento, new CancelEventArgs());
            
        }

        private void btnPagarMembresia_Click(object sender, EventArgs e)
        {
            bool novacios;
            novacios = txtIdSocio.Text != string.Empty && txtMembresia.Text != string.Empty && txtCostoNeto.Text != string.Empty
                     && txtCobro.Text != string.Empty;

            if (novacios)
            {

                int resultado = adminMembresiSocio.renovarMembresia(membresiaSeleccionada.ID, socioSeleccionado.Clave, dtmFechaInicio.Value, dtmFechaFInal.Value, txtCodigoDescuento.Text);
                
                if (resultado != 0)
                    MessageBox.Show("Membresia del socio "+txtNombreSocio.Text+" renovada satisfactoriamente ");
                else
                    MessageBox.Show("Hubo un error, intentalo de nuevo mas tarde");
            }
            else
                MessageBox.Show("Hay campos vacios");
        }
    }
}
