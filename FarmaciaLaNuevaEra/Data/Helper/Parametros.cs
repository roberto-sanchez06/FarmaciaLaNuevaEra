using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Data.Helper
{
   public class Parametros
    {

       public static SqlParameter parametro(string nombreParametro, SqlDbType tipoDeParametro, int tamaño, object valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombreParametro;
            parametro.SqlDbType = tipoDeParametro;
            if (tamaño != 0)
            {
                parametro.Size = tamaño;
            }

            parametro.Value = valor;
            return parametro;
        }
    }
}
