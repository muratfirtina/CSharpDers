using GameDemo.Abstract;
using GameDemo.Adapters;
using GameDemo.Entities;

GamerManager gamerManager = new GamerManager(new GamerCheckManager()); //Mernis ekli istersek değiştirebiliriz.
Gamer gamer1 = new Gamer
{
    Id = 1, NickName = "Deneme", FirstName = "Denek", LastName = "Denekoglu", DayOfBirth = new DateTime(1983, 05, 05),
    NationalityId = "1234567543"
};
gamerManager.Add(gamer1);

Gamer gamer2 = new Gamer
{
    Id = 2, NickName = "Deneme2", FirstName = "Denek2", LastName = "Denekoglu", DayOfBirth = new DateTime(1985, 06, 06),
    NationalityId = "1234567543"
};
gamerManager.Add(gamer2);

Console.WriteLine("------------Eklenen Oyunlar------------------");

ProductManager productManager = new ProductManager();
Product product1 = new Product {Id = 10, ProductName = "FIFA2022", ProductPrice = 90};
productManager.Add(product1);
Product product2 = new Product {Id = 11, ProductName = "NFS7", ProductPrice = 80};
productManager.Add(product2);
Product product3 = new Product {Id = 12, ProductName = "PES2022", ProductPrice = 95};
productManager.Add(product3);

Console.WriteLine("------------Eklenen Kampanyalar------------------");

CampaignManager campaignManager = new CampaignManager();
Campaign campaign1 = new Campaign { Id = 20, CampaignName = "Yeni Yıl", DiscountRate = 10 };
campaignManager.Add(campaign1);
Campaign campaign2 = new Campaign { Id = 21, CampaignName = "Hızlı ve Ucuz", DiscountRate = 15 };
campaignManager.Add(campaign2);
Campaign campaign3 = new Campaign { Id = 22, CampaignName = "Futbol Haftası", DiscountRate = 30 };
campaignManager.Add(campaign3);

Console.WriteLine("------------Yapılan Satışlar------------------");

SalesManager salesManager = new SalesManager();
Sales sales1 = new Sales {Id = 101, ProductName = product1.ProductName, ProductPrice = product1.ProductPrice,CampaignName = campaign3.CampaignName, DiscountRate = campaign3.DiscountRate, GamerNickName = gamer1.NickName};
salesManager.Add(sales1,gamer1,product1,campaign3);
Sales sales2 = new Sales {Id = 101, ProductName = product2.ProductName, ProductPrice = product2.ProductPrice, GamerNickName = gamer2.NickName};
salesManager.Add2(sales2,product2,gamer2);

List<Product> products = new List<Product> { product1, product2, product3 }; // Oyunların listesi
productManager.GetAll(products);

List<Campaign> campaigns = new List<Campaign>{campaign1, campaign2, campaign2}; // Kampanyaların listesi
campaignManager.GetAll(campaigns);

Console.WriteLine("-------Oyuncu Bilgileri-------");
gamerManager.Get(gamer1); //Oyuncu bilgilerini tektek getirmek için.
Console.WriteLine("-------Oyuncu Listesi-------");
gamerManager.GetAll(gamers: new List<Gamer>{gamer1,gamer2}); //Oyuncu bilgilerini liste halinde getirmek için.

Console.WriteLine("------Id ye göre satış-------");
salesManager.Get(sales1); // Id ye göre satış bilgileri
Console.WriteLine("-------Tüm Satışlar--------");
salesManager.GetAll(salesList: new List<Sales>{sales1,sales2}); // Tüm Satışların listesi

Console.WriteLine("-------Kampanyaların silinmesi-------");
campaignManager.Delete(campaign1);

Console.WriteLine("-------Kampanyaların güncellenmesi-------");
campaignManager.Update(new Campaign{CampaignName = campaign1.CampaignName, Id = campaign1.Id, DiscountRate = 22});