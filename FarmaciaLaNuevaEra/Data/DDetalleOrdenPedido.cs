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
    public class DDetalleOrdenPedido
    {
        public int Id { get; set; }
        public int IdPedidos { get; set; }
        public int IdMedicamentos { get; set; }
        public int CantidadPedida { get; set; }

        public string InsertarDetalleOrdenPedido(DDetalleOrdenPedido detalleOrdenPedido)
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
                SqlCmd.CommandText = "CrearDetallePedidos";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(Parametros.parametro("@IdPedido", SqlDbType.Int, 0, detalleOrdenPedido.IdPedidos));
                SqlCmd.Parameters.Add(Parametros.parametro("@IdMedicamento", SqlDbType.Int, 0, detalleOrdenPedido.IdMedicamentos));
                SqlCmd.Parameters.Add(Parametros.parametro("@CantidadPedida", SqlDbType.Int, 0, detalleOrdenPedido.CantidadPedida));
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
