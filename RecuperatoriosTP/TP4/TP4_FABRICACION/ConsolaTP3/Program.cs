using Entidades;
using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serializable;

namespace ConsolaTP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrabio arrabio = new Arrabio(1, "SinOperar", "Arrabio", "Ushuahia", 1000, "Excelente", "Azul");
            Arrabio arrabioIgual = new Arrabio(1, "SinOperar", "Arrabio", "Ushuahia", 1000, "Excelente", "Azul");
            Reciclado reciclado = new Reciclado(2, "Finalizado", "Reciclado", "CABA", 500, "Excelente", "Rojo");
            Arrabio arrabioMismosDatosReciclado = new Arrabio(3, "Finalizado", "Arrabio", "CABA", 500, "Excelente", "Rojo");
            Reciclado recicladoIgual = new Reciclado(4, "Finalizado", "Reciclado", "CABA", 500, "Excelente", "Rojo");
            Reciclado recicladoOtro = new Reciclado(5, "Laminado", "Reciclado", "Jujuy", 333, "Malo", "Verde");

            Stock stock = new Stock("Lista");
            stock = stock + arrabio;
            stock = stock + arrabioIgual;   //NO SE DEBERIA SUMAR
            stock = stock + arrabioMismosDatosReciclado; //con diferente tipo de dato 
            stock = stock + reciclado;
            stock = stock + recicladoIgual; //NO SE DEBERIA SUMAR
            stock = stock + recicladoOtro;
            Console.WriteLine(stock.ListaDeMateriales.Count);
            foreach (MateriaPrima item in stock.ListaDeMateriales)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\nToque enter para seguir con la carga de XML");
            Console.ReadKey();
            foreach (Mensaje item in Mensaje.CargarXml())
            {
                Console.WriteLine(item.MostrarCampos());
            }
            Console.ReadKey();
        }
    }
}
