using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public  class CDetalleOrdenCompra
    {
      public static DataTable verificar_efectivo(decimal monto)
        {
            return DDetalleCompra.Verificar_Efectivo(monto);
        }
        public static string InsertarDetalleOrdenCompra(int idmedicamento, int idcompra, int cantidad)
        {
            DDetalleCompra detalleOrdencompra = new DDetalleCompra();
            detalleOrdencompra.CantidadPedida = cantidad;
            detalleOrdencompra.idMedicamento = idmedicamento;
            detalleOrdencompra.idOrdenCompra = idcompra;

            return DDetalleCompra.InsertarDetalleOrdenCompra(detalleOrdencompra);
        }




    }
}
