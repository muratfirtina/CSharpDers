using OOP2;

Individual customer1 = new Individual();
customer1.Id = 1;
customer1.CustomerNo = "12345";
customer1.Name = "Murat";
customer1.Surname = "FIRTINA";
customer1.TcNo = "12345678910";

Coorporate customer2 = new Coorporate();
customer2.Id = 2;
customer2.CustomerNo = "54321";
customer2.CompanyName = "FIRTINA.Co";
customer2.TaxNo = "987654321";

Customer customer3 = new Individual();
Customer customer4 = new Coorporate();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(customer3);
customerManager.Add(customer4);
