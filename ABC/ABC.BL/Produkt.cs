using Common;
using System;

namespace ABC.BL
{
    public class Produkt : KlasaBazowa
    {
        public Produkt()
        {

        }
        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        public int ProduktId { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        private string _NazwaProduktu;

        public string NazwaProduktu
        {
            get
            {
                return ObslugaStringa.WstawSpacje(_NazwaProduktu);
            }
            set { _NazwaProduktu = value; }
        }


        /// <summary>
        /// Pobieramy jeden wskazany produkt
        /// </summary>
        /// <param name="produktId">ID produktu</param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            //Tu ma być kod, który pobierze produkt o wskazanym ID
            return new Produkt();
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

        /// <summary>
        /// Sprawdzamy dane produktu
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;

            return poprawne;
        }
        public override string ToString()
        {
            return NazwaProduktu;
        }
    }
}
