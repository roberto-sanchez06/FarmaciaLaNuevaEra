using FarmaciaLaNuevaEra.Controller;
using FarmaciaLaNuevaEra.Data.Enums;
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
    public partial class FrmEspecificacionUsuario : Form
    {
        private Roles rol;
        private int idEmpleado = -1;
        private int idUsuario;
        private bool nuevo;
        public FrmEspecificacionUsuario()
        {
            InitializeComponent();
            this.nuevo = true;
        }
        public FrmEspecificacionUsuario(int id, int idEmp, string nombrePerfil, string rol, string nombreEmpleado)
        {
            InitializeComponent();
            this.nuevo = false;
            this.idUsuario = id;
            this.idEmpleado = idEmp;
            txtNombre.Text = nombrePerfil;
            this.rol = (Roles)Enum.Parse(typeof(Roles), rol);
            btnAgregar.Text = "Editar";
            lblEmpleado.Text = nombreEmpleado;
        }
        #region metodos
        private void LimpiarCampos()
        {
            txtContraseña.Clear();
            txtRepetirContraseña.Clear();
            txtNombre.Clear();
            cmbRol.SelectedIndex = -1;
        }
        private void Verificar()
        {
            if ((string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(txtRepetirContraseña.Text) || cmbRol.SelectedIndex == -1) && nuevo)
            {
                throw new ArgumentException("No ha rellenado todos los campos necesarios para insertar usuario");
            }
            if ((string.IsNullOrWhiteSpace(txtNombre.Text) || cmbRol.SelectedIndex == -1) && nuevo == false)
            {
                throw new ArgumentException("No ha rellenado todos los campos para actualizar usuario");
            }
            if (idEmpleado == -1)
            {
                throw new ArgumentException("Debe asignarle un empleado al usuario");
            }
            if (txtContraseña.Text != txtRepetirContraseña.Text)
            {
                throw new ArgumentException("Las contraseñas no coinciden");
            }
        }
        private void MostrarToolTip()
        {
            ToolTip ttEmpelado = new ToolTip();
            ttEmpelado.SetToolTip(btnEmpleados, "Asignar empleado");
        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Verificar();
                if (nuevo)
                {
                    if (CUsuario.VerificarNombre(txtNombre.Text))
                    {
                        throw new ArgumentException("No pueden repetirse nombres de usuarios");
                    }
                    CUsuario.InsertarUsuario(idEmpleado, txtNombre.Text, cmbRol.Text, txtContraseña.Text);
                    MessageBox.Show("El usuario fue ingresado satisfactoriamente");
                    LimpiarCampos();
                }
                else
                {
                    CUsuario.EditarUsuario(idUsuario, idEmpleado, txtNombre.Text, cmbRol.Text, txtContraseña.Text);
                    MessageBox.Show("El usuario fue actualizado satisfactoriamente");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEspecificacionUsuario_Load(object sender, EventArgs e)
        {
            MostrarToolTip();
            cmbRol.DataSource = Enum.GetValues(typeof(Roles));
            cmbRol.SelectedIndex = (int)rol;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmMiniEmpleado frmMiniEmpleado = new FrmMiniEmpleado();
            frmMiniEmpleado.ShowDialog();
            if (frmMiniEmpleado.idEmpleado != -1)
            {
                idEmpleado = frmMiniEmpleado.idEmpleado;
                lblEmpleado.Text = frmMiniEmpleado.nombreEmpleado;
            }
        }
    }
}
