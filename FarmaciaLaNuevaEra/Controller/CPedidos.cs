using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public class CPedidos
    {
        public static string InsertarPedido(int IdEmpleado)
        {
            DPedidos pedidos = new DPedidos();
            pedidos.IdEmpleado = IdEmpleado;
            return pedidos.InsertarPedido(pedidos);
        }
        public static string VentaValidacion(int Id)
        {
            DPedidos pedidos = new DPedidos();
            return pedidos.VentaValidacion(Id);
        }
        public static DataTable MostrarPedidos(int Fecha, int Mes)
        {
            return DPedidos.MostrarPedidos(Fecha, Mes);
        }
        public static DataTable UltimoRegistro()
        {
            return DPedidos.UltimoRegistro();
        }
    }
}
