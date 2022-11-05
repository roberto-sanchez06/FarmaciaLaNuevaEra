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
    public partial class FrmEspecificacionLaboratorio : Form
    {
        private bool Creacion;
        private int ID;
      
        public FrmEspecificacionLaboratorio(bool creacion)
        {
            InitializeComponent();
            this.Creacion = creacion;
            this.StEstado.Enabled = Creacion == true ? false : true;
        }
        public FrmEspecificacionLaboratorio(bool creacion,string nombre,int id,bool check)
        {
            InitializeComponent();
            this.txtNombre.Text = nombre;
            Creacion = creacion;
            this.StEstado.Enabled = Creacion == true ? false : true;
            this.btnAgregarLaboratorio.Text = "Actualizar";
            this.StEstado.Checked = check;
            this.ID = id;
        }
        private bool VerificarFormulario()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                return false;
            }
            return true;
        }
        private void btnAgregarLaboratorio_Click(object sender, EventArgs e)
        {
            if (!VerificarFormulario())
            {
                MessageBox.Show("Rellene todo el formulario");
                return;
            }
            if(Creacion)
                CLaboratorio.InsertarLaboratorio(txtNombre.Text);
            else
            {
                CLaboratorio.ActualizarLaboratorio(ID,txtNombre.Text,StEstado.Checked);
            }
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length >= 30)
            {
                lblCantidadDeLetras.ForeColor = Color.Red;
            }
            else
            {
                lblCantidadDeLetras.ForeColor = Color.FromArgb(64, 64, 64);
            }

            lblCantidadDeLetras.Text = txtNombre.Text.Length + "/30";
        }
    }
}
