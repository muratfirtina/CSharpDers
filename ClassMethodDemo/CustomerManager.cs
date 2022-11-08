using System;
namespace ClassMethodDemo
{
    public class CustomerManager
    {

        
        public void Ekle(Customer customer)
        {
            Console.WriteLine(customer.Adi + " " + customer.Soyadi + " Müşteri olarak başarıyla eklenmiştir.");
        }


        public void Listele(params Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Id : " + customer.Id + "\n" + "Tc : " + customer.Tc + "\n" + "Müşteri Adı : " +
                    customer.Adi + "\n" + "Müşteri Soyadı : " + customer.Soyadi);
                Console.WriteLine("----------------------------------");
            }
            

        }


        public void Sil(Customer customer)
        {
            Console.WriteLine(customer.Adi + " " + customer.Soyadi + " Müşteri başarıyla silindi.");
        }
    }
}

