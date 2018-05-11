using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra2.Modelos
{
    class ClassParqueo
    {
        public int id { get; set; }
        public int idCarro { get; set; }
        public int idParqueo { get; set; }

        public ClassParqueo (int idCarro, int idParqueo)
        {
            idCarro = idCarro;
            idParqueo = idParqueo;
        }
    }
}
