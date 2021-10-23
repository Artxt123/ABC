using ABC.BL;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CommonTest
{
    [TestClass]
    public class UslugaLogowanieTest
    {
        [TestMethod]
        public void PiszDoPlikuTest()
        {
            //Arrange
            var zmienioneElementy = new List<ILogowanie>();

            var klient = new Klient(1)
            {
                Email = "arturo@o2.pl",
                Imie = "Artur",
                Nazwisko = "Oczkowski",
                ListaAdresow = null
            };
            zmienioneElementy.Add(klient as ILogowanie); //traktujemy, że kleint implementuje interfejs ILogowanie; dodajemy klienta jako (as) implementującego interfejs ILogowanie, bo nasza lista zmienioneElementy spodziewa się, że dodamy element ILogowanie

            var produkt = new Produkt(11)
            {
                NazwaProduktu = "KlockiLego",
                Opis = "Klocki dla dzieci",
                AktualnaCena = 129.99M
            };
            zmienioneElementy.Add(produkt as ILogowanie);

            var zamowienie = new Zamowienie(300)
            {
                DataZamowienia = new DateTimeOffset(2021, 10, 22, 15, 05, 33, new TimeSpan(2, 0, 0))
            };
            zmienioneElementy.Add(zamowienie as ILogowanie);

            //Act
            UslugaLogowanie.PiszDoPliku(zmienioneElementy);

            //Assert
        }
    }
}
