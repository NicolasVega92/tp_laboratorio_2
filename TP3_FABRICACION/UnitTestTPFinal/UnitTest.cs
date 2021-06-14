using Entidades;
using Entidades.Enumerados;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestTPFinal
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void FinalizarProcesoValido()
        {
            //ARRAGE
            Stock stock = new Stock("lista");
            Arrabio arrabio = new Arrabio(EProceso.Finalizado, "Arrabio", "Ushuahia", 1000, ECalidad.Excelente, EColorMaterial.Azul);
            bool respuesta = false;
            //ACT
            respuesta = stock.Finalizar(arrabio);
            //ASSERT
            Assert.IsTrue(respuesta);
        }
        [TestMethod]
        public void FinalizarProcesoInvalido()
        {
            //ARRAGE
            Stock stock = new Stock("lista");
            Arrabio arrabio = new Arrabio(EProceso.SinOperar, "Arrabio", "Ushuahia", 1000, ECalidad.Excelente, EColorMaterial.Azul);
            bool respuesta = false;
            //ACT
            respuesta = stock.Finalizar(arrabio);
            //ASSERT
            Assert.IsFalse(respuesta);
        }
    }
}
