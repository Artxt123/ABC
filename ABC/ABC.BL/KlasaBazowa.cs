namespace ABC.BL
{
    //Klasy abstrakcyjnej nie można utworzyć za pomocą słowa new; można ją dziedziczyć
    public abstract class KlasaBazowa
    //protected - dostępny dla tej klasy i klas potomnych
    {
        public bool JestNowy { get; set; }
        public bool MaZmiany { get; set; }
        public StanObiektuOpcje StanObiektu { get; set; }
        public bool DaneSaPrawidlowe
        { 
            get
            {
                //Aby sprawdzić prawidłowość danych wywołujemy metodę Zwaliduj. Każda klasa potomna ma swoją metodę zwaliduj
                return Zwaliduj();
            } 
        }

        //Aby klasa potomna mogła nadpisać metodę to musi być ona oznaczona jako virtual lub abstract
        //Metoda virtual może zostać nadpisana, ale nie musi, bo ma swój własny kod
        //Metoda abstract nie ma swojego kodu i, aby działała musi zostać nadpisana w klasie potomnej
        public abstract bool Zwaliduj();
    }

    public enum StanObiektuOpcje
    {
        Aktywne,
        Usuniete
    }
}