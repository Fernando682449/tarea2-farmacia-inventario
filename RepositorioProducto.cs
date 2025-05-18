using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace FarmaciaInventario
{
    public class RepositorioProducto
    {
        public static List<Producto> ObtenerTodos()
        {
            List<Producto> lista = new List<Producto>();
            using (var cn = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Producto
                    {
                        Id = (int)dr["Id"],
                        Nombre = dr["Nombre"].ToString(),
                        FechaCaducidad = (DateTime)dr["FechaCaducidad"],
                        Stock = (int)dr["Stock"]
                    });
                }
            }
            return lista;
        }

        public static void Agregar(Producto p)
        {
            using (var cn = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Producto (Nombre, FechaCaducidad, Stock) VALUES (@n, @f, @s)", cn);
                cmd.Parameters.AddWithValue("@n", p.Nombre);
                cmd.Parameters.AddWithValue("@f", p.FechaCaducidad);
                cmd.Parameters.AddWithValue("@s", p.Stock);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Producto> ObtenerCriticos(int umbral = 10)
        {
            List<Producto> lista = new List<Producto>();
            using (var cn = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Producto WHERE Stock <= @umbral", cn);
                cmd.Parameters.AddWithValue("@umbral", umbral);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Producto
                    {
                        Id = (int)dr["Id"],
                        Nombre = dr["Nombre"].ToString(),
                        FechaCaducidad = (DateTime)dr["FechaCaducidad"],
                        Stock = (int)dr["Stock"]
                    });
                }
            }
            return lista;
        }
    }
}
