using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TheadNullExcepcion : Exception
    {
        /// <summary>
        /// No llegue a implementarla
        /// </summary>
        /// <param name="message"></param>
        public TheadNullExcepcion(string message) 
            : base(message)
        {
        }
    }
}
