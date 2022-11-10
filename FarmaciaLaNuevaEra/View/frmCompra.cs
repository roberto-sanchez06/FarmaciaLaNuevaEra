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
    public partial class frmCompra : Form
    {
        
        public frmCompra()
        {
            InitializeComponent();
        }

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Totall_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarLaboratorio_Click(object sender, EventArgs e)
        {
            dgvLaboratorios.DataSource = CLaboratorio.MostrarLaboratorios(true);
            dgvLaboratorios.Visible = true;

        }

        private void dgvLaboratorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLaboratorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvLaboratorios.Rows[e.RowIndex].Cells[0].Value);
            }
            

        }
    }
}
