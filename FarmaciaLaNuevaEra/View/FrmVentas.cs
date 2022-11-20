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
    public partial class FrmVentas : Form
    {
        private DataTable table;
        private int idEmpleado;
        public FrmVentas(int idEmpleado)
        {
            InitializeComponent();
            AgregarTooltip();
            table = CPedidos.MostrarPedidos(DateTime.Today.Month, DateTime.Today.Year);
            this.idEmpleado = idEmpleado;
        }
        public void AgregarTooltip()
        {
            ToolTip toolTipAgregarMedicamento = new ToolTip();
            toolTipAgregarMedicamento.SetToolTip(this.btnAgregarVentas, "Agregar Venta");
        }
        private void btnAgregarVentas_Click(object sender, EventArgs e)
        {
            FrmEspecificacionesVenta frmEspecificacionesVenta = new FrmEspecificacionesVenta(idEmpleado);
            frmEspecificacionesVenta.ShowDialog();
        }

        private void FrmVentas_Activated(object sender, EventArgs e)
        {
            table = CPedidos.MostrarPedidos(DateTime.Today.Month, DateTime.Today.Year);
            if (table is null)
            {
                return;
            }
            dgvPedidos.Rows.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow Row = table.Rows[i];
                DateTime fecha = Convert.ToDateTime(table.Rows[i]["Fecha"].ToString());
                CultureInfo provider = new CultureInfo("es-ES");
                string FechaFormateada = fecha.ToString("dd", provider) + "-" +
                    fecha.ToString("MM", provider) + "-" + fecha.ToString("yyyy", provider);
                string cadena = Row.ItemArray[3].ToString();
                if (cadena == "False")
                {
                    cadena = "Insatisfecho";
                }
                else
                {
                    cadena = "Satisfecho";
                }
                dgvPedidos.Rows.Add(Row.ItemArray[0], Row.ItemArray[1], FechaFormateada, cadena);

            }
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            frmGraficos frmGraficos = new frmGraficos();
            frmGraficos.Show();
        }
    }
}
