using Entidades;
using Entidades.Enumerados;
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
            Arrabio arrabio                     = new Arrabio("Ushuahia", 1000, ECalidad.Excelente, EColorMaterial.Azul, EProceso.SinOperar);
            Arrabio arrabioIgual                = new Arrabio("Ushuahia", 1000, ECalidad.Excelente, EColorMaterial.Azul, EProceso.SinOperar);
            Reciclado reciblado                 = new Reciclado("BuenosAires", 200, ECalidad.Bueno, EColorMaterial.Descolorido, EProceso.AltoHorno);
            Arrabio arrabioMismosDatosReciclado = new Arrabio("BuenosAires", 200, ECalidad.Bueno, EColorMaterial.Descolorido, EProceso.AltoHorno);
            Reciclado recibladoIgual            = new Reciclado("BuenosAires", 200, ECalidad.Malo, EColorMaterial.Descolorido, EProceso.AltoHorno);
            Reciclado recibladoOtro             = new Reciclado("Cordoba", 400, ECalidad.Malo, EColorMaterial.Rojo, EProceso.CorteConGas);

            Stock stock = new Stock("Lista");
            stock = stock + arrabio;
            stock = stock + arrabioIgual;   //NO SE DEBERIA SUMAR
            stock = stock + arrabioMismosDatosReciclado; //con diferente tipo de dato 
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
