using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public class COrdenCompra
    {
       public static DataTable BuscarMedicamentoPorIdLaboratorio(int IdLaboratorio)
        {
            return DOrdenCompra.BuscarMedicamentoPorIdLaboratorio(IdLaboratorio);
        }
        public static string insertar_orden_compra(int idlaboratorio)
        {
            return DOrdenCompra.Insertar_OrdenCompra(idlaboratorio);
        }
        public static DataTable Ultimoidcompra()
        {
            return DOrdenCompra.Ultimoidcompra();
        }
    }
}
