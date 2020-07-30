using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudioEF.BLL;
using StudioEF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudioEF.BLL.Tests
{
    [TestClass()]
    public class EventosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Eventos eventos = new Eventos();
            eventos.EventoId = 0;
            eventos.UsuarioId = 1;
            eventos.UsuarioId = 1;
            eventos.Descripcion = "";
            eventos.Lugar = "";
            //eventos.FechaInicio = DateTime;
            //eventos.FechaFin = DateTime;
            eventos.Precio = 100;
            eventos.Disponible = "";

            Assert.IsTrue(EventosBLL.Guardar(eventos));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = EventosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Eventos eventos;
            eventos = EventosBLL.Buscar(1);
            Assert.IsNotNull(eventos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Eventos>();
            lista = EventosBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }

      
    }
}