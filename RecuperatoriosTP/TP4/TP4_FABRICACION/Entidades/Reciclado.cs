using Entidades.Enumerados;
using Entidades.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reciclado : MateriaPrima, IMaterial<Reciclado>
    {
        public Reciclado()
        {

        }
        /// <summary>
        /// Constructor de Reciclado con todos los parametros
        /// </summary>
        /// <param name="proceso"></param>
        /// <param name="material"></param>
        /// <param name="origen"></param>
        /// <param name="cantidad"></param>
        /// <param name="calidad"></param>
        /// <param name="color"></param>
        public Reciclado(int id, string proceso, string material, string origen, int cantidad, string calidad, string color)
            : base(id, proceso, material, origen, cantidad, calidad, color)
        {
        }
        /// <summary>
        /// Sobreescritura del metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Material Reciclado");
            sb.Append(base.ToString());
            return sb.ToString();
        }
        /// <summary>
        /// Sobreescritura del metodo Equals()
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Reciclado;    
        }
        /// <summary>
        /// Calcula la ganancia dependiendo la cantidad de dicho material
        /// </summary>
        /// <returns></returns>
        public float CalcularGanancia(Reciclado material)
        {
            float ganancia = 0;
            switch(material.Calidad)
            {
                case "Malo":
                    {
                        ganancia = base.Cantidad * (float)0.6;
                        break;
                    }
                case "Bueno":
                    {
                        ganancia = base.Cantidad * (float)0.7;
                        break;
                    }
                case "Excelente":
                    {
                        ganancia = base.Cantidad * (float)0.8;
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
        public bool EsValioso(Reciclado material)
        {
            bool retorno = false;
            if(material.Calidad == "Excelente")
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
