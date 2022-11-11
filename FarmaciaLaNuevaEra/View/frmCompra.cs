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
        private int idlaboratorio;
        private int RowMedicamento;
        private DataTable detalles;
        private int IdMedicamento;
        private List<int> Medicamentos;
        private decimal total;
        
        

        public frmCompra()
        {
            InitializeComponent();
        
           RowMedicamento = 0;
           detalles = new DataTable();
            idlaboratorio = 0;
            IdMedicamento = -1;
            Medicamentos = new List<int>();
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
        
        List<DataTable> dataTables = new List<DataTable>();
        private void dgvLaboratorios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                 idlaboratorio = Convert.ToInt32(dgvLaboratorios.Rows[e.RowIndex].Cells[0].Value);
                laboratoriolbl.Text = dgvLaboratorios.Rows[e.RowIndex].Cells[1].Value.ToString();
                dgvMedicamentos.DataSource=COrdenCompra.BuscarMedicamentoPorIdLaboratorio(idlaboratorio);
                
                dgvLaboratorios.Visible = false;
                dgvMedicamentos.Visible = true;
                label1.Visible = true;
                laboratoriolbl.Visible = true;
                
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
               
                //dgvMedicamentosDetalle.Rows[dgvMedicamentosDetalle.Rows.Count-1].Cells[dgvMedicamentosDetalle.Columns.Count-1].Value = 22;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //var respuesta = CDetalleOrdenCompra.verificar_efectivo(total);
            //string respuesta1 = respuesta.Rows[0].ToString();
            //if (respuesta1 == "valido")
            //{

            //}
            //else
            //{
            //    MessageBox.Show("no hay suficiente dineroi en caha");
            //}
            //if (dgvMedicamentosDetalle.Rows.Count > 0)
            //{
            //    COrdenCompra.insertar_orden_compra(idlaboratorio);
            //    detalles = COrdenCompra.BuscarMedicamentoPorIdLaboratorio(idlaboratorio);
            //    bool bandera = true;
            //    int index = 0,
            //    id = 
            //        Convert.ToInt32(COrdenCompra.Ultimoidcompra) : 0;
            //    while (bandera)
            //    {
            //        for (int i = 0; i < Lista.Rows.Count; i++)
            //        {
            //            if (index > Medicamentos.Count - 1 || i == Lista.Rows.Count)
            //            {
            //                bandera = false;
            //                break;
            //            }
            //            if (Lista.Rows[i]["Id del Medicamento"].ToString() == Medicamentos[index].ToString())
            //            {
            //                if (index > Medicamentos.Count)
            //                {
            //                    bandera = false;
            //                    break;
            //                }
            //                CDetalleOrdenPedido.InsertarDetalleOrdenPedido(id,
            //                    Convert.ToInt32(Lista.Rows[i]["Id del Medicamento"].ToString()),
            //                    Convert.ToInt32(dgvMedicamentoAñadidos.Rows[index].Cells[1].Value.ToString()));
            //                index++;
            //            }
            //        }
            //    }
            //    this.Close();
            //    return;
            //}
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtCantidad != null && idlaboratorio!=-1)
            {
                if (Medicamentos.Contains(IdMedicamento))
                {
                    MessageBox.Show("ya se agrego");
                }
                else
                {
                    Medicamentos.Add(IdMedicamento);
                    detalles = COrdenCompra.BuscarMedicamentoPorIdLaboratorio(idlaboratorio);
                    for (int i = 0; i < detalles.Rows.Count; i++)
                    {
                        if (detalles.Rows[i]["Id del Medicamento"].ToString() == Medicamentos.Last().ToString())
                        {
                            dgvMedicamentosDetalle.Rows.Add(detalles.Rows[i]["Medicamento"].ToString(), detalles.Rows[i]["Precio comprado"].ToString(),
                            txtCantidad.Text.ToString());
                            break;
                        }
                    }
                }

                totalizado();

            }
        }
        public void totalizado()
        {
           
            foreach (DataGridViewRow item in dgvMedicamentosDetalle.Rows)
            {
                total += Convert.ToDecimal(item.Cells["Precio_comprado"].Value) * Convert.ToDecimal(item.Cells["cantidad_comprar"].Value);
            }
            Totall.Text = total.ToString(); 
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            totalizado();
        }
    }
}
