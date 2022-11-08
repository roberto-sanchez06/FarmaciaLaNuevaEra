using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public class CEfectivo
    {
        public static string Ingresar_Dinero(decimal monto)
        {
            return DEfectivo.Ingresar_Dinero(monto);
        }
        public static string Donaciones(decimal monto)
        {
            return DEfectivo.Donaciones(monto);
        }
    }
}
