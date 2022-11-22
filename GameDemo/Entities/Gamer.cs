using GameDemo.Abstract;

namespace GameDemo.Entities;

public class Gamer:IEntitiy
{
    public int Id { get; set; }
    public string NickName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DayOfBirth { get; set; }
    public string NationalityId { get; set; }
}