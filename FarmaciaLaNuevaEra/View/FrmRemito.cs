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
    public partial class FrmRemito : Form
    {
        public FrmRemito()
        {
            InitializeComponent();
        }

        private void btnagregarordenpedido_Click(object sender, EventArgs e)
        {
            dgvOrdenes.DataSource = CRemito.MostrarOrdenCompra();
            dgvOrdenes.Visible = true;
        }

        private void dgvOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
