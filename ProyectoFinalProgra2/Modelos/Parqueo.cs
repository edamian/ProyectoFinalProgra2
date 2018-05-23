using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra2.Modelos
{
    class Parqueo
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public Decimal Espacios { get; set; }

        public Parqueo ()
        {
            Id = 0;
            Tipo = 0;
            Espacios = 0;
        }

        public Parqueo(int id, int tipo, decimal espacios)
        {
            Id = id;
            Tipo = tipo;
            Espacios = espacios;
        }

        public Parqueo(int id, int tipo)
        {
            Tipo = id;
            Espacios = tipo;
        }
    }
}
