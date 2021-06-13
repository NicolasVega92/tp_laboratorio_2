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
        private string empresaOrigen;

        public Arrabio(int cantidad, ECalidad calidad, EColorMaterial color, EProceso proceso)
            : this("SIN REFERENCIA", cantidad, calidad, color, proceso)
        {
        }
        public Arrabio(string empresaOrigen, int cantidad, ECalidad calidad, EColorMaterial color, EProceso proceso)
            : base(cantidad, calidad, color, proceso)
        {
            this.empresaOrigen = empresaOrigen;
        }

        public string EmpresaOrigen
        {
            get { return this.empresaOrigen; }
            set { this.empresaOrigen = value; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Arrabio");
            sb.AppendLine($"Empresa proveniente = {EmpresaOrigen}");
            sb.Append(base.ToString());
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Arrabio;
        }
    }
}
