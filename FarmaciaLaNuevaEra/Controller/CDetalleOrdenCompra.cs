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


        
    }
}
