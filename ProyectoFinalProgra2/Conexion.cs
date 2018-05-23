using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoFinalProgra2
{
    class Conexion
    {
        private MySqlConnection conexion;
        private String host;
        private String bd;
        private String uid;
        private String pass;

        public Conexion()
        {
            Init();
        }

        private void Init()
        {
            host = "localhost";
            bd = "parqueo_umg";
            uid = "root";
            pass = "";

            String cadenaCon = "SERVER=" + host + ";DATABASE=" + bd +";UID="+uid+";PASSWORD="+pass+";";

            conexion = new MySqlConnection(cadenaCon);
        }

        public bool abrirCon()
        {
            try
            {
                conexion.Open();
                return true;
            } catch (MySqlException ex)
            {
                switch(ex.Number)
                {
                    case 0:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                    case 1045:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                }
                return false;
            }
        }

        public bool cerrarCon()
        {
            try
            {
                conexion.Close();
                return true;
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public MySqlConnection obtenerConexion()
        {
            return this.conexion;
        }
    }
}
