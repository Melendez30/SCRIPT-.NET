using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DEstatusAlumno
    {
        Alumno alumno1 = new Alumno();
        Estado estados = new Estado();
        EstatusAlumno estatus = new EstatusAlumno();

        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<EstatusAlumno> _listEstatusAlumno = new List<EstatusAlumno>();
        string query;
        SqlCommand comando;
        //PEOCEDIMIENTO PARA CONSULTAR ALUMNOS
        public List<EstatusAlumno> Consultar()
        {
            query = $"consultarEstatusAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEstatus", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    _listEstatusAlumno.Add(
                       new EstatusAlumno()
                       {
                           id = Convert.ToInt32(reader["id"].ToString()),
                           Clave = reader["Clave"].ToString(),
                           Nombre = reader["Nombre"].ToString()
                       }
                       );
                }
                con.Close();
            }
            return _listEstatusAlumno;
        }
        //PEOCEDIMIENTO PARA CONSULTAR ALUMNOS POR FILTRADO
        public Alumno Consultar(int Id)
        {
            Alumno estatusPorUno = new Alumno();
            query = $"consultarEstatusAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEstatus", Id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    _listEstatusAlumno.Add(
                       new EstatusAlumno()
                       {
                           id = Convert.ToInt32(reader["id"].ToString()),
                           Clave = reader["Clave"].ToString(),
                           Nombre = reader["Nombre"].ToString()
                       }
                       );
                }
                con.Close();
            }
            return estatusPorUno;
        }
    }
}
