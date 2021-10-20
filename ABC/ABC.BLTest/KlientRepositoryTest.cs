using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BL;
using System.Collections.Generic;

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

        [TestMethod]
        public void PobierzKlientaZAdresami()
        {
            //Arange
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "arturo@o2.pl",
                Imie = "Artur",
                Nazwisko = "Oczkowski",
                ListaAdresow = new List<Adres>
                {
                    new Adres(1)
                    {
                        AdresTyp = 1,
                        Ulica = "Gościnna",
                        Miasto = "Katowice",
                        KodPocztowy = "43-786",
                        Kraj = "Polska"
                    },

                    new Adres(2)
                    {
                        AdresTyp = 2,
                        Ulica = "Wrocławska",
                        Miasto = "Wrocław",
                        KodPocztowy = "32-670",
                        Kraj = "Polska"
                    }
                }
            };

            //Act
            var aktualna = klientRepository.Pobierz(1);

            //Assert
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);

            //Petla wykona się tyle razy ile jest adresów w oczekiwanej lub aktualnej liście adresów;
            //Warunek (lub) sprawi, że pętla nie zostanie przerwana kiedy skończą się adresy w jednej z List, dzięki temu dowiemy się czy wszystkie adresy się zgadzają. Dowiemy się czy w jakiejś liście nie ma mniej adresów niż w drugiej;
            //Test się powiedzie, kiedy w każdej z List będzie taka sama liczba adresów o takich samych danych
            for (int i = 0; i < oczekiwana.ListaAdresow.Count || i < aktualna.ListaAdresow.Count; i++)
            {
                Assert.AreEqual(oczekiwana.ListaAdresow[i].AdresTyp, aktualna.ListaAdresow[i].AdresTyp);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Ulica, aktualna.ListaAdresow[i].Ulica);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Miasto, aktualna.ListaAdresow[i].Miasto);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].KodPocztowy, aktualna.ListaAdresow[i].KodPocztowy);
                Assert.AreEqual(oczekiwana.ListaAdresow[i].Kraj, aktualna.ListaAdresow[i].Kraj);
            }
        }
    }
}
