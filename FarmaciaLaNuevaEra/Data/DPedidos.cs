using FarmaciaLaNuevaEra.Data.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Data
{
    public class DPedidos
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; }

        public string InsertarPedido(DPedidos pedidos)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CrearPedidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(Parametros.parametro("@IdEmpleado", SqlDbType.Int, 0, pedidos.IdEmpleado));
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso el Registro";
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
        public string VentaValidacion(int Id)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CrearPedidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(Parametros.parametro("@IdLaboratorio", SqlDbType.Int, 0, Id));
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso el Registro";
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
        public static DataTable MostrarPedidos(int Fecha, int Ano)
        {
            DataTable dtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarPedidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(Parametros.parametro("@Mes", SqlDbType.Int, 0, Fecha));
                SqlCmd.Parameters.Add(Parametros.parametro("@Ano", SqlDbType.Int, 0, Ano));

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);

            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;
        }
        public static DataTable UltimoRegistro()
        {
            DataTable dtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "UltimoPedido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);

            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;
        }
    }
}
