using System;
using System.Collections.Generic;

namespace Common
{
    public class UslugaLogowanie
    {
        public static void PiszDoPliku(List<ILogowanie> ZmienioneElementy)
        {
            foreach (var element in ZmienioneElementy)
            {
                //Normalnie zapisujemy dane logowania do pliku; tutaj wypisujemy je tylko na ekran
                Console.WriteLine(element.Log());
            }
        }
    }
}
