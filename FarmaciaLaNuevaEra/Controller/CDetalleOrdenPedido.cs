using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
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
    }
}
