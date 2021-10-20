using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BL;
using System;
using System.Collections.Generic;

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
        [TestMethod]
        public void PobierzZamowienieDoWyswietleniaTest()
        {
            //Arrange
            var zamowienieRepository = new ZamowienieRepository();
            var oczekiwana = new WyswietlanieZamowienia()
            {
                Imie = "Artur",
                Nazwisko = "Oczkowski",
                DataZamowienia = new DateTimeOffset(2021, 10, 20, 21, 30, 00, new TimeSpan(2, 0, 0)),
                AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Złotowska",
                    Miasto = "Złotów",
                    KodPocztowy = "77-400",
                    Kraj = "Polska"
                },
                WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>()
                {
                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Krzesło",
                        IloscZamowienia = 4,
                        CenaZakupu = 119.99M
                    },

                    new WyswietlaniePozycjiZamowienia()
                    {
                        NazwaProduktu = "Stół",
                        IloscZamowienia = 2,
                        CenaZakupu = 240.00M
                    }
                }
            };

            //Act
            var aktualna = zamowienieRepository.PobierzZamowienieDoWyswietlenia(10);

            //Assert
            Assert.AreEqual(oczekiwana.ZamowienieId, aktualna.ZamowienieId);
            Assert.AreEqual(oczekiwana.DataZamowienia, aktualna.DataZamowienia);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            Assert.AreEqual(oczekiwana.AdresDostawy.AdresTyp, aktualna.AdresDostawy.AdresTyp);
            Assert.AreEqual(oczekiwana.AdresDostawy.Ulica, aktualna.AdresDostawy.Ulica);
            Assert.AreEqual(oczekiwana.AdresDostawy.Miasto, aktualna.AdresDostawy.Miasto);
            Assert.AreEqual(oczekiwana.AdresDostawy.KodPocztowy, aktualna.AdresDostawy.KodPocztowy);
            Assert.AreEqual(oczekiwana.AdresDostawy.Kraj, aktualna.AdresDostawy.Kraj);

            for (int i = 0; i < oczekiwana.WyswietlaniePozycjiZamowieniaLista.Count || i < aktualna.WyswietlaniePozycjiZamowieniaLista.Count; i++)
            {
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].NazwaProduktu);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].IloscZamowienia, aktualna.WyswietlaniePozycjiZamowieniaLista[i].IloscZamowienia);
                Assert.AreEqual(oczekiwana.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu, aktualna.WyswietlaniePozycjiZamowieniaLista[i].CenaZakupu);
            }
        }
    }
}
