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
        private int cantidad;
        private string calidad;
        private EColorMaterial color;
        private EProceso proceso;
        #endregion

        #region Propiedades
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
        public EColorMaterial Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public EProceso Proceso
        {
            get { return this.proceso; }
            set { this.proceso = value; }
        }
        #endregion

        #region Metodos
        protected MateriaPrima(int cantidad, string calidad, EColorMaterial color, EProceso proceso)
        {
            this.cantidad = cantidad;
            this.calidad = calidad;
            this.color = color;
            this.proceso = proceso;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad: {Cantidad}");
            sb.AppendLine($"Calidad: {Calidad}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Su estado actual es: {Proceso}");
            return sb.ToString();
        }
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
        public static bool operator !=(MateriaPrima materia1, MateriaPrima materia2)
        {
            return !(materia1 == materia2);
        }
        #endregion

    }
}
