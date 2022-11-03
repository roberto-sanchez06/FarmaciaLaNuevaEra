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

                    if(dr["Resultado"].ToString()=="Acceso Exitoso")
                    {
                        MessageBox.Show("Si");
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
