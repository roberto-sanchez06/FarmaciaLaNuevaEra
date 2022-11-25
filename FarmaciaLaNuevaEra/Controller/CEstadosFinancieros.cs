using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public class CEstadosFinancieros
    {
        public static string IngresarCuenta(int Month, int Year, double Monto, string Cuenta, int Tipo)
        {
            DEstadosFinancieros estadosFinancieros = new DEstadosFinancieros();
            return estadosFinancieros.IngresarCuenta(Month, Year, Monto, Cuenta, Tipo);
        }
        public static DataTable CambiarCuentas(int IdPedidos)
        {
            return DEstadosFinancieros.CambiarCuentas(IdPedidos);
        }
    }
}
