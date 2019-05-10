using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }

        static Venta()
        {
            porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
            
        }

        private void Vender(int cantidad)
        {
            producto.Stock = producto.Stock - cantidad;
            fecha = DateTime.Today;
            precioFinal = Venta.CalcularPrecioFinal(producto.Precio,cantidad);

        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double total;
            double ivaCalculado;
            total = precioUnidad * cantidad;
            ivaCalculado = total * (porcentajeIva / 100);
            total = total + ivaCalculado;

            return total;
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("Fecha: {0} - Descripcion: {1} - Precio Final {2}\n", Fecha,producto.Descripcion, precioFinal);

            return mostrar.ToString();
        }

    }
}
