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
        //private decimal total;
        private int idmedicamentoborrado;
        
        

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
            if(dgvMedicamentosDetalle.Rows.Count == 0)
            {
                dgvLaboratorios.DataSource = CLaboratorio.MostrarLaboratorios(true);
                dgvLaboratorios.Visible = true;
                dgvMedicamentos.Visible = false;
            }
            else
            {
                MessageBox.Show("No puede cambiar de laboratorio ya que ya tiene medicamentos en el carrito, como recomendacion eliminelos si desea cambiar de laboratorio");
            }
            
            

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
            DataTable dato;
            dato = CDetalleOrdenCompra.verificar_efectivo(totalizado());
            if (dato != null)
            {
                if (dato.Rows.Count > 0)
                {
                    DataRow dr;
                    dr = dato.Rows[0];

                    if (dr["Resultado"].ToString() == "valido" && dgvMedicamentosDetalle.Rows.Count>0)
                    {
                        COrdenCompra.insertar_orden_compra(idlaboratorio);
                        var idorden = Convert.ToInt32(COrdenCompra.Ultimoidcompra().Rows[0]["Id"].ToString());
                        foreach (DataGridViewRow item in dgvMedicamentosDetalle.Rows)
                        {
                            CDetalleOrdenCompra.InsertarDetalleOrdenCompra(Convert.ToInt32(item.Cells["Id_Medicamento"].Value), idorden, Convert.ToInt32(item.Cells["cantidad_comprar"].Value));
                        }
                        dgvMedicamentosDetalle.Rows.Clear();
                        MessageBox.Show("compra realizada con exito");
                        totalizado();
                        Medicamentos.Clear();
                        
                    }
                    else
                    {
                        MessageBox.Show("debe agregar un medicaemnto o no tiene el efectivo para pagar esta compra");
                    }
                }
            }
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
                            dgvMedicamentosDetalle.Rows.Add(detalles.Rows[i]["Id del Medicamento"], detalles.Rows[i]["Medicamento"].ToString(), detalles.Rows[i]["Precio comprado"].ToString(),
                            txtCantidad.Text.ToString());
                            break;
                        }
                    }
                }

                totalizado();

            }
        }
        public decimal totalizado()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dgvMedicamentosDetalle.Rows)
            {
                total += Convert.ToDecimal(item.Cells["Precio_comprado"].Value) * Convert.ToDecimal(item.Cells["cantidad_comprar"].Value);
            }
            Totall.Text = total.ToString(); 
            return total;
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            totalizado();
        }

        private void dgvMedicamentosDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idmedicamentoborrado  = Convert.ToInt32(dgvMedicamentosDetalle.Rows[e.RowIndex].Cells[0].Value);
            RowMedicamento = dgvMedicamentosDetalle.CurrentCell.RowIndex;
            btn_eliminar.Visible = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(RowMedicamento >= 0)
            {
                Medicamentos.Remove(idmedicamentoborrado);
                dgvMedicamentosDetalle.Rows.Remove(dgvMedicamentosDetalle.Rows[RowMedicamento]);
                totalizado();
                btn_eliminar.Visible = false;
            }
            
        }
    }
}
