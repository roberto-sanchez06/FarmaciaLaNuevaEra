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
    public partial class FrmEspecificacionMedicamento : Form
    {
        public void AgregarTooltips()
        {
            ToolTip toolTipAgregarLaboratorio = new ToolTip();
            toolTipAgregarLaboratorio.SetToolTip(this.btnAgregarLaboratorio, "Agregar laboratorio al medicamento");
        }
        public FrmEspecificacionMedicamento()
        {
            InitializeComponent();
        }

        private void btnNombre_TextChanged(object sender, EventArgs e)
        {
            if (btnNombre.Text.Length >= 30)
            {
                lblCantidadDeLetras.ForeColor = Color.Red;
            }
            else
            {
                lblCantidadDeLetras.ForeColor = Color.FromArgb(64, 64, 64);
            }
            
            lblCantidadDeLetras.Text = btnNombre.Text.Length + "/30";
        }

       
    }
}
