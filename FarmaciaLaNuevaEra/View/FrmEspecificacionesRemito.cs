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
    public partial class FrmEspecificacionesRemito : Form
    {
        private int IdOrdenCompra;
        private int Index;
        private List<int> Ids;
        private DataTable table;
        public void AgregarTooltips()
        {
            ToolTip toolTipRetroceder = new ToolTip();
            toolTipRetroceder.SetToolTip(this.btnRetroceder, "Mostrar las ordenes de compra");
        }
        public FrmEspecificacionesRemito()
        {
            InitializeComponent();
            Index = 0;
            AgregarTooltips();
            Ids = new List<int>();
            IdOrdenCompra = 0;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEspecificacionesRemito_Load(object sender, EventArgs e)
        {
            dgvdetallescompra.DataSource = CRemito.MostrarOrdenCompra();
        }

        private void dgvdetallescompra_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0 && Index == 0)
            {
                IdOrdenCompra = Convert.ToInt32(dgvdetallescompra.Rows[e.RowIndex].Cells[0].Value.ToString());
                dgvdetallescompra.DataSource = CRemito.MostrarDetallesdecompra(e.RowIndex);
                label2.Visible = false;
                btnRetroceder.Visible = true;
                lblTitulo.Visible = true;
                Index = 1;
                lblTitulo.Text = $"No de orden de compra: {IdOrdenCompra}";
                btnAgregar.Visible = true;
            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            dgvdetallescompra.DataSource = CRemito.MostrarOrdenCompra();
            label2.Visible = true;
            lblTitulo.Visible = false;
            btnRetroceder.Visible = false;
            Index = 0;
            btnAgregar.Visible = false;
        }

        private void FrmEspecificacionesRemito_Activated(object sender, EventArgs e)
        {
            if (Ids.Count > 0)
            {
                btnTerminar.Visible = true;
                dgvAgregados.Visible = true;
                lblTitulo2.Visible = true;
            }
            else
            {
                btnTerminar.Visible = false;
                dgvAgregados.Visible = false;
                lblTitulo2.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ids.Add(IdOrdenCompra);
            table = CRemito.MostrarOrdenCompra();
            foreach(DataRow row in table.Rows)
            {
                if(row.ItemArray[0].ToString() == IdOrdenCompra.ToString())
                {
                    dgvAgregados.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2]);
                    break;
                }
            }
            dgvAgregados.Visible = true;
            btnAgregar.Visible = false;
            btnTerminar.Visible = true;
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            foreach(int Id in Ids)
            {
                CRemito.Insertar_Remito(Id);
                table = CRemito.MostrarDetallesdecompra(Id);
                var IdRemito = CRemito.MostrarUltimoRemito().Rows[0]["Id"].ToString();
                foreach(DataRow row in table.Rows)
                {
                    CRemito.Insertar_DetalleRemito(Id, Convert.ToInt32(row.ItemArray[0].ToString()), 
                        Convert.ToInt32(row.ItemArray[2].ToString()), Convert.ToInt32(IdRemito));
                }
            }
            this.Close();
        }
    }
}
