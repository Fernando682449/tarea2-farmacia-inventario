using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FarmaciaInventario
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            string cadena = @"Data Source=DESKTOP-EUC093K\SQLEXPRESS;Initial Catalog=FarmaciaDB;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            try
            {
                cn.Open();
                return cn;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
