using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudioEF.BLL;
using StudioEF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudioEF.BLL.Tests
{
    [TestClass()]
    public class FotografosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
        
            Fotografos fotografos = new Fotografos();
            fotografos.FotografoId = 0;
            fotografos.UsuarioId = 1;
            fotografos.Nombres = "";
            fotografos.Apellidos = "";
            fotografos.Cedula = "";
            fotografos.Direccion = "";
            fotografos.Telefono = "";
            fotografos.Celular = "";
            fotografos.Sexo = "";
            fotografos.Sueldo = 100;

            Assert.IsTrue(FotografosBLL.Guardar(fotografos));
        }      

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = FotografosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Fotografos fotografos;
            fotografos = FotografosBLL.Buscar(1);
            Assert.IsNotNull(fotografos);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Fotografos>();
            lista = FotografosBLL.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}