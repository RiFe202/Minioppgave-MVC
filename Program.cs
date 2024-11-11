namespace Minioppgave_MVC;

class Program
{
    static void Main(string[] args)
    {
        Model model = new Model("Initial Data");
        View view = new View();
        Controller controller = new Controller(model, view);

        controller.Start();
    }
}
