using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FarmaciaLaNuevaEra.Data.Helper;

namespace FarmaciaLaNuevaEra.Data
{
    public class DUsuario
    {
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string NombrePerfil { get; set; }
        public string RolConexion { get; set; }
        public string Contraseña { get; set; }
        #region metodos
        public DataTable Validar_acceso(string usuario, string contraseña)
        {
            DataTable DtResultado = new DataTable("Inicio_Sesión");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Acceso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //   Cargando los parámetros del procedimiento almacenado
                SqlCmd.Parameters.Add(Parametros.parametro("@nombrePerfil", SqlDbType.VarChar, 60, usuario));
                SqlCmd.Parameters.Add(Parametros.parametro("@Contraseña", SqlDbType.VarChar, 100, contraseña));

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public string InsertarUsuario(DUsuario usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlCmd.Parameters.Add(Parametros.parametro("@idEmpleado", SqlDbType.Int, 0, usuario.IdEmpleado));
                SqlCmd.Parameters.Add(Parametros.parametro("@nombrePerfil", SqlDbType.VarChar, 50, usuario.NombrePerfil));
                SqlCmd.Parameters.Add(Parametros.parametro("@contraseña", SqlDbType.VarChar, 30, usuario.Contraseña));
                SqlCmd.Parameters.Add(Parametros.parametro("@rol", SqlDbType.VarChar, 30, usuario.RolConexion));

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        public string EditarUsuario(DUsuario usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ActualizarUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlCmd.Parameters.Add(Parametros.parametro("@idUsuario", SqlDbType.Int, 0, usuario.IdUsuario));
                SqlCmd.Parameters.Add(Parametros.parametro("@idEmpleado", SqlDbType.Int, 0, usuario.IdEmpleado));
                SqlCmd.Parameters.Add(Parametros.parametro("@nombre", SqlDbType.VarChar, 50, usuario.NombrePerfil));
                SqlCmd.Parameters.Add(Parametros.parametro("@contraseña", SqlDbType.VarChar, 30, usuario.Contraseña));
                SqlCmd.Parameters.Add(Parametros.parametro("@rolConexion", SqlDbType.VarChar, 30, usuario.RolConexion));

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se actualizó el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally

            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        public static DataTable MostrarUsuarios()
        {
            DataTable DtResultado = new DataTable("Usuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public static DataTable CambiarEstado(int idUsuario)
        {
            DataTable DtResultado = new DataTable("CambioEstado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando la conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;

                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CambiarEstado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //   Cargando el parámetro de Búsqueda
                SqlCmd.Parameters.Add(Parametros.parametro("@idUsuario", SqlDbType.Int, 0, idUsuario));

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public static DataTable Buscar(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarUsuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //   Cargando el parámetro de Búsqueda
                SqlCmd.Parameters.Add(Parametros.parametro("@dato", SqlDbType.VarChar, 200, dato));

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public static int CantidadUsuario()
        {
            int Cantidad = 0;
            DataTable DtResultado = new DataTable("CantidadUsuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CantidadUsuarios";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
                DataRow dr;
                dr = DtResultado.Rows[0];
                Cantidad = Convert.ToInt32(dr["CantidadUsuarios"]);
            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return Cantidad;
        }
        public static bool VerificarAdmin(int idUsuario)
        {
            bool resultado=false;
            DataTable DtResultado = new DataTable("Resultado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "fn_VerificarAdmin";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //agregando parametros
                SqlCmd.Parameters.Add(Parametros.parametro("@idUsuario", SqlDbType.Int, 0, idUsuario));
                var retValParam = new SqlParameter("RetVal", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                SqlCmd.Parameters.Add(retValParam);
                SqlCmd.ExecuteScalar();

                resultado = (bool)retValParam.Value;
            }
            catch (Exception)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resultado;
        }
        public static bool VerificarNombre(string nombre)
        {
            bool resultado = false;
            DataTable DtResultado = new DataTable("Resultado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "fn_VerificarNombreUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //agregando parametros
                SqlCmd.Parameters.Add(Parametros.parametro("@nombreUsuario", SqlDbType.VarChar, 50, nombre));
                var retValParam = new SqlParameter("RetVal", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.ReturnValue
                };
                SqlCmd.Parameters.Add(retValParam);
                SqlCmd.ExecuteScalar();

                resultado = (bool)retValParam.Value;
            }
            catch (Exception)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resultado;
        }
        #endregion
    }
}
