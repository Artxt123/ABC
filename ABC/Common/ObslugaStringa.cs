namespace Common
{
    public static class ObslugaStringa //klasa statyczna nie może zostać utworzona
    {
        //aby wywolać metodę statyczną nie musimy tworzyć instancji klasy (nie musimy tworzyć nowego obiektu, tylko podając nazwę klasy możemy od razu odwołać się do metody statycznej
        //METODA ROZSZERZENIA MUSI ZNAJDOWAĆ SIĘ W KLASIE STATYCZNEJ i sama musi być statyczna
        //Metoda statyczna stając się metodą rozszerzoną nie przestaje być statyczną i można jej używać jak zwykłej metody statycznej
        //Poniższa metoda rozszerzenia nie musi przyjmować przy wywołaniu tego parametru "string zrodlo"; to już nie jest jako parametr, ale bardziej jako reprezentant klasy, którą rozszerzamy
        public static string WstawSpacje(this string zrodlo) //za pomocą słowa this przekształcamy metodę statyczną w metodę rozszerzająca dla klasy zdefiniowanej w pierwszym parametrze
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
