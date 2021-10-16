using ABC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ABC.BLTest
{
    [TestClass]
    public class KientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arrange (zaaranżuj test)
            Klient klient = new Klient();
            klient.Imie = "Artur";
            klient.Nazwisko = "Oczkowski";
            string oczekiwana = "Artur, Oczkowski";

            //ACT (działaj)
            string aktualna = klient.ImieNazwisko;

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
