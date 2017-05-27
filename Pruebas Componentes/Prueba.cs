using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_1_1_pruebas
{
    public partial class Prueba : Component
    {

        private Color colFColor;
        private Color colBColor;

        public Prueba()
        {
            InitializeComponent();
        }

        public Prueba(IContainer container)
        {

            
            container.Add(this);
            InitializeComponent();
         

        }

        private void comboBoxPrueba_RegionChanged(object sender, EventArgs e)
        {

        }

        protected virtual void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplay.Text = DateTime.Now.ToLongTimeString();
        }

        public Color ClockBackColor
        // Retrieves the value of the private variable colBColor.
        {
            get
            {
                return colBColor;
            }
            // Stores the selected value in the private variable colBColor, and 
            // updates the backcolor of the label control lblDisplay.
            set
            {
                colBColor = value;
                lblDisplay.BackColor = colBColor;
            }
        }
        // Provides a similar set of instructions for the forecolor.
        public Color ClockForeColor
        {
            get
            {
                return colFColor;
            }
            set
            {
                colFColor = value;
                lblDisplay.ForeColor = colFColor;
            }
        }

    }
}
