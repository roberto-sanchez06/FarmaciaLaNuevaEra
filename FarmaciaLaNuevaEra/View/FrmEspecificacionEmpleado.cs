using FarmaciaLaNuevaEra.Controller;
using FarmaciaLaNuevaEra.Data.Enums;
using Guna.UI2.WinForms;
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
    public partial class FrmEspecificacionEmpleado : Form
    {
        private Cargos cargo;
        private bool nuevo;
        private int idEmpleado;
        public FrmEspecificacionEmpleado()
        {
            InitializeComponent();
            this.nuevo = true;
        }
        public FrmEspecificacionEmpleado(int idEmpleado, string nombres, string apellidos, decimal sueldo, string cargo)
        {
            InitializeComponent();
            this.nuevo = false;
            btnAgregar.Text = "Editar";
            this.idEmpleado = idEmpleado;
            txtApellidos.Text = apellidos;
            txtNombres.Text = nombres;
            txtSueldo.Text = sueldo.ToString();
            this.cargo = (Cargos)Enum.Parse(typeof(Cargos), cargo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Verificar();
                if (nuevo)
                {
                    CEmpleado.InsertarEmpleado(txtNombres.Text, txtApellidos.Text, cmbCargo.Text, decimal.Parse(txtSueldo.Text));
                    MessageBox.Show("El empleado fue ingresado satisfactoriamente");
                    LimpiarCampos();
                }
                else
                {
                    CEmpleado.EditarEmpleado(idEmpleado, txtNombres.Text, txtApellidos.Text, cmbCargo.Text, decimal.Parse(txtSueldo.Text));
                    MessageBox.Show("El empleado fue actualizado satisfactoriamente");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEspecifiacionEmpleado_Load(object sender, EventArgs e)
        {
            cmbCargo.DataSource = Enum.GetValues(typeof(Cargos));
            cmbCargo.SelectedIndex = (int)cargo;
        }
        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verificacion de decimales
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #region metodos
        private void LimpiarCampos()
        {
            txtApellidos.Clear();
            txtNombres.Clear();
            cmbCargo.SelectedIndex = -1;
            txtSueldo.Clear();
        }
        private void Verificar()
        {
            if (string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtSueldo.Text) || cmbCargo.SelectedIndex == -1)
            {
                throw new ArgumentException("Debe de rellenar todos los campos");
            }
        }
        #endregion
    }
}
