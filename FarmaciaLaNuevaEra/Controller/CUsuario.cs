using FarmaciaLaNuevaEra.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaLaNuevaEra.Controller
{
    public class CUsuario
    {
        public static DataTable Validar_acceso(string usuario, string contraseña)
        {
            return new DUsuario().Validar_acceso(usuario, contraseña);
        }
        public static string InsertarUsuario(int idEmpleado, string nombre, string rol, string contraseña)
        {
            DUsuario dUsuario = new DUsuario();
            dUsuario.IdEmpleado = idEmpleado;
            dUsuario.NombrePerfil = nombre;
            dUsuario.RolConexion = rol;
            dUsuario.Contraseña = contraseña;
            return dUsuario.InsertarUsuario(dUsuario);
        }
        public static string EditarUsuario(int idUsuario, int idEmpleado, string nombre, string rol, string contraseña)
        {
            DUsuario dUsuario = new DUsuario();
            dUsuario.IdUsuario = idUsuario;
            dUsuario.IdEmpleado = idEmpleado;
            dUsuario.NombrePerfil = nombre;
            dUsuario.RolConexion = rol;
            dUsuario.Contraseña = contraseña;
            return dUsuario.EditarUsuario(dUsuario);
        }
        public static DataTable MostrarUsuarios()
        {
            return DUsuario.MostrarUsuarios();
        }
        public static DataTable CambiarEstado(int idUsuario)
        {
            return DUsuario.CambiarEstado(idUsuario);
        }
        public static DataTable Buscar(string dato)
        {
            return DUsuario.Buscar(dato);
        }
        public static int CantidadUsuario()
        {
            return DUsuario.CantidadUsuario();
        }
        public static bool VerificarAdmin(int idUsuario)
        {
            return DUsuario.VerificarAdmin(idUsuario);
        }
        public static bool VerificarNombre(string nombre)
        {
            return DUsuario.VerificarNombre(nombre);
        }
    }
}
