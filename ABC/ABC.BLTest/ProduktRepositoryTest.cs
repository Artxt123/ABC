using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BL;

namespace ABC.BLTest
{
    [TestClass]
    public class ProduktRepositoryTest
    {
        [TestMethod]
        public void PobierzProdukt()
        {
            //Arange
            var produktRepository = new ProduktRepository();
            var oczekiwana = new Produkt(2)
            {
                NazwaProduktu = "Klocki",
                Opis = "Klocki dla dzieci powyżej 3 lat",
                AktualnaCena = 119.99M
            };

            //Act
            var aktualna = produktRepository.Pobierz(2);

            //Assert
            Assert.AreEqual(oczekiwana.ProduktId, aktualna.ProduktId);
            Assert.AreEqual(oczekiwana.NazwaProduktu, aktualna.NazwaProduktu);
            Assert.AreEqual(oczekiwana.Opis, aktualna.Opis);
            Assert.AreEqual(oczekiwana.AktualnaCena, aktualna.AktualnaCena);
        }
    }
}


