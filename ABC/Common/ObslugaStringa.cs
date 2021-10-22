namespace Common
{
    public static class ObslugaStringa //klasa statyczna nie może zostać utworzona
    {
        public static string WstawSpacje(string zrodlo) //aby wywolać metodę statyczną nie musimy tworzyć instancji klasy (nie musimy tworzyć nowego obiektu, tylko podając nazwę klasy możemy od razu odwołać się do metody statycznej
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
