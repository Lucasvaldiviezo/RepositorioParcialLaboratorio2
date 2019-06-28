using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ComiqueriaLogic
{
    public class SQLdb
    {
        public delegate void ModificacionDB(AccionesDB db);
        public static String connectionStr = "Data Source=LAB3PC19\\SQLEXPRESS; Initial Catalog = Comiqueria; Integrated Security = True";
        public static SqlConnection conexion;
        public static SqlCommand comando;
        public static event ModificacionDB modificacion;

        public SQLdb()
        {
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static void Guardar(string descripcion, double precio, int stock)
        {
            String consulta;
            try
            {
                consulta = String.Format("INSERT INTO dbo.Productos (Descripcion,Precio,Stock)  VALUES({0},{1},{2})", descripcion, precio, stock);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                modificacion.Invoke(AccionesDB.Insert);
            }catch(Exception)
            {
                
            }finally
            {
                conexion.Close();
            } 
        }

        public static void Eliminar(Producto producto)
        {
            String consulta;
            try
            {
                consulta = String.Format("DELETE FROM dbo.Productos WHERE ID = {0}", producto.Codigo);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                modificacion.Invoke(AccionesDB.Delete);
            }
            catch(Exception)
            {

            }finally
            {
                conexion.Close();
            }
            
            
        }

        public static List<Producto> Leer()
        {
            SqlDataReader dataReader = comando.ExecuteReader();
            List<Producto> productos = new List<Producto>();
            string auxDescripcion;
            double auxPrecio;
            int auxCodigo;
            int auxStock;
            try
            {
                comando.CommandText = "SELECT Codigo,Descripcion,Precio,Stock FROM dbo.Productos";
                conexion.Open();
                while (dataReader.Read())
                {
                    int.TryParse(dataReader["Codigo"].ToString(), out auxCodigo);
                    auxDescripcion = dataReader["Descripcion"].ToString();
                    double.TryParse(dataReader["Precio"].ToString(), out auxPrecio);
                    int.TryParse(dataReader["Stock"].ToString(), out auxStock);
                    Producto p = new Producto(auxCodigo, auxDescripcion, auxStock, auxPrecio);
                    productos.Add(p);
                }
            }catch(Exception)
            {

            }finally
            {
                conexion.Close();
            }

            return productos;
        }
    }
}
