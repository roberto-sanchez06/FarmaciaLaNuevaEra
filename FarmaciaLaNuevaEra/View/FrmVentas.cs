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
    public partial class FrmVentas : Form
    {
        private DataTable table;
        public FrmVentas()
        {
            InitializeComponent();
            AgregarTooltip();
            table = CPedidos.MostrarPedidos(DateTime.Today.Month, DateTime.Today.Year);
        }
        public void AgregarTooltip()
        {
            ToolTip toolTipAgregarMedicamento = new ToolTip();
            toolTipAgregarMedicamento.SetToolTip(this.btnAgregarVentas, "Agregar medicamentos");
        }
        private void btnAgregarVentas_Click(object sender, EventArgs e)
        {
            FrmEspecificacionesVenta frmEspecificacionesVenta = new FrmEspecificacionesVenta();
            frmEspecificacionesVenta.ShowDialog();
        }

        private void FrmVentas_Activated(object sender, EventArgs e)
        {
            for(int i = 0; i < table.Rows.Count; i++)
            {
                CPedidos.VentaValidacion(Convert.ToInt32(table.Rows[i]["Id del Pedido"].ToString()));
            }
            table = CPedidos.MostrarPedidos(DateTime.Today.Month, DateTime.Today.Year);
            dgvPedidos.DataSource = table;
        }
    }
}
