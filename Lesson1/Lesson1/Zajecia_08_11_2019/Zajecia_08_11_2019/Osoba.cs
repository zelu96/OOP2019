using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_08_11_2019
{
    public class Osoba
    {

        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;
        private string miejsceZamieszkania;

        public void WypiszInfo()
        {
            Console.Write("Imie " + imie,"Nazwisko" + nazwisko,"RokUrodzenia" + rokUrodzenia,"Miejsce zamieszkania" + miejsceZamieszkania);

        }
        public Osoba(string imie, string nazwisko,int rokUrodzenia,string miejsceZamieszkania)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.miejsceZamieszkania = miejsceZamieszkania;

        }

        

        public int obliczWiek(int rokUrodzenia)
        {
            return DateTime.Now.Year - rokUrodzenia;
        }


    }
}
