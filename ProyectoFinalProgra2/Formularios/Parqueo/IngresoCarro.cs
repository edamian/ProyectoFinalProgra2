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
        String nombreBoton = String.Empty;

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

        private void IngresoCarro_Load(object sender, EventArgs e)
        {
            //parqueo motos
            crearParqueo(3,7,this.panelMotos,"PM {0}","btn_moto_{0}{1}");
            //parqueo camiones
            crearParqueo(2, 7, this.panelCamiones, "PC {0}", "btn_camion_{0}{1}");
            //parqueo vehiculos
            crearParqueo(7, 5, this.panelVehiculos, "PV {0}", "btn_vehiculo_{0}{1}");
        }

        private void crearParqueo(int fila, int columna,  TableLayoutPanel panel, String texto, String nombre)
        {
            panel.ColumnCount = columna;
            panel.RowCount = fila;

            panel.ColumnStyles.Clear();
            panel.RowStyles.Clear();

            for(int i=0; i< columna; i++)
            {
                panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / columna));
            }

            for(int i= 0; i < fila; i++)
            {
                panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / fila));
            }
            int posicion = 0;
            for(int i =0; i<fila; i++)
            {
                
                for(int j=0; j< columna; j++)
                {
                    posicion++;
                    Button btnTemp = new Button();
                    btnTemp.Text = string.Format(texto, posicion);
                    btnTemp.Name = string.Format(nombre, i, j);
                    btnTemp.Click += obtenerParqueoBoton;
                    btnTemp.Dock = DockStyle.Fill;
                    panel.Controls.Add(btnTemp, j, i);
                }
            }

        }

        private void obtenerParqueoBoton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            nombreBoton = btn.Name;
            btn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button foundButton = this.Controls.Find(nombreBoton, true).FirstOrDefault() as Button;
            foundButton.Enabled = true;
        }
    }
}
