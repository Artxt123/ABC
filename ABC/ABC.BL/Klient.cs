using System.Collections.Generic;

namespace ABC.BL
{
    public class Klient
    {
        public static int Licznik { get; set; } //właściwość static oznacza, że ta właściwość należy tylko do tej klasy, a nie do instancji tej klasy (nie do konkretnych obiektów, które zostaną utworzone); będzie się można odwołać do właściwości licznik, tylko w ten sposób: Klient.Licznik 

        private string nazwisko;
        public string Nazwisko
        {
            get
            {
                //tu też można wstawić dowolną ilość kodu
                return nazwisko;
            }
            set
            {
                //tu też można wstawić dowolną ilość kodu
                if (!string.IsNullOrWhiteSpace(value))
                    nazwisko = value;
            }
        }

        // Właściwość automatyczna, robi to samo co właściwość Nazwisko, tylko, że dla pola imie
        public string Imie { get; set; }
        public string Email { get; set; }
        public int KlientId { get; private set; } //snippet propg Set na private, zamist go usuwać, aby miec do niego dostęp w obrębie tej klasy. Inni i tak nie będą mieli do niego dostępu
        public string ImieNazwisko
        {
            get
            {
                //Poniższy kod sprawia, że w razie wystąpienia samego Imienia, bądź samego Nazwiska, nie zostanie dodany ", "
                string imieNazwisko = Imie;
                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }
                return imieNazwisko;
            }
        }

        public bool Zwaliduj()
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(Nazwisko))
                poprawne = false;
            if (string.IsNullOrWhiteSpace(Email))
                poprawne = false;

            return poprawne;
        }
        /// <summary>
        /// Zapisujemy obecnego klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Tu ma być kod, który zapisuje zdefiniowanego klienta
            return true;
        }
        public Klient Pobierz(int klientId)
        {
            //Tu ma być kod, który pobiera określonego klienta; wskazanego po ID
            return new Klient();
        }
        public List<Klient> Pobierz()
        {
            //Tu ma być kod, który wypisuje listę wszystkich klientów
            return new List<Klient>();
        }
    }
}
