namespace BridgeShapeProblemRefactored
{
    using System;

    public class ColorProperties
    {
        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }
        public double Opacity { get; }

        public ColorProperties(int red, int green, int blue, double opacity)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Opacity = opacity;
        }


    }

    public interface IColor
    {
        void ApplyColor(ColorProperties color);
    }

    public class Red : IColor
    {
        public void ApplyColor(ColorProperties color)
        {
            Console.WriteLine($"Applying red color with RGB({color.Red}, {color.Green}, {color.Blue}) and opacity {color.Opacity}");
        }
    }

    public class Green : IColor
    {
        public void ApplyColor(ColorProperties color)
        {
            Console.WriteLine($"Applying green color with RGB({color.Red}, {color.Green}, {color.Blue}) and opacity {color.Opacity}");
        }
    }

    public class Blue : IColor
    {
        public void ApplyColor(ColorProperties color)
        {
            Console.WriteLine($"Applying blue color with RGB({color.Red}, {color.Green}, {color.Blue}) and opacity {color.Opacity}");
        }
    }

    public abstract class Shape
    {
        protected IColor color;//bridge

        public Shape(IColor color)
        {
            this.color = color ?? throw new ArgumentNullException(nameof(color));
        }

        public abstract void ApplyColor();
    }

    public class Circle : Shape
    {

        public Circle(IColor color) : base(color)
        {
        }

        public override void ApplyColor()
        {
            color.ApplyColor(new ColorProperties(255, 255, 255, 1.0)); // Example values, replace with actual color properties
        }
    }

    public class Square : Shape
    {

        public Square(IColor color) : base(color)
        {
        }

        public override void ApplyColor()
        {
            color.ApplyColor(new ColorProperties(255, 255, 255, 1.0)); // Example values, replace with actual color properties
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IColor blue = new Red();
            Shape square = new Square(blue);
            square.ApplyColor();
           
        }
    }

}