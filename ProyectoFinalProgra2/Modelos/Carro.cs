using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra2.Modelos
{
    class Carro
    {
        public int idCarro { get; set; }
        public String placa { get; set; }

        public Carro ()
        {
            idCarro = 0;
            placa = String.Empty;
        }

        public Carro(int idCarro, String placa)
        {
            idCarro = idCarro;
            placa = placa;
        }

    }
}
