using Entidades;
using Entidades.Enumerados;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FormPrincipal;
using Serializable;
using System.IO;

namespace UnitTestTPFinal
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void FinalizarProcesoValido()
        {
            //ARRAGE
            Arrabio arrabio = new Arrabio(3, "Finalizado", "Arrabio", "Ushuahia", 1000, "Excelente", "Azul");
            bool respuesta = false;
            //ACT
            respuesta = MateriaPrima.Finalizar(arrabio);
            //ASSERT
            Assert.IsTrue(respuesta);
        }
        [TestMethod]
        public void FinalizarProcesoInvalido()
        {
            //ARRAGE
            Arrabio arrabio = new Arrabio(3, "Distribucion", "Arrabio", "Ushuahia", 1000, "Excelente", "Azul");
            bool respuesta = false;
            //ACT
            respuesta = MateriaPrima.Finalizar(arrabio);
            //ASSERT
            Assert.IsFalse(respuesta);
        }
        [TestMethod]
        public void GuardarTxtPruebaFalse()
        {
            bool respuesta = false;
            List<Mensaje> listaMensajes = new List<Mensaje>();
            foreach (Mensaje item in listaMensajes)
            {
                respuesta = item.GuardarTxt();
            }
            Assert.IsFalse(respuesta);
        }
        [TestMethod]
        public void GuardarTxtPruebaTrue()
        {
            bool respuesta = false;
            List<Mensaje> listaMensajes = new List<Mensaje>();
            Mensaje miMensaje = new Mensaje("Finalizado",
                                            "Arrabio",
                                            "CABA",
                                            "100",
                                            "Malo",
                                            "Verde");
            MensajeCargado.Mensaje = miMensaje;
            listaMensajes = listaMensajes + miMensaje;
            foreach (Mensaje item in listaMensajes)
            {
                respuesta = item.GuardarTxt();
            }
            Assert.IsTrue(respuesta);
        }
    }
}
