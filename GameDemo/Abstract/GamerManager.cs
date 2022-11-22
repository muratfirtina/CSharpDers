using GameDemo.Entities;

namespace GameDemo.Abstract;

public class GamerManager : IGamerService
{
    private IGamerCheckService _gamerCheckService;

    public GamerManager(IGamerCheckService gamerCheckService)
    {
        _gamerCheckService = gamerCheckService;
    }

    public void Add(Gamer gamer)
    {
        if (_gamerCheckService.CheckIfRealPerson(gamer) == true)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " İsimli oyuncu sisteme kaydedilmiştir.");
        }
        else
        {
            throw new Exception("Not a valid person");
        }
    }

    public void Update(Gamer gamer)
    {
        if (_gamerCheckService.CheckIfRealPerson(gamer))
        {
            
            Console.WriteLine(gamer.FirstName + gamer.LastName + " İsimli oyuncu bilgileri güncellenmiştir.");
        }
        else
        {
            throw new Exception("Kişi doğrulanamadı.");
        }
    }

    public void Delete(Gamer gamer)
    {
        Console.WriteLine(gamer.NickName + "Adlı kullanıcı silinmiştir.");
    }

    public void Get(Gamer gamer) //Oyuncu bilgilerini tektek getirmek için.
    {
        Console.WriteLine(gamer.NickName + " Nickli oyuncunun bilgileri.");
        Console.WriteLine(" Oyuncu Id : {0}\n Kullanıcı Adı : {1} \n Oyuncu Adı : {2} \n Oyuncu Soyadı : {3} \n Oyuncu Doğum Tarihi : {4}\n", 
            gamer.Id, gamer.NickName, gamer.FirstName, gamer.LastName, gamer.DayOfBirth.Year);
        
    }

    public void GetAll(List<Gamer> gamers) //Oyuncu bilgilerini liste halinde getirmek için.
    {
        foreach (var gamer in gamers)
        {
            Console.WriteLine("Oyuncu Id : {0} - Kullanıcı Adı : {1} - Oyuncu Adı : {2} - Oyuncu Soyadı : {3} - Oyuncu Doğum Tarihi : {4}\n", 
                gamer.Id, gamer.NickName, gamer.FirstName, gamer.LastName, gamer.DayOfBirth.Year);
        }
        

    }
}