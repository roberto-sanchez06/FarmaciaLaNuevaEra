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
    public partial class FrmEspecificacionMedicamento : Form
    {
        private int IdLaboratorio = -1;
        private int Cantidad;
        private bool Estado;
        private int Id;
        private bool Creacion;
        public void AgregarTooltips()
        {
            ToolTip toolTipAgregarLaboratorio = new ToolTip();
            toolTipAgregarLaboratorio.SetToolTip(this.btnAgregarLaboratorio, "Agregar laboratorio al medicamento");
        }
        public FrmEspecificacionMedicamento()
        {
            InitializeComponent();
            AgregarTooltips();
        }

        public FrmEspecificacionMedicamento(int idLaboratorio, int id,string nombre, decimal PrecioCompra, decimal PrecioVenta, int CantidadMinima, int cantidad,bool estado)
        {
            InitializeComponent();
            this.btnNombre.Text = nombre;
            this.txtPrecioDeVenta.Text = PrecioVenta.ToString();
            this.txtPrecioDeCompra.Text = PrecioCompra.ToString();
            this.txtStockMinimo.Text = CantidadMinima.ToString();
            this.Cantidad = cantidad;
            this.IdLaboratorio = idLaboratorio;
            this.Estado = estado;
            this.Id = id;
            btnAgregarLaboratorio.Text = "Actualizar";
            this.Creacion = false;
            AgregarTooltips();
        }
        #region txtNombre

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
        #endregion
        private void FrmEspecificacionMedicamento_Load(object sender, EventArgs e)
        {
            AsignarValidacionTXT();
        }
         #region Validación de txtStocks y Precios
        private void ValidarNumeroYPunto(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 57 || e.KeyChar < 48)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }
        private void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > 57 || e.KeyChar < 48)
            {
                if (e.KeyChar == 46)
                {
                    e.Handled = false;
                    return;
                }
                if (e.KeyChar == (char)8)
                {
                    e.Handled = false;
                    return;
                }
                e.Handled = true;
            }

        }
#endregion
        public void AsignarValidacionTXT()
        {
            this.txtStockMinimo.KeyPress += new KeyPressEventHandler(ValidarNumeroYPunto);
            this.txtPrecioDeCompra.KeyPress += new KeyPressEventHandler(ValidarNumero);
            this.txtPrecioDeVenta.KeyPress += new KeyPressEventHandler(ValidarNumero);
        }

        private void btnAgregarLaboratorio_Click(object sender, EventArgs e)
        {
            FrmMiniLaboratorio frmMiniLaboratorio = new FrmMiniLaboratorio();
            frmMiniLaboratorio.ShowDialog();
            if (frmMiniLaboratorio.IdLaboratorio != -1)
            {
                IdLaboratorio = frmMiniLaboratorio.IdLaboratorio;
                DataTable data = CLaboratorio.MostrarLaboratorio(IdLaboratorio);
                lblLaboratorio.Text = data.Columns[1].Table.Rows[0].ItemArray[1].ToString();       
            }

        }
        private bool VerificarFormulario()
        {
            if(string.IsNullOrEmpty(txtPrecioDeCompra.Text)|| string.IsNullOrEmpty(txtPrecioDeVenta.Text)|| string.IsNullOrEmpty(txtStockMinimo.Text))
            {
                return false;
            }
            return true;
        }
        private bool VerificarEleccionLaboratorio()
        {
            if (IdLaboratorio == -1)
            {
                
                return false;
            }
            return true;
        }
        private bool VerificarPrecioDeCompraYVenta()
        {
            try
            {
                decimal PrecioCompra = Convert.ToDecimal(txtPrecioDeCompra.Text);
                decimal PrecioVenta = Convert.ToDecimal(txtPrecioDeVenta.Text);
                if (PrecioVenta<=PrecioCompra)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void LimpiarFormulario()
        {
            txtPrecioDeCompra.Clear();
            txtPrecioDeVenta.Clear();
          
            txtStockMinimo.Clear();
            IdLaboratorio = -1;
        }
       private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            if (!VerificarFormulario())
            {
                MessageBox.Show("Rellene todo el formulario, por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!VerificarEleccionLaboratorio())
            {
                MessageBox.Show("Escoja un laboratorio, por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!VerificarPrecioDeCompraYVenta())
            {
                MessageBox.Show("El precio de compra no puede ser mayor que el precio de venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Creacion)
                CMedicamentos.InsertarMedicamento(IdLaboratorio, btnNombre.Text, Convert.ToDecimal(txtPrecioDeCompra.Text), Convert.ToDecimal(txtPrecioDeVenta.Text), 0, Convert.ToInt32(txtStockMinimo.Text));
            else
            {
                CMedicamentos.ActualizarMedicamento(Id, IdLaboratorio, btnNombre.Text, Convert.ToDecimal(txtPrecioDeCompra.Text), Convert.ToDecimal(txtPrecioDeVenta.Text), Cantidad, Convert.ToInt32(txtStockMinimo.Text), true);
                this.Close();
            }
               

            LimpiarFormulario();
        }
    }
}
