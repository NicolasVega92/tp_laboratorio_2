using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Stock
    {
        private string nombre;
        private List<MateriaPrima> listaDeMateriales;
        private Stock()
        {
            this.listaDeMateriales = new List<MateriaPrima>();
        }
        public Stock(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public List<MateriaPrima> ListaDeMateriales
        {
            get { return this.listaDeMateriales; }
        }
        private void AgregarMaterial(MateriaPrima materia)
        {
            this.listaDeMateriales.Add(materia);
        }
        public static bool operator ==(Stock stock, MateriaPrima materia)
        {
            bool retorno = false;
            foreach (MateriaPrima item in stock.ListaDeMateriales)
            {
                if(item == materia)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Stock stock, MateriaPrima materia)
        {
            return !(stock == materia);
        }
        public static Stock operator +(Stock stock, MateriaPrima materia)
        {
            if(stock != materia)
            {
                stock.AgregarMaterial(materia);
            }
            return stock;
        }
    }
}
