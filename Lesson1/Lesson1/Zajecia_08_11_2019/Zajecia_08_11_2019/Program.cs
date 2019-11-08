using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_08_11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student(1, 6, 141360);
           

            Console.WriteLine(student1.obliczWiek(1996));
            Console.ReadKey();

            

       
           
            
        }

       
    }
}
