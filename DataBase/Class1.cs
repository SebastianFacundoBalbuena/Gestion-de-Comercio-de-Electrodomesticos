using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace DataBase
{
    public class Data
    {
        // atributos

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;


        // conexion automatica

        public Data()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database= CATALOGO_DB; integrated security = true; ");
            
        }

        //Metodos

        // consultar
        public void setearConsulta(string consulta)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
            comando.Connection = conexion;
        }


        // ejecuta la consulta
        public void ejecutarConsulta()
        {

            try
            {
                conexion.Open();
                
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            

        }


        // ejecuta la accion
        public void EjecutarAccion()
        {
            
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        // cierra conexiones
        public void cerrarConexion()
        {
            if(lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }


        //Lee los datos traidos
        public SqlDataReader LectorReader
        {
            get { return lector; }
        }
    }
}
