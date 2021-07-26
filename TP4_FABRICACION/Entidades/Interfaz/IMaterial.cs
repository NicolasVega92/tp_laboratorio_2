using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaz
{
    interface IMaterial<T>
    {
        float CalcularGanancia(T material);
        bool EsValioso(T material);
    }
}
