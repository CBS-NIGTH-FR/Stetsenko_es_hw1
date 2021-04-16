using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Rectangle
    {
        double side1;
        double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double AreaCalculating()
        {

            return side1 * side2;
        }

        double PerimetrCalculating()
        {
            return 2 * (side1 + side2);
        }

        public void Show()
        {

            Console.WriteLine($"Area is {AreaCalculating()}");
            Console.WriteLine($"Perimetr is {PerimetrCalculating()}");
        }
    }
}
