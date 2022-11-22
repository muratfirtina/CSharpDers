using GameDemo.Entities;

namespace GameDemo.Abstract;

public class SalesManager : ISalesService
{
    public void Add2(Sales sales, Product product, Gamer gamer)
    {
        Console.WriteLine("Oyun {0} - Birim Fiyatı : {1} TL 'den Kampanyasız olarak --> {2} Nickli Kullanıcıya satılmıştır.\n",
            product.ProductName,product.ProductPrice, gamer.NickName);
    }
    public void Add(Sales sales, Gamer gamer,Product product , Campaign campaign)
    {
        double unitPrice = Convert.ToDouble(product.ProductPrice);
        double discountRate = Convert.ToDouble(campaign.DiscountRate);
        double totalPrice = unitPrice - (unitPrice * discountRate / 100);
        
        
        Console.WriteLine("Oyun {0} - Birim Fiyatı : {1} TL\nKampanya Adı : {2} - İndirim Oranı : % {3}  --> İndirimli Fiyat : {4} TL olarak {5} Nickli kullanıcıya satılmıştır\n",
            product.ProductName,product.ProductPrice,campaign.CampaignName,campaign.DiscountRate,totalPrice, gamer.NickName);
        
    }
    

    public void Cancel(Sales sales, Gamer gamer,Product product , Campaign campaign)
    {
        Console.WriteLine(gamer.NickName + " Kullanıcısına yapılan " + product.ProductName + " Oyunu ve" + campaign.CampaignName + " Kampanyası İptal edilmiştir.");
    }

    public void Get(Sales sales)
    {
        Console.WriteLine(sales.Id + " Id' li satışın bilgileri");
        
        Console.WriteLine(" Satın alan kullanıcı : {0} \n Satın alınan oyun : {1} \n Satış fiyatı : {2} \n Faydanalınan Kampanya : {3} \n Kampanyalı Satış Fiyatı : {4}\n",
            sales.GamerNickName, sales.ProductName, sales.ProductPrice, sales.CampaignName, (sales.ProductPrice - (sales.ProductPrice * sales.DiscountRate / 100)));
    }

    public void GetAll(List<Sales> salesList)
    {
        foreach (var sales in salesList)
        {
           Console.WriteLine(" Satın alan kullanıcı : {0} \n Satın alınan oyun : {1} \n Satış fiyatı : {2} \n Faydanalınan Kampanya : {3} \n Kampanyalı Satış Fiyatı : {4}\n",
               sales.GamerNickName, sales.ProductName, sales.ProductPrice, sales.CampaignName, (sales.ProductPrice - (sales.ProductPrice * sales.DiscountRate / 100)));
        }
    }
}