using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class MateriaPrima
    {
        #region Atributos
        private EProceso proceso;
        private string material;
        private string origen;
        private int cantidad;
        private ECalidad calidad;
        private EColorMaterial color;
        #endregion

        #region Propiedades
        public EProceso Proceso
        {
            get { return this.proceso; }
            set { this.proceso = value; }
        }
        public string Origen
        {
            get { return this.origen; }
            set { this.origen = value; }
        }
        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        public ECalidad Calidad
        {
            get { return this.calidad; }
            set { this.calidad = value; }
        }
        public EColorMaterial Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor de MateriaPrima
        /// </summary>
        /// <param name="proceso"></param>
        /// <param name="material"></param>
        /// <param name="origen"></param>
        /// <param name="cantidad"></param>
        /// <param name="calidad"></param>
        /// <param name="color"></param>
        protected MateriaPrima(EProceso proceso, string material, string origen, int cantidad, ECalidad calidad, EColorMaterial color)
        {
            this.cantidad = cantidad;
            this.calidad = calidad;
            this.color = color;
            this.proceso = proceso;
            this.material = material;
            this.origen = origen;
        }
        /// <summary>
        /// Sobreescritura del metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Proveniente de {Origen}");
            sb.AppendLine($"Cantidad: {Cantidad}");
            sb.AppendLine($"Calidad: {Calidad}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Su estado actual es: {Proceso}");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga de operador == comparando 2 materiaPrima
        /// </summary>
        /// <param name="materia1"></param>
        /// <param name="materia2"></param>
        /// <returns></returns>
        public static bool operator ==(MateriaPrima materia1, MateriaPrima materia2)
        {
            bool retorno = false;
            if( materia1.Equals(materia2)               && 
                materia1.Cantidad == materia2.Cantidad  &&
                materia1.Calidad == materia2.Calidad)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="materia1"></param>
        /// <param name="materia2"></param>
        /// <returns></returns>
        public static bool operator !=(MateriaPrima materia1, MateriaPrima materia2)
        {
            return !(materia1 == materia2);
        }

        #endregion

    }
}
