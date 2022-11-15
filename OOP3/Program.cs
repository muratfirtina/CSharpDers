using OOP3;

ICreditManager consumerLoanManager = new ConsumerLoanManager();

ICreditManager vehicleLoanManager = new VehicleLoanManager();

ICreditManager housingLoanManager = new HousingLoanManager();

ILoggerService fiLoggerService = new FileLoggerService();

ApplicationManager applicationManager = new ApplicationManager();
applicationManager.BasvuruYap(consumerLoanManager, new List<ILoggerService>{new DatabaseLoggerService(), new FileLoggerService()});

List<ICreditManager> credits = new List<ICreditManager>(){consumerLoanManager, vehicleLoanManager};

//applicationManager.KrediOnBilgilendirmesiYap(credits);