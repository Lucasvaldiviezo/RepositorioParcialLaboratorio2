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
        private Producto productoActual;
        private Comiqueria comiqueriaActual;
        public VentasForm()
        {
            InitializeComponent();
        }

        public VentasForm(Producto productoActual, Comiqueria comiqueriaActual) : this()
        {
            this.productoActual = productoActual;
            this.comiqueriaActual = comiqueriaActual;
            lblDescripcion.Text = productoActual.Descripcion;
            lblNumeroPrecio.Text = productoActual.Precio.ToString();
        }


        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            double total = (double)numericUpDownCantidad.Value * productoActual.Precio;
            lblNumeroPrecio.Text = total.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(numericUpDownCantidad.Value);
            double stock = productoActual.Stock; 
            if (cantidad <= stock)
            {

            }else
            {
                MessageBox.Show("La cantidad que desea comprar supera al stock disponible", "Error de Stock", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
