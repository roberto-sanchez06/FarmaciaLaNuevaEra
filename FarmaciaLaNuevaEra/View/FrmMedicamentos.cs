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
            dgvMedicamentos.DataSource = CMedicamentos.MostrarMedicamentos(true);
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            FrmEspecificacionMedicamento frmEspecificacionMedicamento = new FrmEspecificacionMedicamento();
            frmEspecificacionMedicamento.ShowDialog();
            dgvMedicamentos.DataSource = CMedicamentos.MostrarMedicamentos(cmbTipoMedicamento.SelectedIndex==0 ? true : false);
;        }
        private void dgvMedicamentos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvMedicamentos.HitTest(e.X, e.Y).RowIndex;
                Dictionary<string, dynamic> Medicamento = new Dictionary<string, dynamic>();
                Medicamento.Add("Id", dgvMedicamentos.Rows[currentMouseOverRow].Cells[0].Value);
                Medicamento.Add("IdLaboratorio", dgvMedicamentos.Rows[currentMouseOverRow].Cells[2].Value);
                Medicamento.Add("Nombre", dgvMedicamentos.Rows[currentMouseOverRow].Cells[3].Value);
                Medicamento.Add("PrecioComprado", dgvMedicamentos.Rows[currentMouseOverRow].Cells[4].Value);
                Medicamento.Add("PrecioVendido", dgvMedicamentos.Rows[currentMouseOverRow].Cells[5].Value);
                Medicamento.Add("CantidadInventario", dgvMedicamentos.Rows[currentMouseOverRow].Cells[6].Value);
                Medicamento.Add("CantidadMinima", dgvMedicamentos.Rows[currentMouseOverRow].Cells[7].Value);
                ContextMenu m = new ContextMenu();
                if (cmbTipoMedicamento.SelectedIndex == 0)
                {
                    m.MenuItems.Add(new MenuItem("Actualizar"));
                    m.MenuItems[0].Click += MenuItemsActualizar_Medicamento;
                    m.MenuItems[0].Tag = Medicamento;
                }
               
                if (cmbTipoMedicamento.SelectedIndex == 0)
                {
                    m.MenuItems.Add(new MenuItem("Eliminar medicamento"));
                    m.MenuItems[1].Click += MenuItemsEliminar_Click;
                    m.MenuItems[1].Tag = Medicamento;
                }
                else
                {
                    m.MenuItems.Add(new MenuItem("Volver medicamento"));
                    m.MenuItems[0].Click += MenuItemsVolver_Medicamento;
                    m.MenuItems[0].Tag = Medicamento;
                }
               
       

                m.Show(dgvMedicamentos, new Point(e.X, e.Y));

            }
        }
        private void MenuItemsActualizar_Medicamento(object sender, EventArgs e)
        {
            MenuItem menuItem = (sender as MenuItem);
            Dictionary<string, dynamic> Medicamento = (Dictionary<string, dynamic>)menuItem.Tag;
            int Id = Medicamento["Id"];
            int IdLaboratorio = Medicamento["IdLaboratorio"];
            FrmEspecificacionMedicamento frmEspecificacionMedicamento = 
           new FrmEspecificacionMedicamento(IdLaboratorio, Id, Medicamento["Nombre"], Medicamento["PrecioComprado"], Medicamento["PrecioVendido"],  Medicamento["CantidadMinima"],Medicamento["CantidadInventario"],true);
            frmEspecificacionMedicamento.ShowDialog();
            dgvMedicamentos.DataSource = CMedicamentos.MostrarMedicamentos(true);
        }


        private void MenuItemsVolver_Medicamento(object sender, EventArgs e)
        {
            MenuItem menuItem = (sender as MenuItem);
            Dictionary<string, dynamic> Medicamento = (Dictionary<string, dynamic>)menuItem.Tag;
            int Id = Medicamento["Id"];
            int IdLaboratorio = Medicamento["IdLaboratorio"];
           string Respuesta= CMedicamentos.ActualizarMedicamento(Id, IdLaboratorio, Medicamento["Nombre"], Medicamento["PrecioComprado"], Medicamento["PrecioVendido"], Medicamento["CantidadInventario"], Medicamento["CantidadMinima"], true);
            if (Respuesta.Contains("Laboratorio"))
            {
                MessageBox.Show("Laboratorio se encuentra eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Medicamento["Nombre"] + " se ha reestablecido");

            }
            dgvMedicamentos.DataSource = CMedicamentos.MostrarMedicamentos(false);
        }

        private void MenuItemsEliminar_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = (sender as MenuItem);
            Dictionary<string, dynamic> Medicamento = (Dictionary<string, dynamic>)menuItem.Tag;
            int Id = Medicamento["Id"];
            int IdLaboratorio = Medicamento["IdLaboratorio"];
            CMedicamentos.ActualizarMedicamento(Id, IdLaboratorio,Medicamento["Nombre"], Medicamento["PrecioComprado"], Medicamento["PrecioVendido"], Medicamento["CantidadInventario"], Medicamento["CantidadMinima"], false);
            MessageBox.Show(Medicamento["Nombre"] + " se ha eliminado");
            dgvMedicamentos.DataSource = CMedicamentos.MostrarMedicamentos(true);
        }

        private void cmbTipoMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMedicamento.SelectedIndex == 0)
            {
                dgvMedicamentos.DataSource = CMedicamentos.MostrarMedicamentos(true);
            }
            else
            {
                dgvMedicamentos.DataSource = CMedicamentos.MostrarMedicamentos(false);
            }
        }
    }
}
