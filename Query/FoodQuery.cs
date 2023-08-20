using GraphQL.React.CRUD.Contracts;
using GraphQL.React.CRUD.Models;

namespace GraphQL.React.CRUD.Query
{
    public class FoodQuery
    {
        private readonly IFoodService foodService;
        public FoodQuery(IFoodService _foodService)
        {
            foodService = _foodService;
        }

        public IEnumerable<Food> GetFoods() => foodService.GetFoods();
        public IEnumerable<Food> GetFoodByName(string Name) => foodService.GetFoodByName(Name);
        public Food GetFoodById(Guid Id) => foodService.GetFoodById(Id);
    }
}
