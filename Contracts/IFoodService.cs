using GraphQL.React.CRUD.Models;

namespace GraphQL.React.CRUD.Contracts
{
    public interface IFoodService
    {
        IEnumerable<Food> GetFoods();
        Food GetFoodById(Guid Id);
        IEnumerable<Food> GetFoodByName(string Name);
        Food AddFood(Food food);
        Food DeleteFoodById(Guid Id);
    }
}
