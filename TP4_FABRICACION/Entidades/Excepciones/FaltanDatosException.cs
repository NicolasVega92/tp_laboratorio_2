using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FaltanDatosException : Exception
    {
        /// <summary>
        /// Excepcion que se arroja al intentar guardar un Material sin todos sus datos completos
        /// </summary>
        /// <param name="message"></param>
        public FaltanDatosException(string message) 
            : base(message)
        {
        }
    }
}
