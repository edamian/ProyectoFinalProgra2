using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoFinalProgra2.Controladores;
using ProyectoFinalProgra2.Modelos;

namespace ProyectoFinalProgra2.Formularios.Parqueo
{
    public partial class IngresoCarro : Form
    {
        String nombreBoton = String.Empty;
        int idParqueo = 0;
        CarroControlador cc = new CarroControlador();
        ParqueoAutoControlador pac = new ParqueoAutoControlador();
        String obtenerParqueos = "SELECT espacio FROM auto_parqueo WHERE fecha_entrada = '2018-05-16'";
        List<String> listaParqueosOcupados = null;
        public IngresoCarro()
        {
            InitializeComponent();
            listaParqueosOcupados = pac.ObtenerParqueosOcupados(obtenerParqueos);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtPlaca.Text = String.Empty;
            this.Close();
        }

        private void btnIngresarParqueo_Click(object sender, EventArgs e)
        {
            String placa = this.txtPlaca.Text;
            int tipo = 0;
            long idCarroDB = 0 ;
            
            String espacioEstacionamiento = nombreBoton;

            switch (cboxTipoVehiculo.SelectedItem.ToString())
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
                default :
                    tipo = 0;
                    break;
            }

            //queries
            String verificarCarro = "SELECT * FROM automovil WHERE placa = '" + placa + "'";
            String nuevoCarro = "INSERT INTO automovil (placa,tipo) VALUES ('" + placa + "'," + tipo + ")";
            
            Carro carro = cc.Obtener(verificarCarro);
            String insertarEspacioParqueo = String.Empty;
             if (carro.IdCarro == 0)
            {
                idCarroDB = cc.Insertar(nuevoCarro);
                insertarEspacioParqueo = "INSERT INTO auto_parqueo(id_parqueo,espacio,id_auto,fecha_entrada,hora_entrada,hora_salida,tarifa,ocupado) " +
                " VALUES (" + idParqueo + ",'" + nombreBoton + "'," + idCarroDB + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss")+ "',null,1.5,1)";
            } else
            {
                insertarEspacioParqueo = "INSERT INTO auto_parqueo(id_parqueo,espacio,id_auto,fecha_entrada,hora_entrada,hora_salida,tarifa,ocupado) " +
                " VALUES (" + idParqueo + ",'" + nombreBoton + "'," + carro.IdCarro + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm:ss") + "',null,1.5,1)";
            }
            Console.WriteLine(insertarEspacioParqueo);
           pac.Insertar(insertarEspacioParqueo);
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
                    btnTemp.Name = string.Format(nombre, i, j);
                    btnTemp.Text = string.Format(texto, posicion);
                    btnTemp.Enabled = this.estaOcupado(string.Format(nombre, i, j));
                    btnTemp.Click += obtenerParqueoBoton;
                    btnTemp.Dock = DockStyle.Fill;
                    panel.Controls.Add(btnTemp, j, i);
                }
            }

            panel.MaximumSize = new Size(panel.Width, panel.Height);
            panel.AutoScroll = true;

        }

        private bool estaOcupado(String valor)
        {
            bool restultado = true;
            foreach (String val in listaParqueosOcupados)
            {
                if (val.Equals(valor))
                {
                    restultado = false;
                    //return false;
                    //esOcupado = false;
                }
            }
            return restultado;
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

                idParqueo = int.Parse(splitNombre[2]);
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
                idParqueo = 0;
                foundButton.Enabled = true;
            }
        }
    }
}
