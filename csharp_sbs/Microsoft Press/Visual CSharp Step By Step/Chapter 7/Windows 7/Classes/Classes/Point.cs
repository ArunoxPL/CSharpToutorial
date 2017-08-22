#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        //Default konstructor
        public Point()
        {
            Console.WriteLine("Default Constructor Called");
        }

        //Non-Default constructor
        public Point(int x, int y)
        {
            Console.WriteLine("The point cordinets are x: {0}, y:{1}", x, y);
        }
    }
}
