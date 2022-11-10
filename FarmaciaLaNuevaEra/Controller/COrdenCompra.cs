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
        public static DataTable Mostrar_labs()
        {
            return DOrdenCompra.LaboratorioActivo();
        }
    }
}
