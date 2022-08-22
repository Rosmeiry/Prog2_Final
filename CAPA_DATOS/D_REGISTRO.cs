using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CAPA_ENTIDAD;

namespace CAPA_DATOS
{
    public class D_REGISTRO
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_REGISTRO> ListarRegistro(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand CMD = new SqlCommand("SP_BUSCARVISITAS", conexion);
            CMD.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            CMD.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = CMD.ExecuteReader();

            List<E_REGISTRO> Listar = new List<E_REGISTRO>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_REGISTRO
                    {
                        Id_Visita = LeerFilas.GetInt32(0),
                        Nombre = LeerFilas.GetString(1),
                        Apellido = LeerFilas.GetString(2),
                        Carrera = LeerFilas.GetString(3),
                        CorreoElectronico = LeerFilas.GetString(4),
                        Edificio = LeerFilas.GetString(5),
                        HoraEntrada = LeerFilas.GetString(6),
                        HoraSalida = LeerFilas.GetString(7),
                        MotivoVisita = LeerFilas.GetString(8),
                        AulaLugar = LeerFilas.GetString(9)
                });
                
            }

            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void AgregarVisitas(E_REGISTRO REGISTRO_VISITAS)
        {
            SqlCommand CMD = new SqlCommand("SP_AGREGARVISITAS", conexion);
            CMD.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            CMD.Parameters.AddWithValue("@NOMBRE", REGISTRO_VISITAS.Nombre);
            CMD.Parameters.AddWithValue("@APELLIDO", REGISTRO_VISITAS.Apellido);
            CMD.Parameters.AddWithValue("@CARRERA", REGISTRO_VISITAS.Carrera);
            CMD.Parameters.AddWithValue("@CORREO_ELECTRONICO", REGISTRO_VISITAS.CorreoElectronico);
            CMD.Parameters.AddWithValue("@EDIFICIO", REGISTRO_VISITAS.Edificio);
            CMD.Parameters.AddWithValue("@HORA_ENTRADA", REGISTRO_VISITAS.HoraEntrada);
            CMD.Parameters.AddWithValue("@HORA_SALIDA", REGISTRO_VISITAS.HoraSalida);
            CMD.Parameters.AddWithValue("@MOTIVO_VISITA", REGISTRO_VISITAS.MotivoVisita);
            CMD.Parameters.AddWithValue("@AULA_LUGAR", REGISTRO_VISITAS.AulaLugar);

            CMD.ExecuteNonQuery();
            conexion.Close();
        }

        public void AgregarUsuarios(E_REGISTRO REGISTRO_USUARIO)
        {
            SqlCommand CMD = new SqlCommand("SP_AGREGARUSUARIOS", conexion);
            CMD.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            CMD.Parameters.AddWithValue("@NOMBRE_US", REGISTRO_USUARIO.NombreUS);
            CMD.Parameters.AddWithValue("@APELLIDO_US", REGISTRO_USUARIO.ApellidoUS);
            CMD.Parameters.AddWithValue("@FECHA_NACIMIENTO", REGISTRO_USUARIO.FechaNacimiento);
            CMD.Parameters.AddWithValue("@TIPO_USUARIO", REGISTRO_USUARIO.TipoUsuario);

            CMD.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarVisitas(E_REGISTRO REGISTRO_VISITAS, int ID)
        {
            try
            {
                SqlCommand CMD = new SqlCommand("SP_MODIFICARVISITAS", conexion);
                CMD.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                CMD.Parameters.AddWithValue("@ID_VISITA", ID);
                CMD.Parameters.AddWithValue("@NOMBRE", REGISTRO_VISITAS.Nombre);
                CMD.Parameters.AddWithValue("@APELLIDO", REGISTRO_VISITAS.Apellido);
                CMD.Parameters.AddWithValue("@CARRERA", REGISTRO_VISITAS.Carrera);
                CMD.Parameters.AddWithValue("@CORREO_ELECTRONICO", REGISTRO_VISITAS.CorreoElectronico);
                CMD.Parameters.AddWithValue("@EDIFICIO", REGISTRO_VISITAS.Edificio);
                CMD.Parameters.AddWithValue("@HORA_ENTRADA", REGISTRO_VISITAS.HoraEntrada);
                CMD.Parameters.AddWithValue("@HORA_SALIDA", REGISTRO_VISITAS.HoraSalida);
                CMD.Parameters.AddWithValue("@MOTIVO_VISITA", REGISTRO_VISITAS.MotivoVisita);
                CMD.Parameters.AddWithValue("@AULA_LUGAR", REGISTRO_VISITAS.AulaLugar);

                CMD.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
