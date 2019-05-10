using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        public enum TipoComic
        {
            Occidental,
            Oriental
        }
        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion,int stock,double precio,string autor,TipoComic tipoComic) : base(descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public override string ToString()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(base.ToString());
            mostrar.AppendFormat("Autor: {0}\n", autor);
            mostrar.AppendFormat("Tipo de Comic: {0}\n", tipoComic);

            return mostrar.ToString();
        }
    }
}
