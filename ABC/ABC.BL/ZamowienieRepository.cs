using System;

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
