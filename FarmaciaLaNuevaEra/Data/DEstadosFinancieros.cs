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
    public class DEstadosFinancieros
    {
        public string IngresarCuenta(int Month, int Year, double Monto, string Cuenta, int Tipo)
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
                SqlCmd.CommandText = "EstadosFinancieros";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(Parametros.parametro("@Month", SqlDbType.Int, 0, Month));
                SqlCmd.Parameters.Add(Parametros.parametro("@Year", SqlDbType.Int, 0, Year));
                SqlCmd.Parameters.Add(Parametros.parametro("@Monto", SqlDbType.Money, 0, Monto));
                SqlCmd.Parameters.Add(Parametros.parametro("@Cuenta", SqlDbType.VarChar, 60, Cuenta));
                SqlCmd.Parameters.Add(Parametros.parametro("@Tipo", SqlDbType.Bit, 0, Tipo));
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

        public static DataTable CambiarCuentas(int IdPedidos)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EstadosFinancierosVentas";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(Parametros.parametro("@IdPedidos", SqlDbType.Int, 0, IdPedidos));


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                DataSet dataSet = new DataSet();
                SqlDat.Fill(dataSet);
                DtResultado = dataSet.Tables[1];
                return DtResultado;

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
