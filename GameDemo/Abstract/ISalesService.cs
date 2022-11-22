using GameDemo.Entities;

namespace GameDemo.Abstract;

public interface ISalesService
{
    void Add(Sales sales, Gamer gamer,Product product , Campaign campaign);
    void Cancel(Sales sales, Gamer gamer,Product product , Campaign campaign);
    void Get(Sales sales);
    
    void GetAll(List<Sales> salesList);
}