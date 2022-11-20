using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FarmaciaLaNuevaEra.Data.Helper;

namespace FarmaciaLaNuevaEra.Data
{
    public class DEmpleado
    {
        public int IdEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cargo { get; set; }
        public decimal Sueldo { get; set; }
        #region Metodos
        public string InsertarEmpleado(DEmpleado empleado)
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
                SqlCmd.CommandText = "InsertarEmpleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlCmd.Parameters.Add(Parametros.parametro("@Nombres", SqlDbType.VarChar, 60, empleado.Nombres));
                SqlCmd.Parameters.Add(Parametros.parametro("@apellidos", SqlDbType.VarChar, 60, empleado.Apellidos));
                SqlCmd.Parameters.Add(Parametros.parametro("@Cargo", SqlDbType.VarChar, 50, empleado.Cargo));
                SqlCmd.Parameters.Add(Parametros.parametro("@sueldo", SqlDbType.Money, 0, empleado.Sueldo));

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

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
        public string EditarEmpleado(DEmpleado empleado)
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
                SqlCmd.CommandText = "ActualizarEmpleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlCmd.Parameters.Add(Parametros.parametro("@idEmpleado", SqlDbType.Int, 0, empleado.IdEmpleado));
                SqlCmd.Parameters.Add(Parametros.parametro("@nombres", SqlDbType.VarChar, 60, empleado.Nombres));
                SqlCmd.Parameters.Add(Parametros.parametro("@apellidos", SqlDbType.VarChar, 60, empleado.Apellidos));
                SqlCmd.Parameters.Add(Parametros.parametro("@cargo", SqlDbType.VarChar, 60, empleado.Cargo));
                SqlCmd.Parameters.Add(Parametros.parametro("@sueldo", SqlDbType.Money, 0, empleado.Sueldo));

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
        public static DataTable MostrarEmpleado()
        {
            DataTable DtResultado = new DataTable("Empleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarEmpleados";
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
        public static DataTable Buscar(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarEmpleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarEmpleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //   Cargando el parámetro de Búsqueda
                SqlCmd.Parameters.Add(Parametros.parametro("@dato", SqlDbType.VarChar, 40, dato));

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public static DataTable CambiarEstado(int idEmpleado)
        {
            DataTable DtResultado = new DataTable("CambioEstado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando la conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CambiarEstadoEmpleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //   Cargando el parámetro de Búsqueda
                SqlCmd.Parameters.Add(Parametros.parametro("@idEmpleado", SqlDbType.Int, 0, idEmpleado));

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public static int CantidadEmpleados()
        {
            int Cantidad = 0;
            DataTable DtResultado = new DataTable("CantidadEmpleados");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CantidadEmpleados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
                DataRow dr;
                dr = DtResultado.Rows[0];
                Cantidad = Convert.ToInt32(dr["CantidadEmpleados"]);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return Cantidad;
        }
        public static bool VerificarAdminPorEmpleado(int idEmpleado)
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
                SqlCmd.CommandText = "fn_VerificarAdminPorEmpleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //agregando parametros
                SqlCmd.Parameters.Add(Parametros.parametro("@idEmpleado", SqlDbType.Int, 0, idEmpleado));
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
