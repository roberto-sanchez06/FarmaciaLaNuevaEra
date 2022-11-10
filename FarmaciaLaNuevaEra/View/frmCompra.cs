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
        public class EspecificacionMedicamentos
        {
            public int IdMedicamento { get; set; }
            public int CantidadPedida { get; set; }
        }
        List<EspecificacionMedicamentos> EspecificacionMedicamento=new List<EspecificacionMedicamentos>();


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
            dgvMedicamentos.Visible = false;
            

        }

        private void dgvLaboratorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int IdMedicamento = -1;
        List<DataTable> dataTables = new List<DataTable>();
        private void dgvLaboratorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvLaboratorios.Rows[e.RowIndex].Cells[0].Value);
                dgvMedicamentos.DataSource=COrdenCompra.BuscarMedicamentoPorIdLaboratorio(id);
                
                dgvLaboratorios.Visible = false;
                dgvMedicamentos.Visible = true;
     
                
            }
            

        }

        private void FrmCompra_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdMedicamento = Convert.ToInt32(dgvMedicamentos.Rows[e.RowIndex].Cells[0].Value);
                DataTable medicamento= CMedicamentos.MostrarMedicamento(IdMedicamento);
                medicamento.Columns.Add("Cantidad pedida", typeof(int));
                medicamento.Columns[8].DefaultValue = 22;
                dataTables.Add(medicamento);
                
                dgvMedicamentosDetalle.DataSource = dataTables;
                //dgvMedicamentosDetalle.Rows[dgvMedicamentosDetalle.Rows.Count-1].Cells[dgvMedicamentosDetalle.Columns.Count-1].Value = 22;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
