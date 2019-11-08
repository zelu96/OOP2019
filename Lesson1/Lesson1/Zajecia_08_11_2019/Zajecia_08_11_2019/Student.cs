using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_08_11_2019
{
    public class Student : Osoba
    {
        protected int rok;
        protected int numerGrupy;
        protected int numerAlbumu;
        public Student(int rok, int numerGrupy, int numerAlbumu)
            :base("jakub","Kozicki",1994,"Kanafojskiego")
        {
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
             
            




        }

        public  void WypiszInfo1()
        {
            Console.Write("Rok" + this.rok, "Grupa" + this.numerGrupy, "NumerAlbumu" + this.numerAlbumu);
        }
    }
}
