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
   public class DMedicamentos
    {
        public int Id { get; set; }
        public int IdLaboratorio { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }

        public string InsertarMedicamento(DMedicamentos medicamento)
        {
            string rpta = "";
            //@IdLaboratorio int,@Nombre varchar(30),@PrecioCompra money, @precioVenta money,@Stock int, @stockMinimo int
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Medicamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(Parametros.parametro("@IdLaboratorio",SqlDbType.Int,0,medicamento.IdLaboratorio));
                SqlCmd.Parameters.Add(Parametros.parametro("@Nombre", SqlDbType.VarChar, 30, medicamento.Nombre));
                SqlCmd.Parameters.Add(Parametros.parametro("@PrecioCompra", SqlDbType.Money, 0, medicamento.PrecioCompra));
                SqlCmd.Parameters.Add(Parametros.parametro("@precioVenta", SqlDbType.Money, 0, medicamento.PrecioVenta));
                SqlCmd.Parameters.Add(Parametros.parametro("@Stock", SqlDbType.Int, 0, medicamento.Stock));
                SqlCmd.Parameters.Add(Parametros.parametro("@stockMinimo", SqlDbType.Int, 0, medicamento.StockMinimo));

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso el Registro";


            }
            catch(Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }
        public string ActualizarMedicamento(DMedicamentos medicamento)
        {

            string rpta = "";
            //@IdLaboratorio int,@Nombre varchar(30),@PrecioCompra money, @precioVenta money,@Stock int, @stockMinimo int
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Actualizar_Medicamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(Parametros.parametro("@idMedicamento", SqlDbType.Int, 0, medicamento.Id));
                SqlCmd.Parameters.Add(Parametros.parametro("@IdLaboratorio", SqlDbType.Int, 0, medicamento.IdLaboratorio));
                SqlCmd.Parameters.Add(Parametros.parametro("@Nombre", SqlDbType.VarChar, 30, medicamento.Nombre));
                SqlCmd.Parameters.Add(Parametros.parametro("@PrecioCompra", SqlDbType.Money, 0, medicamento.PrecioCompra));
                SqlCmd.Parameters.Add(Parametros.parametro("@precioVenta", SqlDbType.Money, 0, medicamento.PrecioVenta));
                SqlCmd.Parameters.Add(Parametros.parametro("@Stock", SqlDbType.Int, 0, medicamento.Stock));
                SqlCmd.Parameters.Add(Parametros.parametro("@stockMinimo", SqlDbType.Int, 0, medicamento.StockMinimo));
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
        public static DataTable MostrarMedicamentos()
        {
            DataTable DtResultado = new DataTable("MostrarMedicamentos");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Medicamentos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public static int CantidadMedicamento()
        {
            int Cantidad=0;
            DataTable DtResultado = new DataTable("CantidadMedicamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "CantidadMedicamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
                DataRow dr;
                dr = DtResultado.Rows[0];
                Cantidad= Convert.ToInt32(dr["CantidadMedicamento"]);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return Cantidad;
        }
    }
}
