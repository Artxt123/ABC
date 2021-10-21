using System.Collections.Generic;

namespace ABC.BL
{
    public class Klient
    {
        //Jak chcemy utworzyć specjalny konstruktor, to i tak musimy utworzyć konstruktor podstawowy, żeby można było użyc konstruktora bez żadnych parametrów
        public Klient() : this(0) //domyślny konstruktor będzie zawsze wywoływał konstruktor, który jest poniżej, bo on tworzy pustą listę adresów, która inaczej byłaby nullem; klientId będzie domyślnie ustawiane na 0, ale i tak było na tyle ustawiane, nawet bez łączenia konstruktorów
        {

        }
        public Klient(int klientId)
        {
            KlientId = klientId;
            ListaAdresow = new List<Adres>();
        }
        public static int Licznik { get; set; } //właściwość static oznacza, że ta właściwość należy tylko do tej klasy, a nie do instancji tej klasy (nie do konkretnych obiektów, które zostaną utworzone); będzie się można odwołać do właściwości licznik, tylko w ten sposób: Klient.Licznik 

        public List<Adres> ListaAdresow { get; set; } //domyślnie ListaAdresow będzie nullem, a to nie jest dobre, dlatego musimy utworzyć pustą listę adresów w konstruktorze (wtedy będzie pusta, ale nie będzie nullem)
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
        public int KlientTyp { get; set; }

        /// <summary>
        /// Sprawdzamy, czy zostały ustawione wymagane wartości (Nazwisko, Email)
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId">ID klienta, którego chcemy pobrać</param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            //Tu ma być kod, który pobiera określonego klienta; wskazanego po ID
            return new Klient();
        }
        
        /// <summary>
        /// Pobieramy listę wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            //Tu ma być kod, który wypisuje listę wszystkich klientów
            return new List<Klient>();
        }
        public override string ToString()
        {
            return ImieNazwisko;
        }
    }
}
