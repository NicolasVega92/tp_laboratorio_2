using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MensajeGuardarException : Exception
    {
        /// <summary>
        /// Excepcion que se arroja sin hubo algún problema al guardar los archivos
        /// </summary>
        /// <param name="mensajeExcepcion"></param>
        public MensajeGuardarException(string mensajeExcepcion)
            : base("Se produjo un error en la escritura del Archivo: " + mensajeExcepcion)
        {
        }
    }
}
