using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinalProgra2.Modelos;
using MySql.Data.MySqlClient;

namespace ProyectoFinalProgra2.Controladores
{
    class ParqueoAutoControlador : ICrud<AutoParqueo>
    {
        Conexion conexion = new Conexion();

        public void Actualizar(string query)
        {
            throw new NotImplementedException();
        }

        public void Borrar(string query)
        {
            throw new NotImplementedException();
        }

        public long Insertar(string query)
        {
            long id = 0;

            if(conexion.abrirCon())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion.obtenerConexion());
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
                conexion.cerrarCon();
            }
            return id;
        }

        public List<AutoParqueo> Listar(string query)
        {
            throw new NotImplementedException();
        }

        public AutoParqueo Obtener(string query)
        {
            throw new NotImplementedException();
        }


        public List<String> ObtenerParqueosOcupados(String query)
        {
            List<String> lista = new List<string>();
            if (conexion.abrirCon())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion.obtenerConexion());
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lista.Add(r.GetString(0));
                }
                r.Close();
            }
            return lista;
        }

        public bool SalidaCarroParqueo(String query)
        {
            bool sale = true;
            if(conexion.abrirCon())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexion.obtenerConexion());
                    cmd.ExecuteNonQuery();
                    conexion.cerrarCon();

                } catch (MySqlException ex)
                {
                    sale = false;
                    Console.WriteLine(ex.Message);
                }
            }
            return sale;
        }
    }
}
