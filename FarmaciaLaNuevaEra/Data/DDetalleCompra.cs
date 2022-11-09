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
    public class DDetalleCompra
    {
        public int  idOrdenCompra { get; set; }
        public int idMedicamento { get; set; }
        public int CantidadPedida { get; set; }

        public DataTable Verificar_Efectivo(decimal monto)
        {

            DataTable dtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "verificar_efectivo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(Parametros.parametro("@monto_total", SqlDbType.Money, 0, monto));
          

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);

            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;
        }
        public string InsertarDetalleOrdenPedido(DDetalleCompra detalleOrdencompra)
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
                SqlCmd.CommandText = "insertar_detalleCompra";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(Parametros.parametro("@idcompra", SqlDbType.Int, 0, detalleOrdencompra.idOrdenCompra));
                SqlCmd.Parameters.Add(Parametros.parametro("@idmedicamento", SqlDbType.Int, 0, detalleOrdencompra.idMedicamento));
                SqlCmd.Parameters.Add(Parametros.parametro("@cantidad", SqlDbType.Int, 0, detalleOrdencompra.CantidadPedida));
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
    }
}
