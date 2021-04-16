using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Point
    {
        int x;
        int y;
        string name;

        public int X { get; }
        public int Y { get; }
        public string Name { get; }

        public Point(string name, int x, int y )
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public Point():this(" ",0,0){}


    }
}
