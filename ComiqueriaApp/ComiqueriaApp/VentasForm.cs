using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        public VentasForm()
        {
            InitializeComponent();
        }


        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            
            lblNumeroPrecio.Text = numericUpDownCantidad.Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {
            
        }
    }
}
