using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toutorial2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var Number = 10;

            var IsNumber10 = false;
            /*
            if (Number == 10)
            {
                IsNumber10 = true;
            }

            else
            {
                IsNumber10 = false;
            }
            */
            IsNumber10 = Number == 10 ? true : false;
            Console.WriteLine("Number == 10 is {0}", IsNumber10);
            int[] liczby = { 1, 2, 3, 4};
            foreach(int i in liczby)
            {
                Console.WriteLine(i);
            }


            //System.Console.WriteLine("Witaj świecie !!!");

            


            Console.ReadLine();
        }
    }
}
