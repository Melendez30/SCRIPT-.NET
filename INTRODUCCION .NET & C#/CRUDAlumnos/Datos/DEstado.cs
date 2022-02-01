using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DEstado
    {
        Alumno alumno1 = new Alumno();
        Estado estados = new Estado();
        EstatusAlumno estatus = new EstatusAlumno();

        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Estado> _listEstados = new List<Estado>();
        string query;
        SqlCommand comando;
        //PEOCEDIMIENTO PARA CONSULTAR ALUMNOS
        public List<Estado> Consultar()
        {
            query = $"consultarEstados";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEstado", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    _listEstados.Add(
                       new Estado()
                       {
                           id = Convert.ToInt32(reader["id"].ToString()),
                           nombre = reader["nombre"].ToString()
                       }
                       );
                }
                con.Close();
            }
            return _listEstados;
        }
        //PEOCEDIMIENTO PARA CONSULTAR ALUMNOS POR FILTRADO
        public Estado Consultar(int Id)
        {
            Estado estatusPorUno = new Estado();
            query = $"consultarEstados";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEstado", Id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    _listEstados.Add(
                       new Estado()
                       {
                           id = Convert.ToInt32(reader["id"].ToString()),
                           nombre = reader["nombre"].ToString()
                       }
                       );
                }
                con.Close();
            }
            return estatusPorUno;
        }
    }
}