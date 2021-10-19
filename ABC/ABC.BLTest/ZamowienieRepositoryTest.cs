using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BL;
using System;

namespace ABC.BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]
        public void PobierzZamowienie()
        {
            //Arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new Zamowienie(10)
            {
                DataZamowienia = new DateTimeOffset(2021, 10, 19, 22, 17, 00, new TimeSpan(2, 0, 0))
            };

            //Act
            var aktualna = zamowienieRepository.Pobierz(10);

            //Assert
            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
        }
    }
}
