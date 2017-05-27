using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_1_1_pruebas.Views
{

    //separar cada pesta;a en una clase nueva, PaginaBase que herede de TabPage
    public partial class FrmAdministracionGimnasio : Form
    {
        private bool socioNuevoActivado = false;
        private bool sociosBuscarPorNombre;
        private string sociosValorBusqueda;
        private string dirfoto = string.Empty;
        private View_Model.SocioViewModel adminSocios;
        private Image fotoNuevo;

        #region inicializacion
        public FrmAdministracionGimnasio()
        {
            InitializeComponent();

            ErrorProvider muestraError = new ErrorProvider();
            Util.ValidacionesImplementadas validaciones = new Util.ValidacionesImplementadas(muestraError);
            txtSociosApellidoMaterno.Validating += validaciones.txtAlfanumericoValidating;
            txtSociosApellidoPaterno.Validating += validaciones.txtAlfanumericoValidating;
            txtSociosNombre.Validating += validaciones.txtAlfanumericoValidating;
            txtSociosEmail.Validating += validaciones.txtEmailValidating;
            txtSociosTelefono.Validating += validaciones.txtTelefonoValidating;

            //uppercase
            Util.UpperCase mayusculas = new Util.UpperCase();
            txtSociosApellidoMaterno.KeyPress += mayusculas.txtKeyPress;
            txtSociosApellidoPaterno.KeyPress += mayusculas.txtKeyPress;
            txtSociosEmail.KeyPress += mayusculas.txtKeyPress;
            txtSociosNombre.KeyPress += mayusculas.txtKeyPress;



            this.FormClosing += new Util.EventosGenericos().formClosing;
            
            


            pctbSociosFoto.Image = 
            pctbMembresiaFotoSocio.Image =
            pctbRutinasFotoSocio.Image = Properties.Resources.usuario;

            dgvSocios.RowStateChanged += DgvSocios_RowStateChanged;
            btnSociosBuscar.Click += BtnSociosBuscar_Click;
            dgvMembresias.CellPainting += DgvMembresias_CellPainting;
            adminSocios = new View_Model.SocioViewModel();

            

            
        }

        private void FrmAdministracionGimnasio_Load(object sender, EventArgs e)
        {
            
            adminSocios.rellena(this.gimnasioPruebasDataSet.Socios);


            habilitarDeshabilitarNuevoSocio(false);
            pctbSociosFoto.Image = Properties.Resources.usuario;
            /*if (sdtTemp != null)
                dgvSocios.DataSource = sdtTemp;
            else
                MessageBox.Show("No se ha podido cargar la lista de socios, revisa tu conexión a internet"); */



            rdbtnSociosBuscarNombre.Checked = true;
            sociosBuscarPorNombre = rdbtnSociosBuscarNombre.Checked;
            sociosValorBusqueda = string.Empty;
            cmbSociosSexo.SelectedIndex = 0;
            dtpSociosFechaNacimiento.MaxDate = DateTime.Now.Date.AddYears(-12);
            btnSociosMostrarTodos.Visible = false;



            //membresia
            
            
            
            //rutinas
            rdbtnRutinasBuscarSocioNombre.Checked = true;
            

        }

        #endregion inicializacion
        #region socios
        private void habilitarDeshabilitarNuevoSocio(bool habilitar)
        {
            bool readOnly = !habilitar;
            socioNuevoActivado = habilitar;
            txtSociosApellidoMaterno.ReadOnly = readOnly;
            txtSociosApellidoPaterno.ReadOnly = readOnly;
            txtSociosBuscar.ReadOnly = readOnly;
            txtSociosEmail.ReadOnly = readOnly;
            
            txtSociosNombre.ReadOnly = readOnly;
            
            txtSociosTelefono.ReadOnly = readOnly;
            dtpSociosFechaNacimiento.Enabled=!readOnly;
            cmbSociosSexo.Enabled=!readOnly;
            btnSociosAgregar.Visible = !readOnly;
            btnSociosAnadirFotografia.Visible = !readOnly;
            
                
            if (habilitar)
            {
                txtSociosApellidoMaterno.Text=string.Empty;
                txtSociosApellidoPaterno.Text = string.Empty;
                txtSociosClave.Text = string.Empty;
                txtSociosEmail.Text = string.Empty;
                
                txtSociosNombre.Text = string.Empty;
                
                txtSociosTelefono.Text = string.Empty;
                dtpSociosFechaNacimiento.Value=dtpSociosFechaNacimiento.MaxDate;
                cmbSociosSexo.SelectedIndex=0;
                pctbSociosFoto.Image = Properties.Resources.usuario;
                dirfoto = string.Empty;

            }
        }

        private void btnSociosEliminar_Click(object sender, EventArgs e)
        {
            
            actualizarGridSocios();

        }

        private void BtnSociosBuscar_Click(object sender, EventArgs e)
        {
            
            actualizarGridSocios();
            btnSociosMostrarTodos.Visible = true;

        }
        


        private void DgvSocios_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            GimnasioPruebasDataSet.SociosRow socioSeleccionado;
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {


                //socioSeleccionado = (DataRowView)e.Row.DataBoundItem;
                //socioSeleccionado =  (DataRowView)e.Row.DataBoundItem;
                txtSociosClave.Text = e.Row.Cells["clave"].Value.ToString();
                pctbSociosFoto.Image = new Util.Imagen().toImage((byte[]) e.Row.Cells["foto"].Value);
                dtpSociosFechaNacimiento.Value = Convert.ToDateTime(e.Row.Cells["fechaDeNacimiento"].Value);
                txtSociosApellidoMaterno.Text = e.Row.Cells["apellidoMaterno"].Value.ToString();
                txtSociosApellidoPaterno.Text = e.Row.Cells["apellidoPaterno"].Value.ToString();
                txtSociosEmail.Text = e.Row.Cells["email"].Value.ToString(); ;

                txtSociosNombre.Text = e.Row.Cells["nombres"].Value.ToString(); 

                txtSociosTelefono.Text = e.Row.Cells["telefono"].Value.ToString();


                cmbSociosSexo.SelectedIndex = e.Row.Cells["sexo"].Value.ToString() == "Masculino" ? 0 : 1;

                if (socioNuevoActivado)
                {
                    habilitarDeshabilitarNuevoSocio(false);
                    
                }


            }
        }



        private void btnSociosPagarMembresia_Click(object sender, EventArgs e)
        {
            new FrmPagarMembresia().Show();
        }

        private void tstmControlAccesoAbrir_Click(object sender, EventArgs e)
        {
            new FrmControlDeAcceso().Show();
        }


        private void tstmEjerciciosAgregar_Click(object sender, EventArgs e)
        {
            new FrmAgregarEjercicio().Show();
        }

        

        private void btnSociosNuevo_Click(object sender, EventArgs e)
        {
           
            dgvSocios.ClearSelection();
            habilitarDeshabilitarNuevoSocio(true);
            
            

        }

        public void btnSociosAgregar_Click(object sender, EventArgs e)
        {
            bool novacios;
            novacios = txtSociosApellidoMaterno.Text != string.Empty && txtSociosApellidoPaterno.Text != string.Empty && txtSociosTelefono.Text != string.Empty
                     && txtSociosNombre.Text != string.Empty;

            if (novacios)
            {
                if (fotoNuevo != null)
                {
                    int resultado = adminSocios.alta(txtSociosNombre.Text, txtSociosApellidoPaterno.Text, txtSociosApellidoMaterno.Text, dtpSociosFechaNacimiento.Value, (string)cmbSociosSexo.SelectedItem, txtSociosTelefono.Text, txtSociosEmail.Text, (Bitmap)fotoNuevo);
                    Console.WriteLine("Hola esto me salio despues de agregar a tu socio {0}", resultado);
                    if (resultado != 0)
                        MessageBox.Show("El socio " + txtSociosNombre.Text + " fue agregado correctamente");
                    else
                        MessageBox.Show("Hubo un error, inténtalo más tarde");
                }
                else
                    MessageBox.Show("Agregar la foto del socio");

            }
            else
                MessageBox.Show("Hay campos vacios");


        }


    

        private void btnSociosAnadirFotografia_Click(object sender, EventArgs e)
        {
            FrmTomaFoto frmCaptura= new FrmTomaFoto();
            frmCaptura.ShowDialog();
            fotoNuevo = frmCaptura.getFoto;
            if(fotoNuevo!=null)
                pctbSociosFoto.Image = fotoNuevo;
            
        }

        


        public void actualizarGridSocios()
        {
            adminSocios.rellena(this.gimnasioPruebasDataSet.Socios);

        }

        private void btnSociosMostrarTodos_Click(object sender, EventArgs e)
        {
            sociosValorBusqueda = string.Empty;
            actualizarGridSocios();
            btnSociosMostrarTodos.Visible = false;

        }

        private void dgvSocios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           FrmEditarSocio frmEditarSocio = new FrmEditarSocio(dgvSocios.Rows[e.RowIndex],this);
           frmEditarSocio.ShowDialog();
           
            

        }

        private void tsmAgregarSocio_Click(object sender, EventArgs e)
        {
            new FrmEditarSocio(this).Show();
        }
        #endregion

        #region membresias
        private void agregarTipoDeMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAgregarTipoMembresia().ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMembresiaBuscarSocio_Click(object sender, EventArgs e)
        {
            

        }

        private void btnMembresiaBuscarTipoMembresia_Click(object sender, EventArgs e)
        {
            


            
        }

        private void dtpMembresiaFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMembresiaDescuento_TextChanged(object sender, EventArgs e)
        {
            
             
        }

        private void btnRenovarMembresiaMembresia_Click(object sender, EventArgs e)
        {
           
        }

        private void DgvMembresias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TimeSpan diasDiferencia =
                ((DateTime)dgvMembresias.Rows[e.RowIndex].Cells["fechafin"].Value) - DateTime.Now;


                if (diasDiferencia.Days < 0)
                    dgvMembresias.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(200, 75, 75);
                else
                    if (diasDiferencia.Days > 30)
                    dgvMembresias.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                else
                    dgvMembresias.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(150, 150, 50);

            }
        }

        private void btnMembresiasEliminar_Click(object sender, EventArgs e)
        {
          
        }
        #endregion

        #region rutinas
        private void btnRutinasBuscarEjercicio_Click(object sender, EventArgs e)
        {
           
        }
        private void btnRutinasAgregarARutina_Click(object sender, EventArgs e)
        {


        }

        private void tstmControlAccesoConsultar_Click(object sender, EventArgs e)
        {

        }

        private void txtRutinasBuscarEjercicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRutinasGurdarRutina_Click(object sender, EventArgs e)
        {
           
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void btnRutinasBuscarSocio_Click(object sender, EventArgs e)
        {
            
        }

        private void rutinasAsignadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRutinas().ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void tbpSocios_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void dgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pagarMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPagarMembresia().ShowDialog();
        }

       
    }
}
