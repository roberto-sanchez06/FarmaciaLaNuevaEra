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
    public partial class FrmPrincipal : Form
    {

        public void AgregarTooltips()
        {
            ToolTip toolTipMedicamentos = new ToolTip();
            toolTipMedicamentos.SetToolTip( this.btnMedicamentos, "Agregar o ver medicamentos");
        }
        public FrmPrincipal()
        {
            InitializeComponent();
            AgregarTooltips();
            
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMedicamentos frmMedicamentos = new FrmMedicamentos();
            frmMedicamentos.ShowDialog();
           
            this.Show();
                
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.guna2NotificationPaint1.Text = CMedicamentos.CantidadMedicamentos().ToString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmVentas frmVentas = new FrmVentas();
            frmVentas.ShowDialog();

            this.Show();
        }
    }
}
