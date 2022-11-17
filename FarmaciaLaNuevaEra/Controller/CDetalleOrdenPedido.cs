using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public class CDetalleOrdenPedido
    {
        public static string InsertarDetalleOrdenPedido(int IdPedido, int IdMedicamento, int CantidadPedida)
        {
            DDetalleOrdenPedido detalleOrdenPedido = new DDetalleOrdenPedido();
            detalleOrdenPedido.IdPedidos = IdPedido;
            detalleOrdenPedido.IdMedicamentos = IdMedicamento;
            detalleOrdenPedido.CantidadPedida = CantidadPedida;
            return detalleOrdenPedido.InsertarDetalleOrdenPedido(detalleOrdenPedido);
        }
        public static DataTable VentasMensuales(int Mes, int Ano)
        {
            return DDetalleOrdenPedido.VentasMensuales(Mes, Ano);
        }
        public static DataTable VentasEstado(int Mes, int Ano, int Estado)
        {
            return DDetalleOrdenPedido.VentasEstado(Mes, Ano, Estado);
        }
        public static DataTable VentasEmpleado(int Mes, int Ano)
        {
            return DDetalleOrdenPedido.VentasEmpleado(Mes, Ano);
        }
        public static DataTable VentasPorMeses(int Ano)
        {
            return DDetalleOrdenPedido.VentasPorMes(Ano);
        }
        public static string ValidacionDetallesOrden(int IdPedidos)
        {
            DDetalleOrdenPedido detalleOrdenPedido = new DDetalleOrdenPedido();
            detalleOrdenPedido.IdPedidos = IdPedidos;
            return detalleOrdenPedido.ValidacionDetalleOrden(detalleOrdenPedido.IdPedidos);
        }
        public static string Venta(int IdPedidos, int IdMedicamentos)
        {
            DDetalleOrdenPedido detalleOrdenPedido = new DDetalleOrdenPedido();
            detalleOrdenPedido.IdPedidos = IdPedidos;
            detalleOrdenPedido.IdMedicamentos = IdMedicamentos;
            return detalleOrdenPedido.Venta(detalleOrdenPedido.IdPedidos, detalleOrdenPedido.IdMedicamentos);
        }
    }
}
