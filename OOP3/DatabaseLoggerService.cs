namespace OOP3;

public class DatabaseLoggerService : ILoggerService
{
    public void Log()
    {
        Console.WriteLine("Veritabanına loglandı");
    }
}