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
        [TestMethod]
        public void ImieNazwiskoImiePuste()
        {
            // Arrange (zaaranżuj test)
            Klient klient = new Klient();
            klient.Nazwisko = "Oczkowski";
            string oczekiwana = "Oczkowski";

            //ACT (działaj)
            string aktualna = klient.ImieNazwisko;

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod]
        public void ImieNazwiskoNazwiskoPuste()
        {
            // Arrange (zaaranżuj test)
            Klient klient = new Klient();
            klient.Imie = "Artur";
            string oczekiwana = "Artur";

            //ACT (działaj)
            string aktualna = klient.ImieNazwisko;

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod]
        public void StaticTest()
        {
            // Arrange (zaaranżuj test)
            Klient klient1 = new Klient();
            klient1.Imie = "Artur";
            Klient.Licznik++;

            Klient klient2 = new Klient();
            klient2.Imie = "Marysia";
            Klient.Licznik++;

            Klient klient3 = new Klient();
            klient3.Imie = "Zosia";
            Klient.Licznik++;

            //Assert (potwierdź test)
            Assert.AreEqual(3, Klient.Licznik);
        }
        [TestMethod]
        public void ZwalidujTest()
        {
            // Arrange (zaaranżuj test)
            Klient klient = new Klient();
            klient.Nazwisko = "Oczkowski";
            klient.Email = "oczkowski@o2.pl";
            var oczekiwana = true;

            //ACT (działaj)
            var aktualna = klient.Zwaliduj();

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod]
        public void ZwalidujBrakNazwiska()
        {
            // Arrange (zaaranżuj test)
            Klient klient = new Klient();
            klient.Email = "oczkowski@o2.pl";
            var oczekiwana = false;

            //ACT (działaj)
            var aktualna = klient.Zwaliduj();

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
