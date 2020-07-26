using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudioEF.BLL;
using StudioEF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudioEF.BLL.Tests
{
    [TestClass()]
    public class ClientesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Clientes clientes = new Clientes();
            clientes.ClienteId = 0;
            clientes.UsuarioId = 1;
            clientes.Nombres = "Frandy Francisco";
            clientes.Apellidos = "Mota";
            clientes.Cedula = "40214324567";
            clientes.Direccion = "Su Casa";
            clientes.Telefono = "123123123";
            clientes.Celular = "909808080";
            clientes.Sexo = "Hombre";
            clientes.FechaNacimiento = DateTime.Now;
            paso = ClientesBLL.Guardar(clientes);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = ClientesBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Clientes clientes;
            clientes = ClientesBLL.Buscar(1);

            Assert.AreEqual(clientes, clientes);
        }

        [TestMethod()]
        public void GetListTest()
        {
            var lista = new List<Clientes>();
            lista = ClientesBLL.GetList(p => true);

            Assert.AreEqual(lista, lista);
        }


       
    }
}