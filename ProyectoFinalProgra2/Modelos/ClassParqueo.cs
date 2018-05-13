using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra2.Modelos
{
    class ClassParqueo
    {
        public int Id { get; set; }
        public int IdCarro { get; set; }
        public int IdParqueo { get; set; }

        public ClassParqueo (int idCarro, int idParqueo)
        {
            IdCarro = idCarro;
            IdParqueo = idParqueo;
        }
    }
}
