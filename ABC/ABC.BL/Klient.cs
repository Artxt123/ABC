namespace ABC.BL
{
    public class Klient
    {
        private string _nazwisko;
        public string Nazwisko
        {
            get
            {
                //tu też można wstawić dowolną ilość kodu
                return _nazwisko;
            }
            set
            {
                //tu też można wstawić dowolną ilość kodu
                _nazwisko = value;
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
    }
}
