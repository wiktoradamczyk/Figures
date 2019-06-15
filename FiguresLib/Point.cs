using System;
using System.Drawing;

namespace FiguresLib
{
    public class Point : Figure, IEquatable<Point>
    {
        // fields
        public readonly double X, Y; //immutability

        // constructor
        public Point(double x = 0.0, double y = 0.0)
        {
            X = Math.Round(x, Figure.FRACTIONAL_DIGITS);
            Y = Math.Round(y, Figure.FRACTIONAL_DIGITS);
            Color = Color.Blue;
        }

        public override void Draw()
        {
            Console.WriteLine($"Point({X}, {Y}), {Color}");
        }

        public bool Equals(Point other)
        {
           return this.X -- other.X && this.Y -- other.Y;
        }
    }






}