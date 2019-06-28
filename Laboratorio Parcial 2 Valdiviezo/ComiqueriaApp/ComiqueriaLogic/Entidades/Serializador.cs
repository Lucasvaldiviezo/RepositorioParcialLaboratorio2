using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ComiqueriaLogic
{
    [Serializable]
    public static class Serializador<T> where T : class, new()
    {
        public static void GuardarBinary(string archivo, T datos)
        {
            FileStream filestream = null;         
            BinaryFormatter serializer;
            try
            {
                filestream = new FileStream(archivo, FileMode.Create);
                serializer = new BinaryFormatter();
                serializer.Serialize(filestream, datos);
                

            }catch(ArgumentException e)
            {
                throw new ArgumentException("Error con el argumento",e);

            }catch(DirectoryNotFoundException e)
            {
               throw new ComiqueriaException("Error: Directorio no encontrado", e, DateTime.Now);
            }catch(Exception)
            {
                throw new Exception("Ocurrio un error, contacte al administrador");
            }
            finally
            {
                filestream.Close();
            }
        }

        public static void LeerBinary(string archivo, out T datos)
        {

            FileStream filestream = null;
            BinaryFormatter serializer;
            try
            {
                filestream = new FileStream(archivo, FileMode.Open);
                serializer = new BinaryFormatter();
                datos = (T)serializer.Deserialize(filestream);
            }
            catch (Exception)
            {
                datos = default(T);
            }
            finally
            {
                filestream.Close();
            }
        }

        public static void GuardarXml(string archivo, T datos)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            XmlTextWriter escritor = null;
            try
            {
                escritor = new XmlTextWriter(archivo, null);
                serializador.Serialize(escritor, datos);
            }
            catch (Exception)
            {
                
            }
            finally
            {
                escritor.Close();
            }
        }

        public static void LeerXml(string archivo, out T datos)
        {

            XmlSerializer serializador = new XmlSerializer(typeof(T));
            XmlTextReader lector = null;
            try
            {
                lector = new XmlTextReader(archivo);
                datos = (T)serializador.Deserialize(lector);
            }
            catch (Exception)
            {
                datos = default(T);
            }
            finally
            {
                lector.Close();
            }
        }
    }
    
}
