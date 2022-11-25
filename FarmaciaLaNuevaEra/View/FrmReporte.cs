using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 //using Microsoft.Reporting.WinForms;

namespace FarmaciaLaNuevaEra.View
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }
        Dictionary<int, string> Meses = new Dictionary<int, string>();
        private void MesesDictionary()
        {
            Meses.Add(1, "Enero");
            Meses.Add(2, "Febrero");
            Meses.Add(3, "Marzo");
            Meses.Add(4, "Abril");
            Meses.Add(5, "Mayo");
            Meses.Add(6, "Junio");
            Meses.Add(7, "Julio");
            Meses.Add(8, "Agosto");
            Meses.Add(9, "Septiembre");
            Meses.Add(10, "Octubre");
            Meses.Add(11, "Noviembre");
            Meses.Add(12, "Diciembre");


        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            this.mostrarMesesTableAdapter.Fill(this.estadosFinancieros.MostrarMeses);

            MesesDictionary();
            this.dgvMes.DataSource = this.estadosFinancieros.MostrarMeses;
          
        }

        private void informeEgresoYIngresoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvMes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMes_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dgvMes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int age = (int)this.dgvMes.Rows[e.RowIndex].Cells[0].Value;
                int month= (int)this.dgvMes.Rows[e.RowIndex].Cells[1].Value;
                DateTime fecha = new DateTime(age, month, DateTime.Now.Day);
                this.informeEstadoResultadoTableAdapter.Fill(this.estadosFinancieros.InformeEstadoResultado, fecha);
                //ReportParameterCollection reportsFecha = new ReportParameterCollection();
                //reportsFecha.Add(new ReportParameter("Fecha", Meses[fecha.Month] + " del " + fecha.Year.ToString()));
                //reportViewer1.LocalReport.SetParameters(reportsFecha);
                //this.dgvMes.DataSource = this.mostrarMesesBindingSource.DataSource;
                this.informeBalanceGeneralActivoTableAdapter.Fill(this.estadosFinancieros.InformeBalanceGeneralActivo, fecha);
                this.informeBalanceGeneralCapitalTableAdapter.Fill(this.estadosFinancieros.InformeBalanceGeneralCapital, fecha);

                this.informeEgresoYIngresoTableAdapter.Fill(this.estadosFinancieros.InformeEgresoYIngreso, fecha);
               
                var setup = reportViewer1.GetPageSettings();
                setup.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
                reportViewer1.SetPageSettings(setup);
               
                this.razonesFinancieras1TableAdapter1.Fill(this.estadosFinancieros.RazonesFinancieras1, fecha);
                this.reportViewer1.RefreshReport();

            }
        }
    }
}
