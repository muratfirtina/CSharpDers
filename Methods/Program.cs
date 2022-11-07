// See https://aka.ms/new-console-template for more information


using Methods;

Product product1 = new Product();
product1.Adi = "Elma";
product1.Fiyat = 15;
product1.Aciklama = "Amasya Elması";

Product product2 = new Product();
product2.Adi = "Karpuz";
product2.Fiyat = 80;
product2.Aciklama = "Diyarbakır";

Product[] products = new Product[] {product1,product2};

foreach (Product product in products)
{
    Console.WriteLine("Urun Adı : " + product.Adi);
    Console.WriteLine("Urun Fiyatı : " + product.Fiyat);
    Console.WriteLine("Urun Açıklaması : " + product.Aciklama);
    Console.WriteLine("---------------");
}

Console.WriteLine("-----------------Metotlar--------------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);
sepetManager.Ekle(product2);

//hatalı kullanım
sepetManager.Ekle2("Armut" , 12 ,"Yeşil");