using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BL;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlienta()
        {
            //Arange
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "arturo@o2.pl",
                Imie = "Artur",
                Nazwisko = "Oczkowski"
            };

            //Act
            var aktualna = klientRepository.Pobierz(1);

            //Assert
            //Assert.AreEqual(oczekiwana, aktualna); //to jest zbyt ogólne porównanie, które się nie uda, trzeba porównać bardziej szczegółowo każdą z właściwości obiektu Klient
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);
        }
    }
}
