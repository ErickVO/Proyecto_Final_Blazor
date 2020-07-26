using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudioEF.BLL;
using StudioEF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudioEF.BLL.Tests
{
    [TestClass()]
    public class CategoriasBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Categorias categorias = new Categorias();
            categorias.CategoriaId = 0;
            categorias.UsuarioId = 1;
            categorias.Nombre = "Ceriografia";
           
            paso = CategoriasBLL.Guardar(categorias);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = CategoriasBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Categorias categorias;
            categorias = CategoriasBLL.Buscar(1);

            Assert.AreEqual(categorias, categorias);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Categorias>();
            lista = CategoriasBLL.GetList(p => true);

            Assert.AreEqual(lista, lista);
        }
    }
}