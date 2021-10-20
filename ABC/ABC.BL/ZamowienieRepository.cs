using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class ZamowienieRepository
    {
        /// <summary>
        /// Pobieramy jedno wskazane zamowienie
        /// </summary>
        /// <param name="zamowienieId">ID zamówienia</param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            // Tworzymy instancję zamowienia i przekazujemy identyfikator
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            //Tu ma być rzeczywisty kod, który pobierze zamówienie o wskazanym ID

            // Tymczasowe zakodowane wartości, aby zwrócić zamowienie
            if (zamowienieId == 10)
                zamowienie.DataZamowienia = new DateTimeOffset(2021, 10, 19, 22, 17, 00, new TimeSpan(2, 0, 0));

            return zamowienie;
        }

        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia (int zamowienieId)
        {
            // Tworzymy instancję wyswietlenia zamowienia
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();

            //Tu ma być rzeczywisty kod, który pobierze zamówienie do wyświetlenia o wskazanym ID

            //Tymczasowe dane zakodowane na stałe
            if (zamowienieId == 10)
            {
                wyswietlanieZamowienia.Imie = "Artur";
                wyswietlanieZamowienia.Nazwisko = "Oczkowski";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2021, 10, 20, 21, 30, 00, new TimeSpan(2, 0, 0));
                wyswietlanieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Złotowska",
                    Miasto = "Złotów",
                    KodPocztowy = "77-400",
                    Kraj = "Polska"
                };
            }
            wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista = new List<WyswietlaniePozycjiZamowienia>();
            //Tu ma być kod, który pobiera elementy zamówienia

            //Tymczasowe dane zakodowane na stałe:
            if (zamowienieId == 10)
            {
                var wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Krzesło",
                    IloscZamowienia = 4,
                    CenaZakupu = 119.99M
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);

                wyswietlaniePozycjiZamowienia = new WyswietlaniePozycjiZamowienia()
                {
                    NazwaProduktu = "Stół",
                    IloscZamowienia = 2,
                    CenaZakupu = 240.00M
                };
                wyswietlanieZamowienia.WyswietlaniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);
            }

            return wyswietlanieZamowienia;
        }

        /// <summary>
        /// Zapisujemy aktualne zamówienie
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //Tu ma być kod, który zapisuje aktualne zamówienie
            return true;
        }
    }
}
