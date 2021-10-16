using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int KlientId { get; private set; }
        public string ImieNazwisko
        {
            get
            {
                return Nazwisko + "," + Imie;
            }
        }
    }
}
