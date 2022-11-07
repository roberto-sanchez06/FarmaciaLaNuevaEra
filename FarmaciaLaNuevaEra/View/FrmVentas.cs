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
        public FrmVentas()
        {
            InitializeComponent();
            AgregarTooltip();
            table = CPedidos.MostrarPedidos(DateTime.Today.Month, DateTime.Today.Year);
        }
        public void AgregarTooltip()
        {
            ToolTip toolTipAgregarMedicamento = new ToolTip();
            toolTipAgregarMedicamento.SetToolTip(this.btnAgregarVentas, "Agregar Venta");
        }
        private void btnAgregarVentas_Click(object sender, EventArgs e)
        {
            FrmEspecificacionesVenta frmEspecificacionesVenta = new FrmEspecificacionesVenta();
            frmEspecificacionesVenta.ShowDialog();
        }

        private void FrmVentas_Activated(object sender, EventArgs e)
        {
            //Estoy arreglando la fecha, solo falta pasar la fecha a la columna
            table = CPedidos.MostrarPedidos(DateTime.Today.Month, DateTime.Today.Year);
            if(table is null)
            {
                return;
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DateTime fecha = Convert.ToDateTime(table.Rows[i]["Fecha"].ToString());
                CultureInfo provider = new CultureInfo("es-ES");
                string FechaFormateada = fecha.ToString("dd", provider) + "-" + 
                    fecha.ToString("MM", provider)+ "-" + fecha.ToString("yyyy", provider);
                CPedidos.VentaValidacion(Convert.ToInt32(table.Rows[i]["Id del Pedido"].ToString()));
                table.Rows[i]["Fecha"] = Convert.ToDateTime(FechaFormateada);
                DataRow ROW = table.Rows[i];
            }
            dgvPedidos.DataSource = table;

            gunaChart1.YAxes.GridLines.Display = false;

            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            dataset.Label = "Ingresos por días";
            
            table = CDetalleOrdenPedido.VentasMensuales(DateTime.Today.Month, DateTime.Today.Year);
            if(table is null)
            {
                guna2ShadowPanel1.Visible = false;
                guna2ShadowPanel2.Visible = false;
                return;
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dataset.DataPoints.Add(table.Rows[i]["Fecha"].ToString(), Convert.ToDouble(table.Rows[i]["Cantidad Vendida"].ToString()));
            }
            gunaChart1.Datasets.Clear();
            gunaChart1.Datasets.Add(dataset);

            gunaChart1.Update();


            gunaChart2.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            gunaChart2.XAxes.Display = false;
            gunaChart2.YAxes.Display = false;

            DataTable piv = new DataTable();
            var data = new Guna.Charts.WinForms.GunaPieDataset();
            gunaChart2.Datasets.Clear();
            try
            {
                piv = CDetalleOrdenPedido.VentasEstado(DateTime.Today.Month,
                DateTime.Today.Year, 1);
                double VentasSatisfechas = Convert.ToDouble(piv.Rows[0]["Cantidad Vendida"].ToString());
                data.DataPoints.Add("Ventas satisfechos", VentasSatisfechas);

                gunaChart2.Datasets.Add(data);

                gunaChart2.Update();
            }
            catch
            {
                
            }
            try
            {

                piv = CDetalleOrdenPedido.VentasEstado(DateTime.Today.Month,
                DateTime.Today.Year, 0);
                double VentasInsatisfechas = Convert.ToDouble(piv.Rows[0]["Cantidad Vendida"].ToString());
                data.DataPoints.Add("Pedidos insatisfechos", VentasInsatisfechas);

                gunaChart2.Datasets.Add(data);

                gunaChart2.Update();
            }
            catch
            {
               
            }
        }
    }
}
