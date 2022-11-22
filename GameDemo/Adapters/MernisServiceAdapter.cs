using GameDemo.Abstract;
using GameDemo.Entities;
using GameDemo.KPSPublic;

namespace GameDemo.Adapters;

public class MernisServiceAdapter : IGamerCheckService
{
    public bool CheckIfRealPerson(Gamer gamer)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        var result = client.TCKimlikNoDogrulaAsync
        (Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), Convert.ToInt32(gamer.DayOfBirth.Year)).GetAwaiter().GetResult();
        return result.Body.TCKimlikNoDogrulaResult;
    }
}