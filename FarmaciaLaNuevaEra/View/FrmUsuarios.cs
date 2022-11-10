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

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                string nombrePerfil = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Nombre del perfil"].Value);
                string rol = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Rol"].Value);
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
                int idEmp = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdEmpleado"].Value);
                string nombreEmpleado = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Nombres y apellidos del empleado"].Value);
                FrmEspecificacionUsuario frm = new FrmEspecificacionUsuario(id, idEmp,nombrePerfil, rol, nombreEmpleado);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar al empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                try
                {
                    int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
                    if (!CUsuario.VerificarAdmin(id))
                    {
                        CUsuario.CambiarEstado(id);
                        MessageBox.Show($"El estado del usuario con id {id} ha sido modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                    else
                    {
                        throw new ArgumentException($"No es conveniente deshabilitar al usuario con id {id} debido a que no habran administradores");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de cambiar el estado del usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            ToolTip ttEditar = new ToolTip();
            ttAgregar.SetToolTip(btnEditarUsuario, "Editar usuario");
            ToolTip ttDesactivar = new ToolTip();
            ttAgregar.SetToolTip(btnEliminarUsuario, "Cambiar estado del usuario");
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                string estado = Convert.ToString(dgvUsuarios.CurrentRow.Cells["Estado"].Value);
                if (string.Compare(estado, "Habilitado", StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    btnEliminarUsuario.Image = pbAux2.Image;
                }
                else
                {
                    btnEliminarUsuario.Image = pbAux.Image;
                }
            }
        }
    }
}
