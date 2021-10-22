namespace Common
{
    public class ObslugaStringa
    {
        public string WstawSpacje(string zrodlo)
        {
            var wynik = string.Empty;

            if (!string.IsNullOrWhiteSpace(zrodlo))
            {
                foreach (var litera in zrodlo)
                {
                    if (char.IsUpper(litera)) // doajemy spację przed każdą wielką literą, również na początku stringa
                    {
                        wynik = wynik.Trim(); //przycinamy wszystkie spacje przed i po wielkiej literze i potem dodajemy swoją przed tą wielką literą
                        wynik += " ";
                    }
                    wynik += litera;
                }
                wynik = wynik.Trim(); //usuwa spacje na początku i na końcu stringa
            }

            return wynik;
        }
    }
}
