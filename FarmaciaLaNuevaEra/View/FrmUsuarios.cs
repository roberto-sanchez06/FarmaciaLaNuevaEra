using FarmaciaLaNuevaEra.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaLaNuevaEra.View
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            FrmEspecificacionUsuario frm = new FrmEspecificacionUsuario();
            frm.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = CUsuario.Buscar(txtBuscar.Text);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            MostraToolTip();
        }

        private void FrmUsuarios_Activated(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = CUsuario.MostrarUsuarios();
        }
        private void MostraToolTip()
        {
            ToolTip ttAgregar = new ToolTip();
            ttAgregar.SetToolTip(btnAgregarUsuarios, "Agregar usuario");
        }
        private void MenuItemsActualizar_Usuarios(object sender, EventArgs e)
        {
            MenuItem menuItem = (sender as MenuItem);
            Dictionary<string, dynamic> Usuario = (Dictionary<string, dynamic>)menuItem.Tag;
            int idUsuario = Usuario["IdUsuario"];
            int idEmpleado = Usuario["IdEmpleado"];
            FrmEspecificacionUsuario frmEspecificacionUsuario =
           new FrmEspecificacionUsuario(idUsuario, idEmpleado, Usuario["Nombre del perfil"], Usuario["Rol"], Usuario["NombresApellidosEmp"]);
            frmEspecificacionUsuario.ShowDialog();
        }

        private void MenuItemsCambiarEstado_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = (sender as MenuItem);
            Dictionary<string, dynamic> Usuario = (Dictionary<string, dynamic>)menuItem.Tag;
            int id = Usuario["IdUsuario"];
            if (!CUsuario.VerificarAdmin(id))
            {
                CUsuario.CambiarEstado(id);
                MessageBox.Show($"El estado del usuario con id {id} ha sido modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No es conveniente deshabilitar al usuario con id {id} debido a que no habran administradores",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dgvUsuarios.HitTest(e.X, e.Y).RowIndex > -1)
            {
                int currentMouseOverRow = dgvUsuarios.HitTest(e.X, e.Y).RowIndex;
                Dictionary<string, dynamic> usuarios = new Dictionary<string, dynamic>();
                usuarios.Add("IdUsuario", dgvUsuarios.Rows[currentMouseOverRow].Cells[0].Value);
                usuarios.Add("NombresApellidosEmp", dgvUsuarios.Rows[currentMouseOverRow].Cells[1].Value);
                usuarios.Add("IdEmpleado", dgvUsuarios.Rows[currentMouseOverRow].Cells[2].Value);
                usuarios.Add("Nombre del perfil", dgvUsuarios.Rows[currentMouseOverRow].Cells[3].Value);
                usuarios.Add("Rol", dgvUsuarios.Rows[currentMouseOverRow].Cells[4].Value);
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Actualizar"));
                m.MenuItems[0].Click += MenuItemsActualizar_Usuarios;
                m.MenuItems[0].Tag = usuarios;
                string estado = dgvUsuarios.Rows[currentMouseOverRow].Cells[5].Value.ToString();
                string nombreMenuItem = estado == "Habilitado" ? "Deshabilitar usuario" : "Habilitar usuario";
                m.MenuItems.Add(new MenuItem(nombreMenuItem));
                m.MenuItems[1].Click += MenuItemsCambiarEstado_Click;
                m.MenuItems[1].Tag = usuarios;
                m.Show(dgvUsuarios, new Point(e.X, e.Y));
            }
        }
    }
}
