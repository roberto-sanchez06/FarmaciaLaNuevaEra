using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public static class CEmpleado
    {
        public static string InsertarEmpleado(string nombres, string apellidos, string cargo, decimal sueldo)
        {
            DEmpleado empleado = new DEmpleado();
            empleado.Nombres = nombres;
            empleado.Apellidos = apellidos;
            empleado.Cargo = cargo;
            empleado.Sueldo = sueldo;
            return empleado.InsertarEmpleado(empleado);
        }
        public static string EditarEmpleado(int idEmpleado, string nombres, string apellidos, string cargo, decimal sueldo)
        {
            DEmpleado empleado = new DEmpleado();
            empleado.IdEmpleado = idEmpleado;
            empleado.Nombres = nombres;
            empleado.Apellidos = apellidos;
            empleado.Cargo = cargo;
            empleado.Sueldo = sueldo;
            return empleado.EditarEmpleado(empleado);
        }
        public static DataTable MostrarEmpleados()
        {
            return DEmpleado.MostrarEmpleado();
        }
        public static DataTable Buscar(string dato)
        {
            return DEmpleado.Buscar(dato);
        }
        public static DataTable CambiarEstado(int idEmpleado)
        {
            return DEmpleado.CambiarEstado(idEmpleado);
        }
        public static int CantidadEmpleados()
        {
            return DEmpleado.CantidadEmpleados();
        }
        public static bool VerificarAdminPorEmpleado(int idEmpleado)
        {
            return DEmpleado.VerificarAdminPorEmpleado(idEmpleado);
        }
    }
}
