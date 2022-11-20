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
    public partial class frmGraficos : Form
    {
        private DataTable table;
        public frmGraficos()
        {
            InitializeComponent();
        }

        private void frmGraficos_Load(object sender, EventArgs e)
        {

            gunaChart1.YAxes.GridLines.Display = false;

            var dataset = new Guna.Charts.WinForms.GunaBarDataset();
            dataset.Label = "Ingreso por día en el mes";

            table = CDetalleOrdenPedido.VentasMensuales(DateTime.Today.Month, DateTime.Today.Year);
            if (table is null)
            {   
                guna2ShadowPanel1.Visible = false;
            }
            else
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataset.DataPoints.Add("Día " + table.Rows[i]["Fecha"].ToString(), Convert.ToDouble(table.Rows[i]["Cantidad Vendida"].ToString()));
                }
                gunaChart1.Datasets.Clear();
                gunaChart1.Datasets.Add(dataset);

                gunaChart1.Update();
            }

            var DataTable = new Guna.Charts.WinForms.GunaLineDataset();
            DataTable.Label = "Ventas realizadas en el mes";
            gunaChart4.YAxes.Display = false;

            table = CDetalleOrdenPedido.VentasPorMeses(DateTime.Now.Year);
            if (table is null)
            {
                guna2ShadowPanel4.Visible = false;
            }
            else
            {
                DataTable.PointRadius = 10;
                DataTable.PointStyle = Guna.Charts.WinForms.PointStyle.Circle;

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataTable.DataPoints.Add(table.Rows[i]["Fecha"].ToString(), Convert.ToDouble(table.Rows[i]["Cantidad Vendida"].ToString()));
                }

                gunaChart4.Datasets.Clear();
                gunaChart4.Datasets.Add(DataTable);
                gunaChart4.Update();

            }

            var Table = new Guna.Charts.WinForms.GunaSteppedAreaDataset();
            Table.Label = "Ventas del mes por cada empleado";
            Table.FillColor = Color.OrangeRed;
            gunaChart3.YAxes.Display = false;
            table = CDetalleOrdenPedido.VentasEmpleado(DateTime.Today.Month, DateTime.Today.Year);

            if (table is null)
            {
                guna2ShadowPanel3.Visible = false;
            }
            else
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Table.DataPoints.Add(table.Rows[i]["Nombre"].ToString(), Convert.ToDouble(table.Rows[i]["Cantidad Vendida"].ToString()));
                }
                Table.PointRadius = 5;
                Table.PointFillColors = Guna.Charts.WinForms.ChartUtils.Colors(table.Rows.Count, Color.OrangeRed);
                Table.PointBorderColors = Table.PointFillColors;


                gunaChart3.Datasets.Clear();
                gunaChart3.Datasets.Add(Table);

                gunaChart3.Update();
            }

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

                    //gunaChart2.Update();
                    guna2ShadowPanel2.Visible = true;
                    lblPie.Visible = true;
                }

            }
            else
            {
                guna2ShadowPanel2.Visible = false;
                lblPie.Visible = false;
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

                    //gunaChart2.Update();
                    guna2ShadowPanel2.Visible = true;
                    lblPie.Visible = true;
                }
            }
            else
            {
                guna2ShadowPanel2.Visible = false;
                lblPie.Visible = false;
            }
        }
    }
}
