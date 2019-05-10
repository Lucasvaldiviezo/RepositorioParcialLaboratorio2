using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();
        }

        public Producto this[Guid codigo]
        {
            get
            {
                Producto retorno = null;
                foreach (Producto producto in productos)
                {
                    if((Guid)producto == codigo)
                    {
                        retorno = producto;
                    }
                }
                return retorno;
            }
        }

        public static bool operator ==(Comiqueria comiqueria,Producto producto)
        {
            bool retorno = false;
            foreach(Producto p in comiqueria.productos)
            {
                if(p.Descripcion == producto.Descripcion)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }

            return comiqueria;
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta nuevaVenta = new Venta(producto, cantidad);
        }
        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public string ListarVentas()
        {
            StringBuilder mostrar = new StringBuilder();

            ventas = ventas.OrderBy(v => v.Fecha).ToList();
            foreach(Venta venta in ventas)
            {
                mostrar.AppendLine(venta.ObtenerDescripcionBreve());
            }


            return mostrar.ToString();
        }

        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> dProductos = new Dictionary<Guid, string>();
            foreach (Producto producto in productos)
            {
                dProductos.Add((Guid)producto, producto.Descripcion);
            }

            return dProductos;
        }

    }

    
}
