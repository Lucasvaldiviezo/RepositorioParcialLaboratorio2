using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
        }
        public double Precio
        {
            get
            {
                return precio;
            }
        }
        public int Stock
        {
            set
            {
                if(value > 0)
                {
                    stock = value;
                }
                
            }
            get
            {
                 return stock;   
            }
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.precio = precio;
            Stock = stock;
            codigo = Guid.NewGuid();
        }

        public override string ToString()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("Descripción: {0}\n", Descripcion);
            mostrar.AppendFormat("Código: {0}\n", codigo);
            mostrar.AppendFormat("Precio: ${0}\n", Precio);
            mostrar.AppendFormat("Stock: {0} unidades\n", Precio);


            return mostrar.ToString();
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
    }
}
