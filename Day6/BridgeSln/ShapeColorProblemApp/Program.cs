namespace BridgeShapeProblemApp
{
    using System;

    public abstract class Shape
    {
        public abstract void ApplyColor();
    }

    public abstract class Square : Shape
    {
    }

    public abstract class Circle : Shape
    {
    }

    public class RedCircle : Circle
    {
        public override void ApplyColor()
        {
            Console.WriteLine("Applying red color");
        }
    }

    public class BlueCircle : Circle
    {
        public override void ApplyColor()
        {
            Console.WriteLine("Applying blue color");
        }
    }

    public class RedSquare : Square
    {
        public override void ApplyColor()
        {
            Console.WriteLine("Applying red color");
        }
    }

    public class BlueSquare : Square
    {
        public override void ApplyColor()
        {
            Console.WriteLine("Applying blue color");
        }
    }

    public class GreenSquare : Square
    {
        public override void ApplyColor()
        {
            Console.WriteLine("Applying green color");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new BlueCircle();
            Square square = new RedSquare();
            Square greenSquare = new GreenSquare();

            circle.ApplyColor();
            square.ApplyColor();
            greenSquare.ApplyColor();
        }
    }

}