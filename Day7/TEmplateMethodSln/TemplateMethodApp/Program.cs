namespace TemplateMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoardGame game = new TicTacToeGame();
            game.Play();
           
        }
    }
}