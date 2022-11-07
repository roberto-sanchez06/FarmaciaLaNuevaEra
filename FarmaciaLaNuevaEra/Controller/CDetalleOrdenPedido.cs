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
    }
}
