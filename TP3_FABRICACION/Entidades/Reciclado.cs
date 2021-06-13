using Entidades.Enumerados;
using Entidades.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reciclado : MateriaPrima, IMaterial
    {
        private string basuralOrigen;

        public Reciclado(int cantidad, ECalidad calidad, EColorMaterial color, EProceso proceso) 
            : this("SIN REFERENCIA", cantidad, calidad, color, proceso)
        {
        }
        public Reciclado(string basuralOrigen, int cantidad, ECalidad calidad, EColorMaterial color, EProceso proceso)
            : base(cantidad, calidad, color, proceso)
        {
            this.basuralOrigen = basuralOrigen;
        }

        public string BasuralOrigen
        {
            get { return this.basuralOrigen; }
            set { this.basuralOrigen = value; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Material Reciclado");
            sb.AppendLine($"Basural proveniente = {BasuralOrigen}");
            sb.Append(base.ToString());
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Reciclado;    
        }
    }
}
