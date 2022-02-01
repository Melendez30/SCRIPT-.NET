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
    public class DAlumno
    {
        Alumno alumno1 = new Alumno();
        Estado estados = new Estado();
        EstatusAlumno estatus = new EstatusAlumno();

        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Alumno> _listAlumnos = new List<Alumno>();
        string query;
        SqlCommand comando;
//PEOCEDIMIENTO PARA CONSULTAR ALUMNOS
        public List<Alumno> Consultar()
        {
            List<Alumno> listas = new List<Alumno>();
            query = $"consultarEAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", -1);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listas.Add(
                       new Alumno()
                       {
                           id = Convert.ToInt32(reader["id"].ToString()),
                           nombre = reader["Nombre"].ToString(),
                           primerApellido = reader["primerApellido"].ToString(),
                           segundoApellido = reader["segundoApelllido"].ToString(),
                           fechaNacimiento = Convert.ToDateTime(reader["fechaNaci"].ToString()),
                           curp =  reader["curp"].ToString(),
                           correo = reader["correo"].ToString(),
                           telefono = reader["telefono"].ToString(),
                           idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"].ToString()),
                           idEstatus = Convert.ToInt32(reader["idEstatus"].ToString())
                       }
                       );
                }
                con.Close();
            }
            return listas;
        }
//PEOCEDIMIENTO PARA CONSULTAR ALUMNOS POR FILTRADO
        public Alumno Consultar(int Id)
        {
            Alumno AlumnoPorUno = new Alumno();
            query = $"consultarEAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", Id);
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    AlumnoPorUno = 
                       new Alumno
                       {
                           id = Convert.ToInt32(reader["id"].ToString()),
                           nombre = reader["Nombre"].ToString(),
                           primerApellido = reader["primerApellido"].ToString(),
                           segundoApellido = reader["segundoApelllido"].ToString(),
                           fechaNacimiento = Convert.ToDateTime(reader["fechaNaci"].ToString()),
                           curp = reader["curp"].ToString(),
                           correo = reader["correo"].ToString(),
                           telefono = reader["telefono"].ToString(),
                           idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"].ToString()),
                           idEstatus = Convert.ToInt32(reader["idEstatus"].ToString())
                       
                       }
                       ;
                }
                con.Close();
            }
            return AlumnoPorUno;
        }
////PEOCEDIMIENTO PARA AGREGAR ALUMNOS
        public int Agregar(Alumno estatu)
        {
            int agregando;
            query = $"agregarAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NOMBRE", estatu.nombre);
                comando.Parameters.AddWithValue("@primerApellido", estatu.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", estatu.segundoApellido);
                comando.Parameters.AddWithValue("@fechaNacimiento", estatu.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", estatu.curp);
                comando.Parameters.AddWithValue("@sueldo", estatu.sueldoMensual);
                comando.Parameters.AddWithValue("@correo", estatu.correo);
                comando.Parameters.AddWithValue("@telefono", estatu.telefono);
                comando.Parameters.AddWithValue("@id_estado", estatu.idEstadoOrigen);
                comando.Parameters.AddWithValue("@id_estatus", estatu.idEstatus);
                con.Open();
                var idAgreg = comando.ExecuteScalar();
                agregando = Convert.ToInt32(idAgreg);
                con.Close();    
            }
            return agregando;
        }
//PEOCEDIMIENTO PARA ACTUALIZAR ALUMNOS
        public void Actualizacion(Alumno estatu)
        {
            string query = $"actualizarAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", estatu.id);
                comando.Parameters.AddWithValue("@NOMBRE", estatu.nombre);
                comando.Parameters.AddWithValue("@primerApellido", estatu.primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", estatu.segundoApellido);
                comando.Parameters.AddWithValue("@fechaNacimiento", estatu.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", estatu.curp);
                comando.Parameters.AddWithValue("@sueldo", estatu.sueldoMensual);
                comando.Parameters.AddWithValue("@correo", estatu.correo);
                comando.Parameters.AddWithValue("@telefono", estatu.telefono);
                comando.Parameters.AddWithValue("@id_estado", estatu.idEstadoOrigen);
                comando.Parameters.AddWithValue("@id_estatus", estatu.idEstatus);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }

        }
//PEOCEDIMIENTO PARA ELIMINAR ALUMNOS
        public void Eliminar(int id)
        {
            query = $"eliminarAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idAlumno", id);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }

        }
    }
}


