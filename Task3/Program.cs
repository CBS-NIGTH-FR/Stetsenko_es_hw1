using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1,4);
            Point point2 = new Point(2,3);
            Point point3 = new Point(0,5);
            Point point4 = new Point(1,1);

            Figure figure = new Figure(point1, point2, point3, point4);
   
            figure.Show();
        }
    }
}
