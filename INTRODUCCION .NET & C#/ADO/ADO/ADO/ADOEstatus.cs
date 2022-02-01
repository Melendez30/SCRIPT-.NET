using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    public class ADOEstatus 
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Estatus> listEstatus = new List<Estatus>();
        string query;
        SqlCommand comando;
        public List<Estatus> Consultar()
        {
            query = "select * from estatus_Alumno";
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
                           Id = Convert.ToInt32(reader["idEstatus"]),
                           Clave = reader["clave"].ToString(),
                           Nombre = reader["nombreEstatus"].ToString()
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
            query = $"select * from estatus_Alumno where idEstatus ={Id}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    //listEstatus.Add(
                    //   new Estatus()
                    //   {
                    //       Id = Convert.ToInt32(reader["idEstatus"]),
                    //       Clave = reader["clave"].ToString(),
                    //       Nombre = reader["nombreEstatus"].ToString()
                    //   }
                    //   );
                    estatusPorUno = new Estatus { Id = Convert.ToInt32(reader["idEstatus"]), Clave = reader["clave"].ToString(), Nombre = reader["nombreEstatus"].ToString() };
                }
                con.Close();
            }
            return estatusPorUno;
        }
        public int Agregar(Estatus estatu)
        {
            int idEstado;
            query = $"insert into estatus_Alumno(clave,nombreEstatus) values(@clave, @nombreEstatus)";
            using(SqlConnection con = new SqlConnection(conection))
            {
                comando=new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@clave", estatu.Clave);
                comando.Parameters.AddWithValue("@nombreEstatus", estatu.Nombre);
                con.Open();
                idEstado = (Int32)comando.ExecuteScalar();
                con.Close();

            }
            return idEstado;
        }

            //}
            //void Actulizar(Estatus Estatu)
            //{

            //}
            //void Eliminar(int Id)
            //{

            //}
        }
}
