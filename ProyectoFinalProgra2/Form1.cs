using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalProgra2.Formularios.Parqueo;

namespace ProyectoFinalProgra2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void parqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearParqueoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarParqueo ap = new AgregarParqueo();
            ap.Show();
        }

        private void ingresoCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoCarro ic = new IngresoCarro();
            ic.Show();
        }
    }
}
