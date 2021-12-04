using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ReconocimientoFacial
{
    public class ConexionSQL
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection("Server = BFLORENTINO\\SQLBRYAN; Database=BaseCriminales; Integrated security=true");
            conexion.Open();
            return conexion;
        }

        public static void InsertarUsuario(string nombre, string correo, string telefono, string detalles)
        {
            string query = "Insert into Personas (Nombre, Correo, Telefono, Detalles) values (@nombre, @correo, @telefono, @detalles)";
            SqlCommand comando = new SqlCommand(query, Conectar());
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@detalles", detalles);
            comando.ExecuteNonQuery(); 
        }

        public static SqlDataReader BuscarUsuario(string nombre)
        {
            string query = $"select * from personas where nombre = '{nombre}'";
            SqlCommand comando = new SqlCommand(query, Conectar());
            SqlDataReader lector = comando.ExecuteReader();
            return lector;
        }
    };
}
