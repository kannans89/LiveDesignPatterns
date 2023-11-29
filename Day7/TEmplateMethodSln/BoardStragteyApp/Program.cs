using TemplateMethodApp;

namespace BoardStragteyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var board = new BoardGame(new TicTacToeGame());
            board.Play();

        }
    }
}