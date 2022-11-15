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
    public partial class FrmRemito : Form
    {
        private int idordencompra;
        public FrmRemito()
        {
            InitializeComponent();
        }

        private void btnagregarordenpedido_Click(object sender, EventArgs e)
        {
            
            
                dgvOrdenes.DataSource = CRemito.MostrarOrdenCompra();
                dgvOrdenes.Visible = true;
           
        
           
          
        }

        private void dgvOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idordencompra = Convert.ToInt32(dgvOrdenes.Rows[e.RowIndex].Cells[0].Value);
                labelorden.Visible = true;
                labelorden.Text = idordencompra.ToString();
                dgvOrdenes.Visible = false;
                cargardetallescompra();
                dgvdetallescompra.Visible = true;
                

                //dgvMedicamentosDetalle.Rows[dgvMedicamentosDetalle.Rows.Count-1].Cells[dgvMedicamentosDetalle.Columns.Count-1].Value = 22;

            }
        }
        private void cargardetallescompra()
        {
            dgvdetallescompra.DataSource = CRemito.MostrarDetallesdecompra(idordencompra);
        }

        private void dgvdetallescompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemitir_Click(object sender, EventArgs e)
        {
            int totalseleccion = dgvdetallescompra.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Recibir"].Value)).Count();
            if (totalseleccion >= 1)
            {
                CRemito.Insertar_Remito(idordencompra);
                var idremito = Convert.ToInt32(CRemito.MostrarUltimoRemito().Rows[0]["Id"].ToString());
                foreach (DataGridViewRow row in dgvdetallescompra.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Recibir"].Value))
                    {
                        CRemito.Insertar_DetalleRemito(idordencompra, Convert.ToInt32(row.Cells["Id Medicamento"].Value), Convert.ToInt32(row.Cells["Cantidad pedida"].Value), idremito);
                    }
                }
                cargardetallescompra();
            }
            else
            {
                MessageBox.Show("no tiene ningun medicamento seleccionado para remitir a inventario");
            }
        }
    }
}
