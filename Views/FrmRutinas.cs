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
    public partial class FrmRutinas : Form
    {
        DataTable dttbrutinas;
        public FrmRutinas()
        {
            InitializeComponent();
        }

        private void btnRutinasAgregarARutina_Click(object sender, EventArgs e)
        {

        }

        private void FrmRutinas_Load(object sender, EventArgs e)
        {
            

            dgvRutinas.Columns["foto"].Visible = false;
            dgvRutinas.Columns["id"].Visible = false;
            dgvRutinas.Columns["notas"].Visible = false;
            dtpRutinasInicio.Enabled=false;

            dtpRutinasFin.Enabled=false;


        }

        private void dgvRutinas_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dgvRutinasDias_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }
    }
}
