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
    public partial class FrmEditarSocio : Form
    {
        Image foto;
        View_Model.SocioViewModel adminSocios;
        DataGridViewRow socio;
        FrmAdministracionGimnasio padre;
        


        public FrmEditarSocio(DataGridViewRow socio, FrmAdministracionGimnasio padre) : this(padre)
        {
            this.socio = socio;
        }

        public FrmEditarSocio(FrmAdministracionGimnasio padre)
        {

            InitializeComponent();
            //validaciones
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
            this.CancelButton = btnCancelar;
            this.AcceptButton = btnAceptar;

            foto = null;
            cmbSociosSexo.SelectedIndex = 0;

            this.padre = padre;
            adminSocios = new View_Model.SocioViewModel();


        }





        private void btnCambiarFotografia_Click(object sender, EventArgs e)
        {
            FrmTomaFoto frmCaptura = new FrmTomaFoto();

            frmCaptura.ShowDialog();
            foto = frmCaptura.getFoto;
            pctbSociosFoto.Image = foto;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool novacios;
            novacios = txtSociosApellidoMaterno.Text != string.Empty && txtSociosApellidoPaterno.Text != string.Empty && txtSociosTelefono.Text != string.Empty
                     && txtSociosNombre.Text != string.Empty;

            if (novacios)
            {
                if (foto != null)
                {
                    btnAceptar.Enabled = false;
                    int resultado=adminSocios.alta(txtSociosNombre.Text, txtSociosApellidoPaterno.Text, txtSociosApellidoMaterno.Text, dtpSociosFechaNacimiento.Value, (string)cmbSociosSexo.SelectedItem, txtSociosTelefono.Text, txtSociosEmail.Text, (Bitmap)foto);
                    Console.WriteLine("Hola esto me salio despues de agregar a tu socio {0}", resultado);
                    if (resultado != 0) {
                        MessageBox.Show("El socio " + txtSociosNombre.Text + " fue agregado correctamente");
                        padre.actualizarGridSocios();
                    }
                       
                    else
                        MessageBox.Show("Hubo un error, inténtalo más tarde");
                }
                else
                    MessageBox.Show("Agregar la foto del socio");

            }
            else
                MessageBox.Show("Hay campos vacios");


        }
    


        private void FrmEditarSocio_Load(object sender, EventArgs e)
        {
            dtpSociosFechaNacimiento.MaxDate = DateTime.Now.Date.AddYears(-12);
            
            pctbSociosFoto.Image = Properties.Resources.usuario;

            if (socio != null) {
                txtSociosClave.Text = socio.Cells["clave"].Value.ToString();
                pctbSociosFoto.Image = new Util.Imagen().toImage((byte[])socio.Cells["foto"].Value);
                dtpSociosFechaNacimiento.Value = Convert.ToDateTime(socio.Cells["fechaDeNacimiento"].Value);
                txtSociosApellidoMaterno.Text = socio.Cells["apellidoMaterno"].Value.ToString();
                txtSociosApellidoPaterno.Text = socio.Cells["apellidoPaterno"].Value.ToString();
                txtSociosEmail.Text = socio.Cells["email"].Value.ToString(); ;

                txtSociosNombre.Text = socio.Cells["nombres"].Value.ToString();

                txtSociosTelefono.Text = socio.Cells["telefono"].Value.ToString();

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
