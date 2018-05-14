using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra2.Modelos
{
    class Carro
    {
        public int IdCarro { get; set; }
        public String Placa { get; set; }

        public Carro ()
        {
            IdCarro = 0;
            Placa = String.Empty;
        }

        public Carro(int idCarro, String placa)
        {
            IdCarro = idCarro;
            Placa = placa;
        }

        public Carro(String placa)
        {
            Placa = placa;
        }
    }
}
