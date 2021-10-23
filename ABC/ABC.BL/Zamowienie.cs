using Common;
using System;
using System.Collections.Generic;

namespace ABC.BL
{
    public class Zamowienie : KlasaBazowa, ILogowanie
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
        public List<PozycjaZamowienia> PozycjaZamowienia { get; set; }
        public int KlientId { get; set; }
        public int AdresDostawyId { get; set; }

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
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (DataZamowienia == null) //Jeżeli data zamówienia nie jest ustawiona to zwracamy false
                poprawne = false;

            return poprawne;
        }
        public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId + ")";
        }

        public string Log()
        {
            var logTekst = ZamowienieId + ": " +
                           "Data: " + DataZamowienia.Value.UtcDateTime + " " +
                           "Status: " + StanObiektu.ToString();
            return logTekst;
        }
    }
}
