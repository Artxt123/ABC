namespace ABC.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }
        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }

        /// <summary>
        /// Pobieramy jedną wskazaną pozycję zamówienia
        /// </summary>
        /// <param name="pozycjaZamowieniaId">ID pozycji zamówienia</param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            //Tu ma być kod, który pobierze pozycję zamówienie o wskazanym ID
            return new PozycjaZamowienia();
        }

        /// <summary>
        /// Zapisujemy aktualny element zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //Tu ma być kod, który zapisuje aktualną pozycję zamówienia
            return true;
        }

        /// <summary>
        /// Sprawdzamy dane pozycji zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;
            if (Ilosc <= 0)
                poprawne = false;
            if (ProduktId <= 0)
                poprawne = false;
            if (CenaZakupu == null)
                poprawne = false;

            return poprawne;
        }
    }
}
