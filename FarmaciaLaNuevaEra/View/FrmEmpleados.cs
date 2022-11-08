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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = CEmpleado.Buscar(txtBuscar.Text);
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            FrmEspecificacionEmpleado frmEspecifiacionEmpleado = new FrmEspecificacionEmpleado();
            frmEspecifiacionEmpleado.ShowDialog();
            dgvEmpleados.DataSource = CEmpleado.MostrarEmpleados();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                try
                {
                    int id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["IdEmpleado"].Value);
                    if (!CEmpleado.VerificarAdminPorEmpleado(id))
                    {
                        CEmpleado.CambiarEstado(id);
                        MessageBox.Show($"El estado del empleado con id {id} ha sido modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvEmpleados.DataSource = CEmpleado.MostrarEmpleados(); 
                    }
                    else
                    {
                        throw new ArgumentException($"No es conveniente deshabilitar al empelado con id {id} debido a que sus cuentas asociadas se inhabilitaran y es el unico administrador actualmente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de cambiar el estado del empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                string nombres = Convert.ToString(dgvEmpleados.CurrentRow.Cells["Nombres"].Value);
                string apellidos = Convert.ToString(dgvEmpleados.CurrentRow.Cells["Apellidos"].Value);
                string cargo = Convert.ToString(dgvEmpleados.CurrentRow.Cells["Cargo"].Value);
                decimal sueldo = Convert.ToDecimal(dgvEmpleados.CurrentRow.Cells["Sueldo"].Value);
                int id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["IdEmpleado"].Value);
                FrmEspecificacionEmpleado frmEspecifiacionEmpleado = new FrmEspecificacionEmpleado(id,nombres, apellidos, sueldo, cargo);
                frmEspecifiacionEmpleado.ShowDialog();
                dgvEmpleados.DataSource = CEmpleado.MostrarEmpleados();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar al empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarToolTip()
        {
            ToolTip ttAgregar = new ToolTip();
            ttAgregar.SetToolTip(btnAgregarEmpleados, "Agregar empleado");
            ToolTip ttEditar = new ToolTip();
            ttAgregar.SetToolTip(btnEditarEmpleado, "Editar empleado");
            ToolTip ttDesactivar = new ToolTip();
            ttAgregar.SetToolTip(btnEliminarEmpleado, "Cambiar estado del empleado");
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarToolTip();
            dgvEmpleados.DataSource = CEmpleado.MostrarEmpleados();
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                string estado = Convert.ToString(dgvEmpleados.CurrentRow.Cells["Estado"].Value);
                if (string.Compare(estado, "Activo", StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    btnEliminarEmpleado.Image = pbAux2.Image;
                }
                else
                {
                    btnEliminarEmpleado.Image = pbAux.Image;
                }
            }
        }
    }
}
