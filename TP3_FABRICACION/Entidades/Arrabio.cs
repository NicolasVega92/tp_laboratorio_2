using Entidades.Enumerados;
using Entidades.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arrabio : MateriaPrima, IMaterial<Arrabio>
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
        public float CalcularGanancia(Arrabio material)
        {
            float ganancia = 0;
            switch (material.Calidad)
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
        /// Retorna true si el material es de calidad Excelente
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public bool EsValioso(Arrabio material)
        {
            bool retorno = false;
            if (material.Calidad == ECalidad.Excelente)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
