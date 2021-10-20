using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class AdresRepository
    {
        /// <summary>
        /// Pobieramy jednen wskazany adres
        /// </summary>
        /// <param name="adresId">ID adresu</param>
        /// <returns></returns>
        public Adres Pobierz(int adresId)
        {
            // Tworzymy instancję adresu i przekazujemy identyfikator
            Adres adres = new Adres(adresId);

            //Tu ma być rzeczywisty kod, który pobierze adres o wskazanym ID

            // Tymczasowe zakodowane wartości, aby zwrócić zamowienie
            if (adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Krotoszyńska";
                adres.Miasto = "Poznań";
                adres.Kraj = "Polska";
                adres.KodPocztowy = "61-111";
            }

            return adres;
        }
        /// <summary>
        /// Pobieramy wszystkie zdefiniowane adresy dla konkretnego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public IEnumerable<Adres> PobierzPoKlientId (int klientId)
        {
            // Tu ma być rzeczywisty kod, który będzie pobierał wszystkie adresy przypisane do danego klienta

            //Tymczasowe zakodowane wartości do zwrócenia; zestaw adresów dla klienta
            var adresList = new List<Adres>();

            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Gościnna",
                Miasto = "Katowice",
                KodPocztowy = "43-786",
                Kraj = "Polska"
            };
            adresList.Add(adres);

            adres = new Adres(2)
            {
                AdresTyp = 2,
                Ulica = "Wrocławska",
                Miasto = "Wrocław",
                KodPocztowy = "32-670",
                Kraj = "Polska"
            };
            adresList.Add(adres);

            return adresList;
        }

        /// <summary>
        /// Zapisujemy aktualny adres
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Adres adres)
        {
            //Tu ma być kod, który zapisuje aktualny adres
            return true;
        }
    }
}
