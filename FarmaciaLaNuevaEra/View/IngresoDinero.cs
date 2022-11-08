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
    public partial class IngresoDinero : Form
    {
        public IngresoDinero()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
                var monto = Convert.ToDecimal(guna2TextBox1.Text);
                var txt =  CEfectivo.Ingresar_Dinero(monto);

            if(txt == "OK")
            {
                MessageBox.Show("se han ingresado correctamento los C$" + guna2TextBox1.Text);
                guna2TextBox1.Clear();
            }
            else
            {
                MessageBox.Show("error en la transaccion");
            }
        }

        private void IngresoDinero_Load(object sender, EventArgs e)
        {

        }
    }
}
