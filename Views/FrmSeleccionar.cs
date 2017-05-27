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
    public partial class FrmSeleccionar : Form
    {

        private DataGridViewRow rowseleccionada;
        DataTable valores;
        GimnasioPruebasDataSet.SociosDataTable socios;
        GimnasioPruebasDataSet.MembresiasDataTable membresias;

        public FrmSeleccionar(GimnasioPruebasDataSet.SociosDataTable socios)
        {
            this.socios = socios;
            InitializeComponent();
            dgvSelecciona.DataSource = socios;
            
            dgvSelecciona.Columns["Foto"].Visible = false;
            dgvSelecciona.Columns["Sexo"].Visible = false;
            dgvSelecciona.Columns["Email"].Visible = false;
            dgvSelecciona.Columns["Telefono"].Visible = false;
            dgvSelecciona.Columns["Fecha de Nacimiento"].Visible = false;
            dgvSelecciona.ShowRowErrors = false;
        }

        public FrmSeleccionar(GimnasioPruebasDataSet.MembresiasDataTable membresias)
        {
            this.membresias = membresias;
            InitializeComponent();

            dgvSelecciona.DataSource = membresias;

            dgvSelecciona.Columns["ID"].Visible = false;
            
            dgvSelecciona.ShowRowErrors = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSeleccionar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gimnasioPruebasDataSet.Socios' Puede moverla o quitarla según sea necesario.
            
            
        }

        private void dgvSelecciona_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            rowseleccionada = dgvSelecciona.Rows[e.RowIndex];
            Close();
        }

        public DataGridViewRow seleccionado
        {
            get { return rowseleccionada; }
        }

        public int seleccionadoId
        {
            get {
                if (rowseleccionada !=null) {
                    if (socios != null)
                        return (int)rowseleccionada.Cells["Clave"].Value;
                    else if (membresias != null)
                        return (int)rowseleccionada.Cells["Id"].Value;
                    else
                        return -1;

                } else
                    return -1;

               
            }
        }
    }
}
