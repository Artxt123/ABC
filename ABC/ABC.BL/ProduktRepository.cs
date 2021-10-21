using System;

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
            // Tworzymy instancję produktu i przekazujemy identyfikator
            Produkt produkt = new Produkt(produktId);
            Object mojObiekt = new Object();
            Console.WriteLine("Obiekt: "+ mojObiekt.ToString());
            Console.WriteLine("Produkt: "+ produkt.ToString());

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
        public bool Zapisz(Produkt produkt)
        {
            //Kod, który zapisuje zdefiniowany produkt
            var sukces = true;

            //Jezeli cos pójdzie w trakcie nie tak, to modyfikujemy kod w taki sposób, aby w którymś z ifów zmieniał sukces na false

            //Jeżeli obiekt nie ma zmiany lub dane nie są prawidłowe to go nie wprowadzamy lub nie aktualizujemy
            if (produkt.MaZmiany && produkt.DaneSaPrawidlowe)
            {
                if (produkt.JestNowy)
                {
                    // Wywyołuemy procedurę składowaną INSERT
                }
                else //Jeżeli produkt nie jest nowy lub został usunięty to AKTUALIZUJEMY jego dane i status
                {
                    // Wywyołuemy procedurę składowaną UPDATE
                }
            }
            return sukces;
        }
    }
}
