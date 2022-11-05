using FarmaciaLaNuevaEra.Controller;
using FarmaciaLaNuevaEra.Data;
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
    public partial class FrmLaboratorio : Form
    {
        public void AgregarTooltips()
        {
            ToolTip toolTipAgregarLaboratorio = new ToolTip();
            toolTipAgregarLaboratorio.SetToolTip(this.btnAgregarLaboratorio, "Agregar laboratorios");
        }
        public FrmLaboratorio()
        {
            InitializeComponent();
            AgregarTooltips();
        }

        private void btnAgregarLaboratorio_Click(object sender, EventArgs e)
        {
           
            FrmEspecificacionLaboratorio frmEspecificacionLaboratorio = new FrmEspecificacionLaboratorio(true);
            frmEspecificacionLaboratorio.Show();
            dgvLaboratorios.DataSource = CLaboratorio.MostrarLaboratorios(cmbTipoLaboratorio.SelectedIndex == 0 ? true : false);
        }

        private void FrmLaboratorio_Activated(object sender, EventArgs e)
        {
            dgvLaboratorios.DataSource = CLaboratorio.MostrarLaboratorios(cmbTipoLaboratorio.SelectedIndex==0 ? true : false);
        }

        private void dgvLaboratorios_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Actualizar"));
                if (cmbTipoLaboratorio.SelectedIndex == 0)
                {
                    m.MenuItems.Add(new MenuItem("Eliminar laboratorio"));
                    m.MenuItems[1].Click += MenuItemsEliminar_Click;
                }
                else
                {
                    m.MenuItems.Add(new MenuItem("Volver laboratorio"));
                    m.MenuItems[1].Click += MenuItemsVolver_Laboratorio;
                }
                int currentMouseOverRow = dgvLaboratorios.HitTest(e.X, e.Y).RowIndex;
                Dictionary<string, dynamic> Laboratorio = new Dictionary<string, dynamic>();
                Laboratorio.Add("Id", dgvLaboratorios.Rows[currentMouseOverRow].Cells[0].Value);
                Laboratorio.Add("Nombre", dgvLaboratorios.Rows[currentMouseOverRow].Cells[1].Value);
                m.MenuItems[1].Tag = Laboratorio;
                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dgvLaboratorios , new Point(e.X, e.Y));

            }
        }

        private void MenuItemsVolver_Laboratorio(object sender, EventArgs e)
        {
            MenuItem menuItem = (sender as MenuItem);
            Dictionary<string, dynamic> Laboratorio = (Dictionary<string, dynamic>)menuItem.Tag;

            int Id = Laboratorio["Id"];
                CLaboratorio.ActualizarLaboratorio(Id, Laboratorio["Nombre"], true);
         
           
                MessageBox.Show(Laboratorio["Nombre"] + " Se ha reestablecido");
            
            dgvLaboratorios.DataSource = CLaboratorio.MostrarLaboratorios(false);

        }

        private void MenuItemsEliminar_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = (sender as MenuItem);
            Dictionary<string, dynamic> Laboratorio =(Dictionary<string,dynamic>) menuItem.Tag;

            int Id = Laboratorio["Id"];
            CLaboratorio.ActualizarLaboratorio(Id, Laboratorio["Nombre"], false);
            MessageBox.Show(Laboratorio["Nombre"] + " Se ha eliminado");
            dgvLaboratorios.DataSource = CLaboratorio.MostrarLaboratorios(true);

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoLaboratorio.SelectedIndex == 0)
            {
                dgvLaboratorios.DataSource = CLaboratorio.MostrarLaboratorios(true);
            }
            else {
                dgvLaboratorios.DataSource = CLaboratorio.MostrarLaboratorios(false);
            }
        }
    }
}
