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
    public partial class FrmMiniEmpleado : Form
    {
        public int idEmpleado = -1;
        public string nombreEmpleado;
        public FrmMiniEmpleado()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = CUsuario.Buscar(txtBuscar.Text);
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEmpleado = (int)dgvEmpleado.Rows[e.RowIndex].Cells[0].Value;
                string nombres = dgvEmpleado.Rows[e.RowIndex].Cells[1].Value.ToString();
                string apellidos = dgvEmpleado.Rows[e.RowIndex].Cells[2].Value.ToString();
                nombreEmpleado = nombres + " " + apellidos;
                this.Close();
            }
        }

        private void FrmMiniEmpleado_Load(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = CEmpleado.MostrarEmpleados();
        }
    }
}
