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
    public partial class AgregarParqueo : Form
    {
        public AgregarParqueo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtNombreParqueo.Text = String.Empty;
            this.txtNumLugares.Text = String.Empty;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nombre = this.txtNombreParqueo.Text;
            int numLugares = int.Parse(this.txtNumLugares.Text);

            //Llamada a DB
            /*
             try {
                msgbox ("guardado")
            } catch (Exception) {
                msgbox ("error")            
            }
             */
        }
    }
}
