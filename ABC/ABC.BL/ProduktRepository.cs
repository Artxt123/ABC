namespace ABC.BL
{
    public class ProduktRepository
    {
        /// <summary>
        /// Pobieramy jeden wskazany produkt
        /// </summary>
        /// <param name="produktId">ID produktu</param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            // Tworzymy instancję klienta i przekazujemy identyfikator
            Produkt produkt = new Produkt(produktId);

            //Tu ma być rzeczywisty kod, który pobierze produkt o wskazanym ID

            // Tymczasowe zakodowane wartości, aby zwrócić produkt
            if (produktId == 2)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "Klocki dla dzieci powyżej 3 lat";
                produkt.AktualnaCena = 119.99M;
            }

            return produkt;
        }

        /// <summary>
        /// Zapisujemy aktualny produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //Tu ma być kod, który zapisuje aktualny produkt
            return true;
        }
    }
}
