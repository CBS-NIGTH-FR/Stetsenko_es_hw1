using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;

            Console.Write("enter side1: ");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter side2: ");
            side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle resalt = new Rectangle(side1, side2);
            resalt.Show();

            Console.ReadKey();
        }
    }
}
