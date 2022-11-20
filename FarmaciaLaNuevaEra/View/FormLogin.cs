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
    public partial class FormLogin : Form
    {
        private int idEmpleado;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataTable dato;
            dato = CUsuario.Validar_acceso(this.txtName.Text, this.txtPassword.Text);
            if (dato != null)
            {
                if (dato.Rows.Count > 0)
                {
                    DataRow dr;
                    dr = dato.Rows[0];
                    if (dr["Resultado"].ToString() == "Acceso Exitoso")
                    {
                        string Rol = dato.Rows[0][1].ToString();
                        idEmpleado = int.Parse(dato.Rows[0][2].ToString());
                        MessageBox.Show("Bienvenido al Sistema", "Farmacia La Nueva Era", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmPrincipal frmPrincipal = new FrmPrincipal(Rol, idEmpleado);
                        frmPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado al sistema", "Farmacia La Nueva Era", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtName.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        txtName.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay conexión al Servidor", "Farmacia La Nueva Era", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.txtName.Focus();
        }
    }
}
