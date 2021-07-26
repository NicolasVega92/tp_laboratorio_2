using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SqlMensajeExcepcion : Exception
    {
        /// <summary>
        /// Excepcion que se arroja si hubo algún problema en la carga de la Base de Datos
        /// </summary>
        /// <param name="message"></param>
        public SqlMensajeExcepcion(string message) 
            : base(message)
        {
        }
    }
}
