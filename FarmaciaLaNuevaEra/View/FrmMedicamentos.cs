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
    public partial class FrmMedicamentos : Form
    {
        public void AgregarTooltips()
        {
            ToolTip toolTipAgregarMedicamento = new ToolTip();
            toolTipAgregarMedicamento.SetToolTip(this.btnAgregarMedicamento, "Agregar medicamentos");
        }
        public FrmMedicamentos()
        {
            InitializeComponent();
            AgregarTooltips();
        }

        private void FrmMedicamentos_Load(object sender, EventArgs e)
        { 
            dgvMedicamentos.DataSource = CMedicamentos.MostrarMedicamentos();
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            FrmEspecificacionMedicamento frmEspecificacionMedicamento = new FrmEspecificacionMedicamento();
            frmEspecificacionMedicamento.ShowDialog();
            dgvMedicamentos.DataSource = CMedicamentos.MostrarMedicamentos();
;        }
    }
}
