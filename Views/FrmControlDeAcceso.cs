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
    public partial class FrmControlDeAcceso : Form
    {

        DataRow socio;
        Timer timlimpia;

        public FrmControlDeAcceso()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void FrmControlDeAcceso_Load(object sender, EventArgs e)
        {
            timlimpia = new Timer();
            timlimpia.Interval = 3000;
            
            timlimpia.Tick += Timlimpia_Tick;
            lblAcceso.Text = string.Empty;
            lblMensaje.Text = string.Empty;
            lblMembresia.Text = string.Empty;
            pctbFoto.Image = Properties.Resources.usuario;
        }

        private void Timlimpia_Tick(object sender, EventArgs e)
        {
           
            lblAcceso.Text = string.Empty;
            lblMensaje.Text = string.Empty;
            lblMembresia.Text = string.Empty;
            pctbEstado.Image = null;
            pctbFoto.Image = Properties.Resources.usuario;
            txtClave.Text = string.Empty;
            timlimpia.Stop();
        }
    }
}
