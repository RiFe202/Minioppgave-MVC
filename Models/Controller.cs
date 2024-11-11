public class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void UpdateData(string newData)
    {
        _model.Data = newData;
        _view.Display(_model.Data);
    }

    public void Start()
    {
        string input;
        do
        {
            Console.Write("Enter new data (or 'exit' to quit): ");
            input = Console.ReadLine();
            if (input != "exit")
            {
                UpdateData(input);
            }
        } while (input != "exit");
    }
}