using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComiqueriaLogic
{
    public static class ArchivoTexto
    {
        public static void Escribir(ComiqueriaException exception, bool append)
        {
            StreamWriter archivotxt;
            archivotxt = new StreamWriter(exception.Ruta, append);
            try
            {
                    archivotxt.Write(exception.Texto);
            }
            catch (Exception)
            {

            }
            finally
            {
                archivotxt.Close();
            }
        }

        public static void Leer(string ruta, out string datos)
        {
            StreamReader archivotxt;
            archivotxt = new StreamReader(ruta);
            try
            {
                datos = archivotxt.ReadToEnd();
            }
            catch (Exception)
            {
                datos = "";
            }
            finally
            {
                archivotxt.Close();
            }
        }
    }
}
