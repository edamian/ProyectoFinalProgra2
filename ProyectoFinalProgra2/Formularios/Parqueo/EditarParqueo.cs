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
    public partial class EditarParqueo : Form
    {
        public EditarParqueo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtBusqueda.Text = String.Empty;
            this.txtLugares.Text = String.Empty;
            this.txtNombre.Text = String.Empty;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String valor = this.txtBusqueda.Text;
            String nombre = this.txtNombre.Text;
            int numLugares = int.Parse(this.txtLugares.Text);
        }
    }
}
