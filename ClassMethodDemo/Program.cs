// See https://aka.ms/new-console-template for more information

using ClassMethodDemo;

public class Program
{
    public static void Main(string[] args)
    {
        Customer customer1 = new Customer();
        customer1.Id = 1;
        customer1.Tc = 12345678910;
        customer1.Adi = "Murat";
        customer1.Soyadi = "FIRTINA";

        Customer customer2 = new Customer { Id = 2, Tc = 12345678911, Adi = "Emel", Soyadi = "FIRTINA" };
        Customer customer3 = new Customer { Id = 3, Tc = 12345678912, Adi = "Vera", Soyadi = "FIRTINA" };


        CustomerManager manager = new CustomerManager();

        manager.Ekle(customer1);
        manager.Ekle(customer2);
        manager.Ekle(customer3);

        Console.WriteLine("---------------------------------");

        Customer[] customers = new Customer[] {customer1,customer2,customer3};

        //tümünü listele
        manager.Listele(customers);


        //tek tek listele
        manager.Listele(customer3);

        manager.Sil(customer1);
    }
}