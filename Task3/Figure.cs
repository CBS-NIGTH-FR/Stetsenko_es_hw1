using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Figure
    {
        Point[] points;
        int number;
        private int Number
        {
           get
            {
                return number;
            }
           set
            {
                if (value >= 3 && value <= 5) number = value;
                else
                {
                    Console.WriteLine("Неверное количество yглов. Теперь их 3");
                    number = 3;
                }
            }
        }

        string name;
        Point CreatePoint()
        {
            int x;
            int y;
            string name;
            Console.Write("name: ");
            name = Console.ReadLine();

            Console.Write("X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            return new Point(name, x, y);
        }

        //проблема зі створенням масивy або його заповненням
        void InitFigure()
        {
            points = new Point[Number];

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"{i+1} точка");
                points[i] = CreatePoint();
            }

        }

        public Figure()
        {
            Console.WriteLine("Введите количество yглов новой фигyры");
            Number = Convert.ToInt32(Console.ReadLine());
            InitFigure();
        }

        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        double CalculatePerimeter()
        {
            double perimetr = 0;
            for(int i = 0; i < points.Length -1 ; i++)
            {
                perimetr += LengthSide(points[i], points[i + 1]);
            }
            perimetr += LengthSide(points[0], points[points.Length-1]);

            return perimetr;
        }

        string FigureName()
        {
            if (Number == 3) name = "3";
            else if (Number == 4) name = "4";
            else if (Number == 5) name = "5";
            return name;
        }

        public void Show()
        {
            Console.WriteLine(new string('-',50));
            Console.WriteLine($"Figure name is {FigureName()}");
            Console.WriteLine($"Perimetr is {CalculatePerimeter()}");
        }

    }
}
