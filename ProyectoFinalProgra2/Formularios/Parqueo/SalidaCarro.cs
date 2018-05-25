using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalProgra2.Controladores;
using ProyectoFinalProgra2.Formularios;
using ProyectoFinalProgra2.Modelos;

namespace ProyectoFinalProgra2.Formularios.Parqueo
{
    public partial class frmSalidaCarro : Form
    {
        CarroControlador cc;
        ParqueoAutoControlador pac;
        public frmSalidaCarro()
        {
            cc = new CarroControlador();
            pac = new ParqueoAutoControlador();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtPlaca.Text = string.Empty;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update auto_parqueo set ocupado = 0, hora_salida = '"+ DateTime.Now.ToString("HH:mm:ss") + "'where fecha_entrada = '"+ DateTime.Now.ToString("yyyy-MM-dd") + "' and id_auto =";
            string queryFactura = "select (TIME_TO_SEC(TIMEDIFF(hora_salida, hora_entrada))/3600) * tarifa as total_facturar from auto_parqueo where fecha_entrada ='"+ DateTime.Now.ToString("yyyy-MM-dd") + "' and id_auto =";
            string placa = this.txtPlaca.Text.ToString();
            String verificarCarro = "SELECT * FROM automovil WHERE placa = '" + placa + "'";
            Carro c = cc.Obtener(verificarCarro);
            if(c.IdCarro == 0)
            {
                MessageBox.Show("Vehiculo no encontrado");

            } else
            {
                decimal monto = 0;
                query += c.IdCarro;
                queryFactura += c.IdCarro;

                pac.SalidaCarroParqueo(query);

                monto = pac.obtenerMontoFac(queryFactura);

                MessageBox.Show("Debe pagar " + monto);
            }
        }
    }
}
