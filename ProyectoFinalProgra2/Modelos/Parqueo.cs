using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra2.Modelos
{
    class Parqueo
    {
        public int id { get; set; }
        public int lugares { get; set; }
        public String nombre { get; set; }

        public Parqueo ()
        {
            id = 0;
            lugares = 0;
            nombre = String.Empty;
        }

        public Parqueo(int id, int lugares, String nombre)
        {
            id = id;
            lugares = lugares;
            nombre = nombre;
        }
    }
}
