using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra2.Modelos
{
    class AutoParqueo
    {
        public int Id { get; set; }
        public int IdParqueo { get; set; }
        public String espacio { get; set; }
        public int IdAuto { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public Decimal Tarifa { get; set; }
    }
}
