using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUDEstatusWeb
{
    public class ADOEstatus
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Estatus> listEstatus = new List<Estatus>();
        string query;
        SqlCommand comando;
        public List<Estatus> Consultar()
        {
            query = "select * from EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listEstatus.Add(
                       new Estatus()
                       {
                           id = Convert.ToInt32(reader["id"]),
                           Clave = reader["Clave"].ToString(),
                           Nombre = reader["Nombre"].ToString()
                       }
                       );
                }
                con.Close();
            }
            return listEstatus;
        }
        public Estatus Consultar(int Id)
        {
            Estatus estatusPorUno = new Estatus();
            query = $"select * from EstatusAlumnos where id ={Id}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    estatusPorUno = new Estatus { id = Convert.ToInt32(reader["id"]), Clave = reader["Clave"].ToString(), Nombre = reader["Nombre"].ToString() };
                }
                con.Close();
            }
            return estatusPorUno;
        }
        public int Agregar(Estatus estatu)
        {
            int Estadoss;
            query = $"insert into EstatusAlumnos(id,Clave,Nombre) values(@id,@Clave, @Nombre)";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Clave", estatu.Clave);
                comando.Parameters.AddWithValue("@Nombre", estatu.Nombre);
                con.Open();
                var idEstado = comando.ExecuteScalar();
                Estadoss = Convert.ToInt32(idEstado);
                con.Close();

            }
            return Estadoss;
        }
        public void Actualizacion(Estatus estatu)
        {
            string query = $"update EstatusAlumnos set Nombre ='{estatu.id}','{estatu.Nombre}', Clave= '{estatu.Clave}' where id={estatu.id}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }

        }

        public void Eliminar(int id)
        {
            query = $"delete EstatusAlumnos where id={id}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }







    }
}
