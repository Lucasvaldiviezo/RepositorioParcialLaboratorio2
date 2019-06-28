using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComiqueriaLogic;

namespace TestParcial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestException()
        {
            //Arrange
            double auxString = 20.10;
            string precio;
            string precioBien = "$20";
            //Act
            precio = auxString.FormatearPrecio(auxString);
            //Assert
            Assert.AreEqual(precioBien, precio);
        }
    }
}
