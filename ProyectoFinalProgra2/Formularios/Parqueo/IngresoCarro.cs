using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgra2.Formularios.Parqueo
{
    public partial class IngresoCarro : Form
    {
        public IngresoCarro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtPlaca.Text = String.Empty;
            this.Close();
        }

        private void btnIngresarParqueo_Click(object sender, EventArgs e)
        {
            String placa = this.txtPlaca.Text;

        }
    }
}
