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
        public static string ActualizarLaboratorio(int ID, string nombre,bool Estado)
        {
            DLaboratorio laboratorio = new DLaboratorio();
            laboratorio.Nombre = nombre;
            laboratorio.ID = ID;
            laboratorio.Estado = Estado;
            return laboratorio.ActualizarLaboratorio(laboratorio);
        }
        public static DataTable MostrarLaboratorios(bool tipoLaboratorio)
        {
            return DLaboratorio.MostrarLaboratorios(tipoLaboratorio);
        }
        public static DataTable MostrarLaboratorio(int id)
        {
            return DLaboratorio.MostrarLaboratorio(id);
        }

    }
}
