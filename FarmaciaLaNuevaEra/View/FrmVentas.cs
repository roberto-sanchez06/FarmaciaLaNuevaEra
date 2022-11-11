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
        public int idEmpleado;
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
            frmEspecificacionesVenta.idEmpleado = idEmpleado;
        }

        private void FrmVentas_Activated(object sender, EventArgs e)
        {
            table = CPedidos.MostrarPedidos(DateTime.Today.Month, DateTime.Today.Year);
            if(table is null)
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
                    fecha.ToString("MM", provider)+ "-" + fecha.ToString("yyyy", provider);
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
            DataRow dr;

            gunaChart2.Datasets.Clear();

            piv = CDetalleOrdenPedido.VentasEstado(DateTime.Today.Month,
                DateTime.Today.Year, 1);
            if (!(piv is null))
            {
                dr = piv.Rows[0];
                if (!(dr.ItemArray[0].ToString() == ""))
                {
                    double VentasSatisfechas = Convert.ToDouble(piv.Rows[0]["Cantidad Vendida"].ToString());
                    data.DataPoints.Add("Ventas satisfechos del mes", VentasSatisfechas);

                    gunaChart2.Datasets.Add(data);

                    gunaChart2.Update();
                }

            }
            piv = CDetalleOrdenPedido.VentasEstado(DateTime.Today.Month,
                DateTime.Today.Year, 0);
            if (!(piv is null))
            {
                dr = piv.Rows[0];
                if (!(dr.ItemArray[0].ToString() == ""))
                {
                    double VentasInsatisfechas = Convert.ToDouble(piv.Rows[0]["Cantidad Vendida"].ToString());
                    data.DataPoints.Add("Ventas insatisfechos del mes", VentasInsatisfechas);

                    gunaChart2.Datasets.Add(data);

                    gunaChart2.Update();
                }
            }
        }
    }
}
