using Entidades.Enumerados;
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
        /// <summary>
        /// Constructor que instancia la lista de materiales
        /// </summary>
        private Stock()
        {
            this.listaDeMateriales = new List<MateriaPrima>();
        }
        /// <summary>
        /// Constructor de Stock
        /// </summary>
        /// <param name="nombre"></param>
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
        /// <summary>
        /// Retorna la lista de materiales completa
        /// </summary>
        public List<MateriaPrima> ListaDeMateriales
        {
            get { return this.listaDeMateriales; }
        }
        /// <summary>
        /// Agrega un material a la lista
        /// </summary>
        /// <param name="materia"></param>
        private void AgregarMaterial(MateriaPrima materia)
        {
            this.listaDeMateriales.Add(materia);
        }
        /// <summary>
        /// Sobrecarga del operador == que identifica si ya esta cargado o no un material a la lista
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="materia"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="materia"></param>
        /// <returns></returns>
        public static bool operator !=(Stock stock, MateriaPrima materia)
        {
            return !(stock == materia);
        }
        /// <summary>
        /// Sobrecarga del operador + para agregar un material a la lista
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="materia"></param>
        /// <returns></returns>
        public static Stock operator +(Stock stock, MateriaPrima materia)
        {
            if(stock != materia && !(materia is null))
            {
                stock.AgregarMaterial(materia);
            }
            return stock;
        }
        /// <summary>
        /// Filtra la lista de materiales segun el proceso en el que se encuentre el material
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="proceso"></param>
        /// <returns></returns>
        public List<MateriaPrima> FiltrarLista(List<MateriaPrima> lista, EProceso proceso)
        {
            List<MateriaPrima> listaFiltrada = new List<MateriaPrima>();
            foreach (MateriaPrima item in listaDeMateriales)
            {
                if(item.Proceso == proceso)
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;
        }
        /// <summary>
        /// Identifica si un material esta en el proceso de Finalizado
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public bool Finalizar(MateriaPrima material)
        {
            bool retorno = false;
            if(material.Proceso == EProceso.Finalizado)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
