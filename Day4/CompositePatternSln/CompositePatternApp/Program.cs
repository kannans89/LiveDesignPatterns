using CompositePatternApp.Model;


namespace CompositePatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Folder compositeRoot = new Folder("Movies");
            compositeRoot.AddChild(new File("A.avi", 400));
            compositeRoot.AddChild(new File("B.avi", 500));

            Folder action = new Folder("Action");
            action.AddChild(new File("B.avi", 700));

            compositeRoot.AddChild(action);

            Folder drama = new Folder("Drama");
            drama.AddChild(new File("C.avi", 800));
            compositeRoot.AddChild(drama);
            //compositeRoot.AddChild(new File("B.avi", 500));
            compositeRoot.Display();
        }
    }
}