using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public class CRemito
    {
        public static DataTable MostrarOrdenCompra()
        {
            return DRemito.MostrarOrdenCompra();
        }
        public static DataTable MostrarDetallesdecompra(int idcompra)
        {
            return DRemito.MostrarDetallesdecompra(idcompra);   
        }
        public static string Insertar_DetalleRemito(int idcompra, int idmedicamento, int cantidad, int idremito)
        {
            return DRemito.Insertar_DetalleRemito(idcompra, idmedicamento, cantidad, idremito);
        }
        public static string Insertar_Remito(int idcompra)
        {
            return DRemito.Insertar_Remito(idcompra);
        }
        public static DataTable MostrarUltimoRemito()
        {
            return DRemito.MostrarUltimoRemito();
        }
    }
}
