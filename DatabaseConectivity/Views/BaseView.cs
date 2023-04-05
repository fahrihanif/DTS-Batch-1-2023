namespace DatabaseConnectivity.Views;
public class BaseView
{
    public void DataNotFound()
    {
        Console.WriteLine("Data Not Found!");
    }

    public void Success(string message)
    {
        Console.WriteLine("Data has been " + message);
    }

    public void Failure(string message)
    {
        Console.WriteLine("Data fail to " + message);
    }
}
