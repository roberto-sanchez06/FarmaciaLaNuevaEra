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
    public partial class Donacion : Form
    {
        public Donacion()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var monto = Convert.ToDecimal(txtDonacion.Text);
            var txt = CEfectivo.Donaciones(monto);

            if (txt == "OK")
            {
                MessageBox.Show("se han ingresado correctamento los C$" + txtDonacion.Text + "de la donacion.");
                txtDonacion.Clear();
            }
            else
            {
                MessageBox.Show("error en la transaccion");
            }
        }
    }
}
