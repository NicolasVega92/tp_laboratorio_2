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
            Arrabio arrabio                     = new Arrabio(EProceso.SinOperar, "Arrabio", "Ushuahia", 1000, ECalidad.Excelente, EColorMaterial.Azul);
            Arrabio arrabioIgual                = new Arrabio(EProceso.SinOperar, "Arrabio", "Ushuahia", 1000, ECalidad.Excelente, EColorMaterial.Azul);
            Reciclado reciclado                 = new Reciclado(EProceso.CorteConGas, "Reciclado", "CABA", 333, ECalidad.Excelente, EColorMaterial.Rojo);
            Arrabio arrabioMismosDatosReciclado = new Arrabio(EProceso.CorteConGas, "Arrabio", "CABA", 333, ECalidad.Excelente, EColorMaterial.Rojo);
            Reciclado recicladoIgual = new Reciclado(EProceso.CorteConGas, "Reciclado", "CABA", 333, ECalidad.Excelente, EColorMaterial.Rojo);
            Reciclado recicladoOtro = new Reciclado(EProceso.Laminada, "Reciclado", "Ushuahia", 222, ECalidad.Malo, EColorMaterial.Descolorido);

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
            Console.ReadKey();
        }
    }
}
