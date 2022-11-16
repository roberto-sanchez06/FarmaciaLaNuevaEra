using FarmaciaLaNuevaEra.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaLaNuevaEra.View
{
    public partial class FrmRemito : Form
    {
        public void AgregarTooltips()
        {
            ToolTip toolTipAgregarRemito = new ToolTip();
            toolTipAgregarRemito.SetToolTip(this.btnAgregarRemito, "Agregar Remito");
        }
        public FrmRemito()
        {
            InitializeComponent();
            AgregarTooltips();
        }
        private void FrmRemito_Activated(object sender, EventArgs e)
        {
            DataTable table = CRemito.MostrarRemitos(DateTime.Now.Month, DateTime.Now.Year);
            if(table is null)
            {
                return;
            }
            dgvOrdenes.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow Row = table.Rows[i];
                DateTime fecha = Convert.ToDateTime(table.Rows[i]["Fecha"].ToString());
                CultureInfo provider = new CultureInfo("es-ES");
                string FechaFormateada = fecha.ToString("dd", provider) + "-" +
                    fecha.ToString("MM", provider) + "-" + fecha.ToString("yyyy", provider);
                dgvOrdenes.Rows.Add(Row.ItemArray[0], Row.ItemArray[1], FechaFormateada);

            }
        }

        private void btnAgregarRemito_Click(object sender, EventArgs e)
        {
            FrmEspecificacionesRemito frmEspecificacionesRemito = new FrmEspecificacionesRemito();
            frmEspecificacionesRemito.ShowDialog();
        }
    }
}
