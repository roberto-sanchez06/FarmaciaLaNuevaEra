using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public class CLaboratorio
    {


        public static string InsertarLaboratorio(string nombre)
        {
            DLaboratorio laboratorio = new DLaboratorio();
            laboratorio.Nombre = nombre;
            return laboratorio.InsertarLaboratorio(laboratorio);
        }
        public static string ActualizarLaboratorio(int ID, string nombre)
        {
            DLaboratorio laboratorio = new DLaboratorio();
            laboratorio.Nombre = nombre;
            laboratorio.ID = ID;
            return laboratorio.ActualizarLaboratorio(laboratorio);
        }
        public static DataTable MostrarLaboratorios()
        {
            return DLaboratorio.MostrarLaboratorios();
        }

    }
}
