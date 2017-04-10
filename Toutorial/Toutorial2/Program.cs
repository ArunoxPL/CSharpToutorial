using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toutorial2
{
    class Kursy
    {
        public string tytul;
        public double cena;
        public int rozdzialy;
        public string kategoria;
        public void ustaw_tytul(string tytul_k)
        {
            tytul = tytul_k;
            Console.WriteLine(tytul_k);
        }
    }


    class Program
    {
       
        static void Main(string[] args)
        {
            Kursy kursy = new Kursy();
            kursy.ustaw_tytul(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
