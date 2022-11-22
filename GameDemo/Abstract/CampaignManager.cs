using GameDemo.Entities;

namespace GameDemo.Abstract;

public class CampaignManager : ICampaignService
{
    public void Add(Campaign campaign)
    {
        Console.WriteLine("% " + campaign.DiscountRate + " indirimli " + campaign.CampaignName + " Kampanyası eklendi");
    }

    public void Update(Campaign campaign)
    {
        Console.WriteLine(campaign.CampaignName + " Kampanyası güncellendi");
    }

    public void Delete(Campaign campaign)
    {
        Console.WriteLine(campaign.CampaignName + " Kampanyası silindi");
    }
    

    public void GetAll(List<Campaign> campaigns)
    {
        Console.WriteLine("--------------Güncel Kampanyalar-------------");
        foreach (var campaign in campaigns)
        {
            Console.WriteLine("Kampanya Adı : {0} - Kampanya Oranı : % {1}",
                campaign.CampaignName, campaign.DiscountRate);
        }
    }
}