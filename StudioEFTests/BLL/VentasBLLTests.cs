using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudioEF.BLL;
using StudioEF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudioEF.BLL.Tests
{
    [TestClass()]
    public class VentasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
          
            Ventas ventas = new Ventas();
            ventas.VentaId = 0;
            ventas.ClienteId = 1;
            ventas.Nombres = "Frandy";
            ventas.Apellidos = "Mota";
            ventas.Total = 100;

            Assert.IsTrue(VentasBLL.Guardar(ventas));
        }        

        [TestMethod()]
        public void BuscarTest()
        {
            Ventas ventas;
            ventas = VentasBLL.Buscar(1);
            Assert.IsNotNull(ventas);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = VentasBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Ventas>();
            lista = VentasBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}