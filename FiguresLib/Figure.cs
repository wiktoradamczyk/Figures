using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FiguresLib
{
    abstract public class Figure
    {
        public const int FRACTIONAL_DIGITS = 4;
        public string Label { get; set; }

        public Color Color { get; set; }

        private static int counter = 0;
        public Figure()
        {
            counter++;
            this.Color = Color.Black;
            Label = $"{GetType().Name} #{counter}";
        }

        abstract public void Draw();

        public override string ToString() => $"Figure: {Label}";
    }
}
