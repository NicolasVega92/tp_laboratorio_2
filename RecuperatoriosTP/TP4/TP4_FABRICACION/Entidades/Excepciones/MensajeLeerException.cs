using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MensajeLeerException : Exception
    {
        /// <summary>
        /// Excepcion que se arroja sin hubo algún problema al cargar los archivos
        /// </summary>
        /// <param name="mensajeExcepcion"></param>
        public MensajeLeerException(string mensajeExcepcion)
            : base("Se produjo un error en la lectura del Archivo: " + mensajeExcepcion)
        {
        }
    }
}
