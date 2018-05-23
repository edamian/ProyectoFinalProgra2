using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProyectoFinalProgra2.Modelos;

namespace ProyectoFinalProgra2.Controladores
{
    class CarroControlador : ICrud<Carro>
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

        public List<Carro> Listar(string query)
        {
            throw new NotImplementedException();
        }

        public Carro Obtener(string query)
        {
            Carro tmp = new Carro();
            if(conexion.abrirCon())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion.obtenerConexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    tmp.IdCarro = reader.GetInt32("id");
                    tmp.Placa = reader.GetString("placa");
                }
            }
            return tmp;
        }

    }
}
