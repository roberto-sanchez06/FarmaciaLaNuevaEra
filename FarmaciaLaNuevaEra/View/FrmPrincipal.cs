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
        private string rol;
        private int idEmpleado;
        public void AgregarTooltips()
        {
            ToolTip toolTipMedicamentos = new ToolTip();
            toolTipMedicamentos.SetToolTip( this.btnMedicamentos, "Agregar o ver medicamentos");
            ToolTip toolTipPedidos = new ToolTip();
            toolTipPedidos.SetToolTip(this.btnPedidos, "Agregar o ver los pedidos");
            if (rol == "Administrador")
            {
                ToolTip tooltipEmpleados = new ToolTip();
                tooltipEmpleados.SetToolTip(this.btnEmpleados, "Agregar o ver empleados");
                ToolTip tooltipUsuarios = new ToolTip();
                tooltipEmpleados.SetToolTip(this.btnUsuarios, "Agregar o ver usuarios");
            }
        }
        public FrmPrincipal(string rol, int idEmpleado)
        {
            InitializeComponent();
            this.rol = rol;
            this.idEmpleado = idEmpleado;
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
            this.NPPedidos.Text = CPedidos.MostrarPedidos(DateTime.Now.Month, DateTime.Now.Year).Rows.Count.ToString();
            if (rol == "Administrador")
            {
                npEmpleados.Text = CEmpleado.CantidadEmpleados().ToString();
                npUsuarios.Text = CUsuario.CantidadUsuario().ToString();
                npEmpleados.Visible = true;
                npUsuarios.Visible = true;
            }
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
            this.Hide();
            FrmVentas frmVentas = new FrmVentas(idEmpleado);
            frmVentas.ShowDialog();
            this.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
            this.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.ShowDialog();
            this.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (rol == "Administrador")
            {
                btnUsuarios.Enabled = true;
                btnEmpleados.Enabled = true;
            }
            else
            {
                btnUsuarios.Enabled = false;
                btnEmpleados.Enabled = false;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void btnPedidos_Click(object sender, EventArgs e)
        //{
           
        //}

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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCompra compra = new frmCompra();
            compra.ShowDialog();
            this.Show();
        }
    }
}
