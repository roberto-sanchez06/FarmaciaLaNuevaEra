using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public class CMedicamentos
    {
     

        public static string InsertarMedicamento(int IdLaboratorio, string nombre, decimal precioCompra, decimal precioVenta,int stock,int stockMinimo)
        {
            DMedicamentos dMedicamentos = new DMedicamentos();
            dMedicamentos.IdLaboratorio = IdLaboratorio;
            dMedicamentos.Nombre = nombre;
            dMedicamentos.PrecioCompra = precioCompra;
            dMedicamentos.PrecioVenta = precioVenta;
            dMedicamentos.Stock = stock;
            dMedicamentos.StockMinimo = stockMinimo;
            return dMedicamentos.InsertarMedicamento(dMedicamentos);
        }
        public static string ActualizarMedicamento(int id,int IdLaboratorio, string nombre, decimal precioCompra, decimal precioVenta, int stock, int stockMinimo, bool Estado)
        {

            DMedicamentos dMedicamentos = new DMedicamentos();
            dMedicamentos.Id = id;
            dMedicamentos.IdLaboratorio = IdLaboratorio;
            dMedicamentos.Nombre = nombre;
            dMedicamentos.PrecioCompra = precioCompra;
            dMedicamentos.PrecioVenta = precioVenta;
            dMedicamentos.Stock = stock;
            dMedicamentos.StockMinimo = stockMinimo;
            dMedicamentos.Estado = Estado;
            return dMedicamentos.ActualizarMedicamento(dMedicamentos);
        }
        public static DataTable MostrarMedicamentos(bool tipoMedicamentos)
        {
            return DMedicamentos.MostrarMedicamentos(tipoMedicamentos);
        }
        public static int CantidadMedicamentos()
        {
            return DMedicamentos.CantidadMedicamento();
        }
        public static DataTable MostrarMedicamento(int id)
        {
            return DMedicamentos.MostrarMedicamento(id);
        }
    }
}
