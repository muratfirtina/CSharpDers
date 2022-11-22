using System.Security.AccessControl;
using GameDemo.Abstract;

namespace GameDemo.Entities;

public class Product:IEntitiy
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int ProductPrice { get; set; }
    
}