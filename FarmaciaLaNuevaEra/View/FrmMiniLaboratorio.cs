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
    public partial class FrmMiniLaboratorio : Form
    {
        public int IdLaboratorio = -1;
        public FrmMiniLaboratorio()
        {
            InitializeComponent();
        }

        private void FrmMiniLaboratorio_Load(object sender, EventArgs e)
        {
            this.dgvLaboratorio.DataSource = CLaboratorio.MostrarLaboratorios(true);
        }

        private void dgvLaboratorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                IdLaboratorio = Convert.ToInt32(dgvLaboratorio.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
            

        }
    }
}
