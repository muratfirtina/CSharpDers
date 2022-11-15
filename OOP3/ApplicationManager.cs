namespace OOP3;

public class ApplicationManager
{
    public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
    {
        creditManager.BiseyYap();
        foreach (var loggerService in loggerServices)
        {
            loggerService.Log();
        }
    }

    public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
    {
        foreach (var credit in credits)
        {
            credit.BiseyYap();
        }
    }
}