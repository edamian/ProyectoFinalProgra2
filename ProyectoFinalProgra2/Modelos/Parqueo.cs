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
        public int Lugares { get; set; }
        public String Nombre { get; set; }

        public Parqueo ()
        {
            Id = 0;
            Lugares = 0;
            Nombre = String.Empty;
        }

        public Parqueo(int id, int lugares, String nombre)
        {
            Id = id;
            Lugares = lugares;
            Nombre = nombre;
        }
    }
}
