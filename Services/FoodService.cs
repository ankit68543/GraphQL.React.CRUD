using GraphQL.React.CRUD.Contracts;
using GraphQL.React.CRUD.Models;

namespace GraphQL.React.CRUD.Services
{
    public class FoodService : IFoodService
    {
        private readonly List<Food> foods;
        public FoodService()
        {
            foods = new()
            {
                new()
                {
                    Name = "Bread",
                    Allergens=new()
                    {
                        new()
                        {
                            Name="Gluten"
                        },
                        new()
                        {
                            Name="Sugar"
                        }
                    }
                }
            };
        }
        public Food AddFood(Food food)
        {
            foods.Add(food);
            return food;
        }

        public Food DeleteFoodById(Guid Id)
        {
            var foodToBeRemoved = foods.Find(x => x.Id == Id);
            if (foodToBeRemoved != null)
            {
                foods.Remove(foodToBeRemoved);
                return foodToBeRemoved;
            }

            throw new Exception("Food Not Found");
        }

        public Food GetFoodById(Guid Id)
        {
            return foods.Find(x => x.Id == Id);
        }

        public IEnumerable<Food> GetFoodByName(string Name)
        {
            return foods.Where(x => x.Name.ToLower().Contains(Name.ToLower()));
        }

        public IEnumerable<Food> GetFoods()
        {
            return foods;
        }
    }
}
