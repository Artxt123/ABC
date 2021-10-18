using System;

namespace ABC.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {

        }
        public Zamowienie(int zamowienieId)
        {
            ZamowienieId = zamowienieId;
        }

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; } //? oznacza, że to jest nullable, czyli, że może być typu DateTimeOffset lub być nullem, dzięki temu będziemy w łatwy sposób wiedzieć czy ta właściwość została ustawiona, czy nie

        /// <summary>
        /// Pobieramy jedno wskazane zamowienie
        /// </summary>
        /// <param name="zamowienieId">ID zamówienia</param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            //Tu ma być kod, który pobierze zamówienie o wskazanym ID
            return new Zamowienie();
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

        /// <summary>
        /// Sprawdzamy dane zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia == null) //Jeżeli data zamówienia nie jest ustawiona to zwracamy false
                poprawne = false;

            return poprawne;
        }
    }
}
