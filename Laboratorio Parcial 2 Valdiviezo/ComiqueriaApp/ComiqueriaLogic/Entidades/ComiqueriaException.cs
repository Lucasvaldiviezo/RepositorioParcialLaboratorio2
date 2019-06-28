using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComiqueriaLogic
{
    public class ComiqueriaException : Exception, IArchivoTexto
    {
        private DateTime momentoError;

        public ComiqueriaException(string mensaje, Exception innerException, DateTime momentoError) : base(mensaje,innerException)
        {
            this.momentoError = momentoError;
            ArchivoTexto.Escribir(this, true);
        }

        public string Ruta
        {
            get { return  ObtenerRuta(); }
        }
        public string Texto
        {
            get { return ObtenerTexto(); }
        }

        public string ObtenerTexto()
        {
           StringBuilder mostrar = new StringBuilder();
           mostrar.AppendFormat("Mensaje Actual: {0}, Mensaje de Excepciones: {1},",this.Message,this.InnerException.Message);
           mostrar.AppendFormat(" Fecha y Hora del error: {0}",momentoError);
           return mostrar.ToString();
        }

        public string ObtenerRuta()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.Append(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"log.txt")));
            return mostrar.ToString();
        }
    }
}
