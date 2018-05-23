using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProgra2.Controladores
{
    public interface ICrud<T>
    {
        long Insertar(String query);
        void Actualizar(String query);
        void Borrar(String query);
        T Obtener(String query);
        List<T> Listar(String query);
    }
}
