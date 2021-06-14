using Entidades.Enumerados;
using Entidades.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arrabio : MateriaPrima, IMaterial
    {
        /// <summary>
        /// Constructor con todos los parametros de Arrabio
        /// </summary>
        /// <param name="proceso"></param>
        /// <param name="material"></param>
        /// <param name="origen"></param>
        /// <param name="cantidad"></param>
        /// <param name="calidad"></param>
        /// <param name="color"></param>
        public Arrabio(EProceso proceso, string material, string origen, int cantidad, ECalidad calidad, EColorMaterial color)
            : base(proceso, material, origen, cantidad, calidad, color)
        {
        }
        /// <summary>
        /// Sobreescritura del metodo ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Arrabio");
            sb.Append(base.ToString());
            sb.AppendLine($"La ganancia estimada es de {Ganancia}");
            return sb.ToString();
        }
        /// <summary>
        /// Sobreescritura del metodo Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Arrabio;
        }
        /// <summary>
        /// Calcula la ganancia del material dependiendo la cantidad de dicho material
        /// </summary>
        /// <returns></returns>
        public float CalcularGanancia()
        {
            float ganancia = 0;
            switch (this.Calidad)
            {
                case ECalidad.Malo:
                    {
                        ganancia = base.Cantidad * (float)0.7;
                        break;
                    }
                case ECalidad.Bueno:
                    {
                        ganancia = base.Cantidad * (float)0.8;
                        break;
                    }
                case ECalidad.Excelente:
                    {
                        ganancia = base.Cantidad * (float)0.9;
                        break;
                    }
            }
            return ganancia;
        }
        /// <summary>
        /// Retorna la ganancia calculada
        /// </summary>
        public override float Ganancia
        {
            get
            {
                return this.CalcularGanancia();
            }
        }
    }
}
