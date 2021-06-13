using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrabio     arrabio           = new Arrabio("Ushuahia", 1000, "Excelente", EColorMaterial.Azul, EProceso.SinOperar);
            Arrabio     arrabioIgual      = new Arrabio("Ushuahia", 1000, "Excelente", EColorMaterial.Azul, EProceso.SinOperar);
            Reciclado   reciblado         = new Reciclado("BuenosAires", 200, "Buena", EColorMaterial.Descolorido, EProceso.AltoHorno);
            Reciclado   recibladoIgual    = new Reciclado("BuenosAires", 200, "Buena", EColorMaterial.Descolorido, EProceso.AltoHorno);
            Reciclado   recibladoOtro     = new Reciclado("Cordoba", 400, "Malo", EColorMaterial.Rojo, EProceso.AltoHorno);

            Stock stock = new Stock("Lista");
            stock = stock + arrabio;
            stock = stock + arrabioIgual;   //NO SE DEBERIA SUMAR
            stock = stock + reciblado;
            stock = stock + recibladoIgual; //NO SE DEBERIA SUMAR
            stock = stock + recibladoOtro;
            Console.WriteLine(stock.ListaDeMateriales.Count);
            foreach (MateriaPrima item in stock.ListaDeMateriales)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
