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
        private void MostrarToolTip()
        {
            ToolTip ttAgregar = new ToolTip();
            ttAgregar.SetToolTip(btnAgregarEmpleados, "Agregar empleado");
            ToolTip ttPagar = new ToolTip();
            ttPagar.SetToolTip(btnPagoEmpleados, "Pagar a los empleados");
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarToolTip();
            if (DateTime.Today.Day == 25)
            {
                btnPagoEmpleados.Visible = true;
            }
            else
            {
                btnPagoEmpleados.Visible = false;
            }
        }
        private void MenuItemsActualizar_Empleado(object sender, EventArgs e)
        {
            MenuItem menuItem = (sender as MenuItem);
            Dictionary<string, dynamic> empleado = (Dictionary<string, dynamic>)menuItem.Tag;
            int idEmpleado = empleado["IdEmpleado"];
            FrmEspecificacionEmpleado frmEspecificacionEmpleado =
           new FrmEspecificacionEmpleado(idEmpleado, empleado["Nombres"], empleado["Apellidos"], empleado["Sueldo"], empleado["Cargo"]);
            frmEspecificacionEmpleado.ShowDialog();
        }

        private void MenuItemsCambiarEstado_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = (sender as MenuItem);
            Dictionary<string, dynamic> empleado = (Dictionary<string, dynamic>)menuItem.Tag;
            int id = empleado["IdEmpleado"];
            if (!CEmpleado.VerificarAdminPorEmpleado(id))
            {
                CEmpleado.CambiarEstado(id);
                MessageBox.Show($"El estado del empleado con id {id} ha sido modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No es conveniente deshabilitar al empelado con id {id} debido a que sus cuentas asociadas se inhabilitaran y es el unico administrador actualmente",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmpleados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dgvEmpleados.HitTest(e.X, e.Y).RowIndex > -1)
            {
                int currentMouseOverRow = dgvEmpleados.HitTest(e.X, e.Y).RowIndex;
                Dictionary<string, dynamic> empleados = new Dictionary<string, dynamic>();
                empleados.Add("IdEmpleado", dgvEmpleados.Rows[currentMouseOverRow].Cells[0].Value);
                empleados.Add("Nombres", dgvEmpleados.Rows[currentMouseOverRow].Cells[1].Value);
                empleados.Add("Apellidos", dgvEmpleados.Rows[currentMouseOverRow].Cells[2].Value);
                empleados.Add("Cargo", dgvEmpleados.Rows[currentMouseOverRow].Cells[3].Value);
                empleados.Add("Sueldo", dgvEmpleados.Rows[currentMouseOverRow].Cells[4].Value);
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Actualizar"));
                m.MenuItems[0].Click += MenuItemsActualizar_Empleado;
                m.MenuItems[0].Tag = empleados;
                string estado = dgvEmpleados.Rows[currentMouseOverRow].Cells[5].Value.ToString();
                string nombreMenuItem = estado == "Activo" ? "Deshabilitar empleado" : "Habilitar empleado";
                m.MenuItems.Add(new MenuItem(nombreMenuItem));
                m.MenuItems[1].Click += MenuItemsCambiarEstado_Click;
                m.MenuItems[1].Tag = empleados;
                m.Show(dgvEmpleados, new Point(e.X, e.Y));
            }
        }

        private void FrmEmpleados_Activated(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = CEmpleado.MostrarEmpleados();
        }

        private void btnPagoEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = CEmpleado.RealizarPago();
                if (rpta == "OK")
                {
                    MessageBox.Show("El pago se ha realizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnPagoEmpleados.Visible = false;
                }
                else
                {
                    MessageBox.Show(rpta, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //btnPagoEmpleados.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
