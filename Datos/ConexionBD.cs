using System;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionBD
    {
        protected SqlConnection conexion;
        protected string cadenaConexion;

        public ConexionBD()
        {
            this.cadenaConexion = "Data Source=LAPTOP-IB1AKTDE\\SQLEXPRESS;Initial Catalog=rentCar;Integrated Security=True";
            this.conexion = new SqlConnection(this.cadenaConexion);
        }

        public string AbrirConnexion()
        {
            try
            {
                this.conexion.Open();
                return "Conexión abierta";
            }
            catch (Exception ex)
            {
                return "Error al abrir la conexión: " + ex.Message;
            }
        }

        public void CerrarConnexion()
        {
            if (this.conexion.State == System.Data.ConnectionState.Open)
            {
                this.conexion.Close();
            }
        }
    }
}
