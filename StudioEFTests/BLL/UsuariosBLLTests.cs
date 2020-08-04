using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudioEF.BLL;
using StudioEF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudioEF.BLL.Tests
{
    [TestClass()]
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = 0;
            usuarios.Nombres = "Frandy";
            usuarios.NombreUsuario = "Admin";
            usuarios.Contrasena = "Addmin";
            usuarios.Email = "Frandy@gmail.com";

            Assert.IsTrue(UsuariosBLL.Guardar(usuarios));
        }


        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = UsuariosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Usuarios usuarios;
            usuarios = UsuariosBLL.Buscar(1);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool t = true;

            Assert.IsTrue(t);
        }

    
    }
}