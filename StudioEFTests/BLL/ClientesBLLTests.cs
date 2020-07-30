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
            Clientes clientes = new Clientes
            {
                ClienteId = 0,
                UsuarioId = 1,
                Nombres = "Frandy Francisco",
                Apellidos = "Mota",
                Cedula = "40214324567",
                Direccion = "Su Casa",
                Telefono = "123123123",
                Celular = "909808080",
                Sexo = "Hombre",
                FechaNacimiento = DateTime.Now
            };
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