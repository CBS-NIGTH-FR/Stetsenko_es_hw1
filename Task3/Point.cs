using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Point
    {
        int x;
        int y;
        string name = null;

        public int X { get { return this.x; } }
        public int Y { get { return this.y; } }
        public string Name { get; }

        public Point(string name, int x, int y )
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            Console.Write("X: ");
            this.x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Y: ");
            this.y = Convert.ToInt32(Console.ReadLine());
        }


    }
}
