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

            //System.Console.WriteLine("Witaj świecie !!!");

            


            Console.ReadLine();
        }
    }
}
