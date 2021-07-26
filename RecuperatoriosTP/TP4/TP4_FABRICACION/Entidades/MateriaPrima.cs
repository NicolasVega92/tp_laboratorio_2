using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class MateriaPrima
    {
        #region Atributos
        private int id;
        private string material;
        private string proceso;
        private string origen;
        private int cantidad;
        private string calidad;
        private string color;
        #endregion

        #region Propiedades
        public int Id
        {
            get { return this.id; }
            set{ this.id = value; }
        }
        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }
        public string Proceso
        {
            get { return this.proceso; }
            set { this.proceso = value; }
        }
        public string Origen
        {
            get { return this.origen; }
            set { this.origen = value; }
        }
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }
        public string Calidad
        {
            get { return this.calidad; }
            set { this.calidad = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        #endregion

        #region Metodos
        public MateriaPrima()
        {

        }
        /// <summary>
        /// Constructor de MateriaPrima
        /// </summary>
        /// <param name="proceso"></param>
        /// <param name="material"></param>
        /// <param name="origen"></param>
        /// <param name="cantidad"></param>
        /// <param name="calidad"></param>
        /// <param name="color"></param>
        protected MateriaPrima(int id, string proceso, string material, string origen, int cantidad, string calidad, string color)
        {
            this.id = id;
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
        /// <summary>
        /// Calcula las ganancias de los materiales diferenciando su tipo y calidad
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public float CalcularGanancia(MateriaPrima material)
        {
            float ganancia = 0;
            if (material is Arrabio)
            {
                switch (material.Calidad)
                {
                    case "Malo":
                        {
                            ganancia = Cantidad * (float)0.7;
                            break;
                        }
                    case "Bueno":
                        {
                            ganancia = Cantidad * (float)0.8;
                            break;
                        }
                    case "Excelente":
                        {
                            ganancia = Cantidad * (float)0.9;
                            break;
                        }
                }
            }
            else
            {
                switch (material.Calidad)
                {
                    case "Malo":
                        {
                            ganancia = Cantidad * (float)0.6;
                            break;
                        }
                    case "Bueno":
                        {
                            ganancia = Cantidad * (float)0.7;
                            break;
                        }
                    case "Excelente":
                        {
                            ganancia = Cantidad * (float)0.8;
                            break;
                        }
                }
            }
            return ganancia;
        }
        /// <summary>
        /// Identifica si un material esta en el proceso de Finalizado
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public static bool Finalizar(MateriaPrima material)
        {
            bool retorno = false;
            if (material.Proceso == "Finalizado")
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

    }
}
