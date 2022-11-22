using GameDemo.Entities;

namespace GameDemo.Abstract;

public interface IProductService
{
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);
    void GetAll(List<Product> products);
}