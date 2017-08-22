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
            Employee emp = new Employee(5, 101);
            Console.WriteLine($"emp years of service: {emp.YearsOfService}");
        }


    }
}
