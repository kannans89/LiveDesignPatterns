namespace SimpleMediatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            TableView table = new TableView(mediator);
            PieChart pie = new PieChart(mediator);
            GridView grid = new GridView(mediator);

            mediator.Add(table);
            mediator.Add(pie);
            mediator.Add(grid);

            pie.SetData("xyz");
        }
    }
}