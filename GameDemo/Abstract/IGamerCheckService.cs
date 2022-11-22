using GameDemo.Entities;

namespace GameDemo.Abstract;

public interface IGamerCheckService
{
    bool CheckIfRealPerson(Gamer gamer);
}