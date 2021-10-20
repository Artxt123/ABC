﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class KlientRepository
    {
        //Klientrepository będzie współpracował z AdresRepository, dlatego tworzymy tutaj takie pole, aby można go było użyć w kodzie
        public AdresRepository adresRepository { get; set; }
        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }

        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId">ID klienta, którego chcemy pobrać</param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            // Tworzymy instancję klienta i przekazujemy identyfikator
            Klient klient = new Klient(klientId);
            //Pobieramy listę adresów dla Klienta, wykorzystując jego ID; korzystamy z klasy AdresRepository i metody PobierzPoKlientId
            klient.ListaAdresow = adresRepository.PobierzPoKlientId(klientId).ToList();

            //Tu ma być rzeczywisty kod, który pobiera określonego klienta; wskazanego po ID

            // Tymczasowe zakodowane wartości, aby zwrócić klienta
            if (klientId == 1)
            {
                klient.Email = "arturo@o2.pl";
                klient.Imie = "Artur";
                klient.Nazwisko = "Oczkowski";
            }

            return klient;
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
        /// <summary>
        /// Zapisujemy obecnego klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // Tu ma być kod, który zapisuje zdefiniowanego klienta
            return true;
        }
    }
}
