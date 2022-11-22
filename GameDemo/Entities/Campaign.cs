using GameDemo.Abstract;

namespace GameDemo.Entities;

public class Campaign:IEntitiy
{
    public int Id { get; set; }
    public string CampaignName { get; set; }
    public int DiscountRate { get; set; }
}