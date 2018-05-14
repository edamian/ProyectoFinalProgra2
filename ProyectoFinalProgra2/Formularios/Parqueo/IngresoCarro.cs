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
            Conexion conexion = new Conexion();

            //Si carro ya existe

            // si no crear carro y obtener id

            //insertar registro en parqueo_espacio

            String placa = this.txtPlaca.Text;
            int tipo = 0;
            switch(cboxTipoVehiculo.SelectedItem.ToString())
            {
                case "Motocicleta":
                    tipo = 1;
                    break;
                case "Camion":
                    tipo = 2;
                    break;
                case "Vehiculo":
                    tipo = 3;
                    break;
            }

            String query = "INSERT INTO automovil (placa,tipo) VALUES ('"+ placa +"',"+tipo+")";
            conexion.insertar(query);
        }

        private void IngresoCarro_Load(object sender, EventArgs e)
        {
            //parqueo motos
            crearParqueo(3,7,this.panelMotos,"PM {0}","btn_moto_1_{0}{1}");
            //parqueo camiones
            crearParqueo(2, 7, this.panelCamiones, "PC {0}", "btn_camion_2_{0}{1}");
            //parqueo vehiculos
            crearParqueo(7, 5, this.panelVehiculos, "PV {0}", "btn_vehiculo_3_{0}{1}");
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

            panel.MaximumSize = new Size(panel.Width, panel.Height);
            panel.AutoScroll = true;

        }

        private void obtenerParqueoBoton(object sender, EventArgs e)
        {
            if(nombreBoton.Equals(String.Empty))
            {
                Button btn = (Button)sender;
                nombreBoton = btn.Name;
                String[] splitNombre = btn.Name.Split('_');
                
               foreach(var item in splitNombre)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                Console.WriteLine(splitNombre[2]);
                btn.Enabled = false;

            } else
            {
                MessageBox.Show("Debe liberar el espacio antes de seleccionar otro!","Alerta");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!nombreBoton.Equals(String.Empty))
            {
                Button foundButton = this.Controls.Find(nombreBoton, true).FirstOrDefault() as Button;
                nombreBoton = String.Empty;
                foundButton.Enabled = true;
            }
        }
    }
}
