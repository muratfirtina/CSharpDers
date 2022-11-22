using System.Security.AccessControl;
using GameDemo.Abstract;

namespace GameDemo.Entities;

public class Sales : IEntitiy
{
    
    public int Id { get; set; }
    public string GamerNickName { get; set; }
    public string ProductName { get; set; }
    public string CampaignName { get; set; }
    public int DiscountRate { get; set; }
    public int ProductPrice { get; set; }
}