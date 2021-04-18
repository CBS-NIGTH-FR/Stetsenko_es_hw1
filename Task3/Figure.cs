using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Figure
    {
        Point[] points;
        string name;

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        double CalculatePerimeter()
        {
            double perimeter = 0;
            double arrayLength = this.points.Length;

            if (arrayLength < 3)
            {
                Console.WriteLine("Your figure is not defined or has less than 3 sides");
            }
            else
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    if (i > 0)
                    {
                        perimeter += this.LengthSide(points[i - 1], points[i]);
                    }
                    if (i == arrayLength - 1)
                    {
                        perimeter += this.LengthSide(points[0], points[i]);
                    }

                }
            }
            return perimeter;
        }

        string FigureName()
        {
            if (points.Length == 3) name = "triangle";
            else if (points.Length == 4) name = "quad";
            else if (points.Length == 5) name = "pentagone";
            return name;
        }

        public void Show()
        {
            Console.WriteLine(new string('-',50));
            Console.WriteLine($"Figure name is {FigureName()}");
            Console.WriteLine($"Perimetr is {CalculatePerimeter()}");
        }


        public Figure(params Point[] points)
        {
            this.points = points;
        }

        //public void Show2()
        //{
        //    for(int i =0; i< this.points.Length; i++)
        //    {
        //        Console.WriteLine($"{points[i].X} {points[i].Y}" );
        //    }
        //}
    }
}
