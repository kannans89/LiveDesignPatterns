using LSPRefactored.Model;

namespace LSPRefactored
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ShouldNotChangeHeight_IfWidthIsModified(new Rectangle(10, 20));
            //ShouldNotChangeHeight_IfWidthIsModified(new Square(30));
        }

        static void ShouldNotChangeHeight_IfWidthIsModified(Rectangle rectangle)
        {
            int beforeChange = rectangle.GetHeight();
            rectangle.SetWidth(rectangle.GetWidth() + 10);
            int afterChange = rectangle.GetHeight();


            Console.WriteLine(beforeChange == afterChange);
            Console.WriteLine(beforeChange);
            Console.WriteLine(afterChange);
        }
    }
}