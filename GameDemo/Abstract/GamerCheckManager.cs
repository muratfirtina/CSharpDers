using GameDemo.Entities;
using GameDemo.KPSPublic;

namespace GameDemo.Abstract;

public class GamerCheckManager : IGamerCheckService
{
    public bool CheckIfRealPerson(Gamer gamer)
    {
        return true;
    }
}