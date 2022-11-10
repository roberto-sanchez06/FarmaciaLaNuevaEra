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

        private void FrmPrincipal_Activated(object sender, EventArgs e)
        {
            this.NPMedicamentos.Text = CMedicamentos.CantidadMedicamentos().ToString();
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLaboratorio frmLaboratorio = new FrmLaboratorio();
            frmLaboratorio.ShowDialog();
            this.Show();

        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
           
        }

        private void IngresoDinero_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresoDinero money = new IngresoDinero();
            money.ShowDialog();
            this.Show();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Donacion  donacion = new Donacion();
            donacion.ShowDialog();
            this.Show();
        }
    }
}
