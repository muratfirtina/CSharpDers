using GameDemo.Entities;

namespace GameDemo.Abstract;

public class ProductManager : IProductService

{
    public void Add(Product product)
    {
        Console.WriteLine(product.ProductName + " İsimli Oyun " + product.ProductPrice + " Tl Fiyattan eklenmiştir.");
    }

    public void Update(Product product)
    {
        Console.WriteLine(product.ProductName + " İsimli Oyunun Fiyatı " + product.ProductPrice + " Tl Olarak Güncellenmiştir.");
    }

    public void Delete(Product product)
    {
        Console.WriteLine(product.ProductName + " İsimli Oyun Silinmiştir. ");

    }
    
    public void GetAll(List<Product> products)
    {
        Console.WriteLine("--------Güncel Oyunlar Listesi ve Fiyatları-------");
        foreach (var product in products)
        {
            
            Console.WriteLine("Oyun Adı : " + product.ProductName + "-- Oyun Fiyatı : " + product.ProductPrice );
        }
    }
}