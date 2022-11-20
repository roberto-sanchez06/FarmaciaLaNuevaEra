﻿using FarmaciaLaNuevaEra.Controller;
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
    public partial class FrmEspecificacionesVenta : Form
    {
        private int row;
        private int RowMedicamento;
        private List<int> Medicamentos;
        private DataTable Lista;
        public int idEmpleado;
        public FrmEspecificacionesVenta(int idEmpleado)
        {
            InitializeComponent();
            row = -1;
            Medicamentos = new List<int>();
            Lista = new DataTable();
            RowMedicamento = 0;
            this.idEmpleado = idEmpleado;
        }

        private void FrmEspecificacionesVenta_Load(object sender, EventArgs e)
        {
            Lista = CMedicamentos.MostrarMedicamentos(true);
            if (Lista is null)
                return;
            for(int i = 0; i < Lista.Rows.Count; i++)
            {
                dgvMedicamento.Rows.Add(Lista.Rows[i]["Id del Medicamento"].ToString(), Lista.Rows[i]["Medicamento"].ToString(),
                    Lista.Rows[i]["Laboratorio"].ToString(), Lista.Rows[i]["Cantidad en inventario"].ToString(),
                    Lista.Rows[i]["Precio a vender"].ToString());
            }
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            if(VerificarCantidad() && VerificarSeleccion())
            {
                Medicamentos.Add(Convert.ToInt32(dgvMedicamento.Rows[row].Cells[0].Value));
                Lista = CMedicamentos.MostrarMedicamentos(true);
                for (int i = 0; i < Lista.Rows.Count; i++)
                {
                    if(Lista.Rows[i]["Id del Medicamento"].ToString() == Medicamentos.Last().ToString())
                    {
                        dgvMedicamentoAñadidos.Rows.Add(Lista.Rows[i]["Medicamento"].ToString(),
                            txtPrecioDeCompra.Text.ToString());
                        break;
                    }
                }
                lblMedicamentos.Visible = true;
                dgvMedicamentoAñadidos.Visible = true;
                txtPrecioDeCompra.Text = null;
                row = -1;
                lblCantidadMedicamentos.Visible = false;
                txtPrecioDeCompra.Visible = false;
                return;
            }
        }

        private void dgvMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvMedicamento.CurrentCell.RowIndex;
            lblCantidadMedicamentos.Visible = true;
            txtPrecioDeCompra.Visible = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if(dgvMedicamentoAñadidos.Rows.Count > 0)
            {
                CPedidos.InsertarPedido(idEmpleado);
                Lista = CMedicamentos.MostrarMedicamentos(true);
                bool bandera = true;
                int index = 0,
                id = CPedidos.UltimoRegistro().Rows.Count > 0 ?
                    Convert.ToInt32(CPedidos.UltimoRegistro().Rows[0]["Id"].ToString()) : 0;
                while (bandera)
                {
                    for (int i = 0; i < Lista.Rows.Count; i++)
                    {
                        if (index > Medicamentos.Count - 1 || i == Lista.Rows.Count)
                        {
                            bandera = false;
                            break;
                        }
                        if (Lista.Rows[i]["Id del Medicamento"].ToString() == Medicamentos[index].ToString())
                        {
                            if (index > Medicamentos.Count)
                            {
                                bandera = false;
                                break;
                            }
                            CDetalleOrdenPedido.InsertarDetalleOrdenPedido(id,
                                Convert.ToInt32(Lista.Rows[i]["Id del Medicamento"].ToString()),
                                Convert.ToInt32(dgvMedicamentoAñadidos.Rows[index].Cells[1].Value.ToString()));
                            index++;
                        }
                    }
                }
                CDetalleOrdenPedido.ValidacionDetallesOrden(id);
                foreach (int Id in Medicamentos)
                {
                    CDetalleOrdenPedido.Venta(id, Id);
                }
                this.Close();
                return;
            }
            DialogResult result = MessageBox.Show("No se ha realizado la venta debido que no se ha seleccionado los medicamentos a vender." +
                " Desea cerrar esta pestaña?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)            
                this.Close(); 
        }

        private bool VerificarSeleccion()
        {
            if (row > -1)
            {
                return true;
            }
            MessageBox.Show("Para agregar una venta debe de seleccionar el medicamento.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private bool VerificarCantidad()
        {
            if (txtPrecioDeCompra.ToString() != null)
            {
                return true;
            }
            MessageBox.Show("Para agregar una venta debe de ingresar la cantidad de medicamento que se venderá",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void dgvMedicamentoAñadidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowMedicamento = dgvMedicamentoAñadidos.CurrentCell.RowIndex;
        }

        private void dgvMedicamentoAñadidos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvMedicamentoAñadidos.CurrentCell = dgvMedicamentoAñadidos.Rows[e.RowIndex].Cells[e.ColumnIndex];

                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Eliminar").Name = "Eliminar";

                menu.Show(dgvMedicamentoAñadidos, new Point(e.X, e.Y));
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuClick);
            }
        }
        private void menuClick(object sender, ToolStripItemClickedEventArgs e)
        {
            string id = e.ClickedItem.Name.ToString();
            if(id.Contains("Eliminar"))
            {
                Medicamentos.RemoveAt(RowMedicamento);
                dgvMedicamentoAñadidos.Rows.Remove(dgvMedicamentoAñadidos.Rows[RowMedicamento]);
            }
        }
    }
}
