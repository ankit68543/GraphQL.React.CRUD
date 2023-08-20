using GraphQL.React.CRUD.Contracts;
using GraphQL.React.CRUD.Models;

namespace GraphQL.React.CRUD.Mutation
{
    public class FoodMutation
    {
        private readonly IFoodService foodService;
        public FoodMutation(IFoodService _foodService)
        {
            foodService = _foodService;
        }

        public Food AddFood(Food food) => foodService.AddFood(food);

        public Food DeleteFood(Guid Id) => foodService.DeleteFoodById(Id);

    }
}
